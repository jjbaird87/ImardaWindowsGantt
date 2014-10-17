using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using JetBrains.Annotations;

namespace I360_POC.Classes
{
    /// <summary>
    /// Class to read csv content from various sources
    /// </summary>
    public sealed class CsvReader : IDisposable
    {

        #region Members

        private FileStream _fileStream;
        private Stream _stream;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        private Stream _memoryStream;
        private Encoding _encoding;
        private readonly StringBuilder _columnBuilder = new StringBuilder(100);
        private readonly Type _type = Type.File;

        #endregion Members

        #region Properties

        /// <summary>
        /// Gets or sets whether column values should be trimmed
        /// </summary>
        public bool TrimColumns { private get; set; }

        /// <summary>
        /// Gets or sets whether the csv file has a header row
        /// </summary>
        public bool HasHeaderRow { get; set; }

        /// <summary>
        /// Returns a collection of fields or null if no record has been read
        /// </summary>
        [CanBeNull]
        public List<string> Fields { get; private set; }

        /// <summary>
        /// Gets the field count or returns null if no fields have been read
        /// </summary>
        [UsedImplicitly]
        public int? FieldCount
        {
            get
            {
                return (Fields != null ? Fields.Count : (int?)null);
            }
        }

        #endregion Properties

        #region Enums

        /// <summary>
        /// Type enum
        /// </summary>
        private enum Type
        {
            File,
            Stream,
            String
        }

        #endregion Enums

        #region Constructors

        /// <summary>
        /// Initializes the reader to work from a file
        /// </summary>
        /// <param name="filePath">File path</param>
        public CsvReader([NotNull] string filePath)
        {
            _type = Type.File;
            Initialize(filePath, Encoding.Default);
        }

        /// <summary>
        /// Initializes the reader to work from a file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="encoding">Encoding</param>
        public CsvReader([NotNull] string filePath, [NotNull] Encoding encoding)
        {
            _type = Type.File;
            Initialize(filePath, encoding);
        }

        /// <summary>
        /// Initializes the reader to work from an existing stream
        /// </summary>
        /// <param name="stream">Stream</param>
        public CsvReader([NotNull] Stream stream)
        {
            _type = Type.Stream;
            Initialize(stream, Encoding.Default);
        }

        /// <summary>
        /// Initializes the reader to work from an existing stream
        /// </summary>
        /// <param name="stream">Stream</param>
        /// <param name="encoding">Encoding</param>
        public CsvReader([NotNull] Stream stream, [NotNull] Encoding encoding)
        {
            _type = Type.Stream;
            Initialize(stream, encoding);
        }

        /// <summary>
        /// Initializes the reader to work from a csv string
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="csvContent"></param>
        public CsvReader([CanBeNull] Encoding encoding, [NotNull] string csvContent)
        {
            _type = Type.String;
            Initialize(encoding, csvContent);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Initializes the class to use a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        private void Initialize([NotNull] string filePath, [NotNull] Encoding encoding)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(string.Format("The file '{0}' does not exist.", filePath));

            _fileStream = File.OpenRead(filePath);
            Initialize(_fileStream, encoding);
        }

        /// <summary>
        /// Initializes the class to use a stream
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
// ReSharper disable once CodeAnnotationAnalyzer
        private void Initialize(Stream stream, Encoding encoding)
        {
            if (stream == null)
// ReSharper disable once NotResolvedInText
                throw new ArgumentNullException("The supplied stream is null.");

            _stream = stream;
            _stream.Position = 0;
            _encoding = (encoding ?? Encoding.Default);
            _streamReader = new StreamReader(_stream, _encoding);
        }

        /// <summary>
        /// Initializes the class to use a string
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="csvContent"></param>
        private void Initialize([CanBeNull] Encoding encoding, [CanBeNull] string csvContent)
        {
            if (csvContent == null)
// ReSharper disable once NotResolvedInText
                throw new ArgumentNullException("The supplied csvContent is null.");

            _encoding = (encoding ?? Encoding.Default);

            _memoryStream = new MemoryStream(csvContent.Length);
            _streamWriter = new StreamWriter(_memoryStream);
            _streamWriter.Write(csvContent);
            _streamWriter.Flush();
            Initialize(_memoryStream, encoding);
        }

        /// <summary>
        /// Reads the next record
        /// </summary>
        /// <returns>True if a record was successfully read, otherwise false</returns>
        public bool ReadNextRecord()
        {
            Fields = null;
            string line = _streamReader.ReadLine();

            if (line == null)
                return false;

            ParseLine(line);
            return true;
        }

        /// <summary>
        /// Reads a csv file format into a data table.  This method
        /// will always assume that the table has a header row as this will be used
        /// to determine the columns.
        /// </summary>
        /// <returns></returns>
        [NotNull, UsedImplicitly]
        public DataTable ReadIntoDataTable()
        {
            return ReadIntoDataTable(new System.Type[] {});
        }

        /// <summary>
        /// Reads a csv file format into a data table.  This method
        /// will always assume that the table has a header row as this will be used
        /// to determine the columns.
        /// </summary>
        /// <param name="columnTypes">Array of column types</param>
        /// <returns></returns>
        [NotNull]
        private DataTable ReadIntoDataTable([NotNull] IList<System.Type> columnTypes)
        {
            var dataTable = new DataTable();
            bool addedHeader = false;
            _stream.Position = 0;

            while (ReadNextRecord())
            {
                if (!addedHeader)
                {
                    if (Fields != null)
                    {
                        for (var i = 0; i < Fields.Count; i++)
                            dataTable.Columns.Add(Fields[i], (columnTypes.Count > 0 ? columnTypes[i] : typeof (string)));

                        addedHeader = true;
                        continue;
                    }
                }

                var row = dataTable.NewRow();

                if (Fields != null)
                {
                    for (var i = 0; i < Fields.Count; i++)
                        row[i] = Fields[i];
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        /// <summary>
        /// Parses a csv line
        /// </summary>
        /// <param name="line">Line</param>
        private void ParseLine([NotNull] string line)
        {
            Fields = new List<string>();
            bool inColumn = false;
            bool inQuotes = false;
            bool inBlankField = false;
            _columnBuilder.Remove(0, _columnBuilder.Length);

            // Iterate through every character in the line
            for (var i = 0; i < line.Length; i++)
            {
                var character = line[i];

                // If we are not currently inside a column
                if (!inColumn)
                {
                    // If the current character is a double quote then the column value is contained within
                    // double quotes, otherwise append the next character
                    if (character == '"')
                        inQuotes = true;
                    else if (character == ',')
                    {
                        Fields.Add(TrimColumns ? _columnBuilder.ToString().Trim() : _columnBuilder.ToString());
                        _columnBuilder.Remove(0, _columnBuilder.Length);
                    }
                    else
                    {
                        _columnBuilder.Append(character);
                    }


                    inColumn = true;
                    continue;
                }

                // If we are in between double quotes
                if (inQuotes)
                {
                    // If the current character is a double quote and the next character is a comma or we are at the end of the line
                    // we are now no longer within the column.
                    // Otherwise increment the loop counter as we are looking at an escaped double quote e.g. "" within a column
                    if (character == '"' && ((line.Length > (i + 1) && line[i + 1] == ',') || ((i + 1) == line.Length)))
                    {
                        inQuotes = false;
                        inColumn = false;
                        i++;
                    }
                    else if (character == '"' && line.Length > (i + 1) && line[i + 1] == '"')
                        i++;
                }
                else if (character == ',')
                    inColumn = false;

                // If we are no longer in the column clear the builder and add the columns to the list
                if (!inColumn)
                {
                    Fields.Add(TrimColumns ? _columnBuilder.ToString().Trim() : _columnBuilder.ToString());
                    _columnBuilder.Remove(0, _columnBuilder.Length);
                }
                else // append the current column
                    _columnBuilder.Append(character);
            }

            // If we are still inside a column add a new one
            if (inColumn)
                Fields.Add(TrimColumns ? _columnBuilder.ToString().Trim() : _columnBuilder.ToString());
        }

        /// <summary>
        /// Disposes of all unmanaged resources
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
            {
                _streamReader.Close();
                _streamReader.Dispose();
            }

            if (_streamWriter != null)
            {
                _streamWriter.Close();
                _streamWriter.Dispose();
            }

            if (_memoryStream != null)
            {
                _memoryStream.Close();
                _memoryStream.Dispose();
            }

            if (_fileStream != null)
            {
                _fileStream.Close();
                _fileStream.Dispose();
            }

            if ((_type == Type.String || _type == Type.File) && _stream != null)
            {
                _stream.Close();
                _stream.Dispose();
            }
        }

        #endregion Methods

    }
}
