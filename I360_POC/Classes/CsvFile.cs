using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using JetBrains.Annotations;

namespace I360_POC.Classes
{

    /// <summary>
    /// Class to hold csv data
    /// </summary>
    [Serializable]
    public sealed class CsvFile
    {

        #region Properties

        /// <summary>
        /// Gets the file headers
        /// </summary>
        public readonly List<string> Headers = new List<string>();

        /// <summary>
        /// Gets the records in the file
        /// </summary>
        public readonly CsvRecords Records = new CsvRecords();

        /// <summary>
        /// Gets the header count
        /// </summary>
        [UsedImplicitly]
        public int HeaderCount
        {
            get
            {
                return Headers.Count;
            }
        }

        /// <summary>
        /// Gets the record count
        /// </summary>
        [UsedImplicitly]
        public int RecordCount
        {   
            get
            {
                return Records.Count;   
            }
        }

        #endregion Properties


        #region Methods

        /// <summary>
        /// Populates the current instance from the specified file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        [UsedImplicitly]
        public void Populate([NotNull] string filePath, bool hasHeaderRow)
        {
// ReSharper disable once AssignNullToNotNullAttribute
            Populate(filePath, null, hasHeaderRow, trimColumns: false);
        }

        /// <summary>
        /// Populates the current instance from the specified file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        [UsedImplicitly]
        public void Populate([NotNull] string filePath, bool hasHeaderRow, bool trimColumns)
        {
// ReSharper disable once AssignNullToNotNullAttribute
            Populate(filePath, null, hasHeaderRow, trimColumns);
        }

        /// <summary>
        /// Populates the current instance from the specified file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="encoding">Encoding</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        private void Populate([NotNull] string filePath, [NotNull] Encoding encoding, bool hasHeaderRow, bool trimColumns)
        {
            using (
                var reader = new CsvReader(filePath, encoding) {HasHeaderRow = hasHeaderRow, TrimColumns = trimColumns})
            {
                PopulateCsvFile(reader);
            }
        }

        /// <summary>
        /// Populates the current instance from a stream
        /// </summary>
        /// <param name="stream">Stream</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        [UsedImplicitly]
        public void Populate([NotNull] Stream stream, bool hasHeaderRow)
        {
// ReSharper disable once AssignNullToNotNullAttribute
            Populate(stream, null, hasHeaderRow, false);
        }

        /// <summary>
        /// Populates the current instance from a stream
        /// </summary>
        /// <param name="stream">Stream</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        [UsedImplicitly]
        public void Populate([NotNull] Stream stream, bool hasHeaderRow, bool trimColumns)
        {
// ReSharper disable once AssignNullToNotNullAttribute
            Populate(stream, null, hasHeaderRow, trimColumns);
        }

        /// <summary>
        /// Populates the current instance from a stream
        /// </summary>
        /// <param name="stream">Stream</param>
        /// <param name="encoding">Encoding</param>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        private void Populate([NotNull] Stream stream, [NotNull] Encoding encoding, bool hasHeaderRow, bool trimColumns)
        {
            using (var reader = new CsvReader(stream, encoding) {HasHeaderRow = hasHeaderRow, TrimColumns = trimColumns}
                )
            {
                PopulateCsvFile(reader);
            }
        }

        /// <summary>
        /// Populates the current instance from a string
        /// </summary>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="csvContent">Csv text</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        [UsedImplicitly]
        public void Populate(bool hasHeaderRow, [NotNull] string csvContent, bool trimColumns)
        {
// ReSharper disable once AssignNullToNotNullAttribute
            Populate(hasHeaderRow, csvContent, null, trimColumns);
        }

        /// <summary>
        /// Populates the current instance from a string
        /// </summary>
        /// <param name="hasHeaderRow">True if the file has a header row, otherwise false</param>
        /// <param name="csvContent">Csv text</param>
        /// <param name="encoding">Encoding</param>
        /// <param name="trimColumns">True if column values should be trimmed, otherwise false</param>
        private void Populate(bool hasHeaderRow, [NotNull] string csvContent, [CanBeNull] Encoding encoding = null, bool trimColumns = false)
        {
            using (
                var reader = new CsvReader(encoding, csvContent)
                {
                    HasHeaderRow = hasHeaderRow,
                    TrimColumns = trimColumns
                })
            {
                PopulateCsvFile(reader);
            }
        }

        /// <summary>
        /// Populates the current instance using the CsvReader object
        /// </summary>
        /// <param name="reader">CsvReader</param>
        private void PopulateCsvFile([NotNull] CsvReader reader)
        {
            Headers.Clear();
            Records.Clear();
            
            bool addedHeader = false;

            while (reader.ReadNextRecord())
            {
                if (reader.HasHeaderRow && !addedHeader)
                {
                    if (reader.Fields != null) reader.Fields.ForEach(field => Headers.Add(field));
                    addedHeader = true;
                    continue;
                }

                var record = new CsvRecord();
                if (reader.Fields != null) reader.Fields.ForEach(field => record.Fields.Add(field));
                Records.Add(record);
            }
        }

        #endregion Methods
        
    }

    /// <summary>
    /// Class for a collection of CsvRecord objects
    /// </summary>
    [Serializable]
    public sealed class CsvRecords : List<CsvRecord>
    {  
    }

    /// <summary>
    /// Csv record class
    /// </summary>
    [Serializable]
    public sealed class CsvRecord
    {
        #region Properties

        /// <summary>
        /// Gets the Fields in the record
        /// </summary>
        public readonly List<string> Fields = new List<string>();

        /// <summary>
        /// Gets the number of fields in the record
        /// </summary>
        [UsedImplicitly]
        public int FieldCount
        {
            get
            {
                return Fields.Count;
            }
        }

        #endregion Properties
    }
}
