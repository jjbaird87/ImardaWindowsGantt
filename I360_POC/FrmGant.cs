using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraMap;
using DevExpress.XtraScheduler;
using I360_POC.Classes;
using JetBrains.Annotations;

namespace I360_POC
{
    public partial class FrmGant : Form
    {
        public FrmGant()
        {
            InitializeComponent();

            schedulerStorage1.AppointmentsInserted += schedulerStorage1_AppointmentsInserted;
            schedulerStorage1.AppointmentsChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsChanged);
            schedulerStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
            schedulerStorage1.AppointmentDependenciesInserted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesInserted);
            schedulerStorage1.AppointmentDependenciesChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesChanged);
            schedulerStorage1.AppointmentDependenciesDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesDeleted);

            schedulerControl1.ActiveViewChanged += new EventHandler(schedulerControl1_ActiveViewChanged);
        }

        private void FrmGant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gantTestDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            this.taskDependenciesTableAdapter.Fill(this.gantTestDataSet.TaskDependencies);
            // TODO: This line of code loads data into the 'gantTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.gantTestDataSet.Appointments);
            // TODO: This line of code loads data into the 'gantTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.gantTestDataSet.Resources);

            schedulerStorage1.Appointments.CommitIdToDataSource = false;
            this.appointmentsTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(appointmentsTableAdapter_RowUpdated);

            schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.GanttView.ShowResourceHeaders = true; 

        }

        #region #RowUpdatedHandlers
        int id = 0;
        private void appointmentsTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", appointmentsTableAdapter.Connection))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    e.Row["UniqueId"] = id;
                }
            }
        }
        #endregion #RowUpdatedHandlers

        #region #Appointment
        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }
        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {

            CommitTask();
            schedulerStorage1.SetAppointmentId(((Appointment)e.Objects[0]), id);
        }
        void CommitTask()
        {

            appointmentsTableAdapter.Update(gantTestDataSet);
            this.gantTestDataSet.AcceptChanges();
        }
        #endregion #Appointment
        #region #TaskDependencies
        private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }
        void CommitTaskDependency()
        {
            taskDependenciesTableAdapter.Update(this.gantTestDataSet);
            this.gantTestDataSet.AcceptChanges();
        }
        #endregion #TaskDependencies

        private void schedulerControl1_ActiveViewChanged(object sender, EventArgs e)
        {
            bool isGanttView = schedulerControl1.ActiveViewType == SchedulerViewType.Gantt;

        }

        private void btnLoadFile_Click([NotNull] object sender, [NotNull] EventArgs e)
        {
            var openFile = new OpenFileDialog { Filter = @".csv files (*.csv)|*.csv|All files (*.*)|*.*" };
            if (openFile.ShowDialog() == DialogResult.OK)
                txtFileDir.Text = openFile.FileName;
        }

        private void btnLoadRoutes_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleNameList = new List<Vehicle>();

                if (txtFileDir.Text != "")
                {
                    var reader = new CsvReader(txtFileDir.Text);
                    DataTable routeTable = reader.ReadIntoDataTable();

                    foreach (DataRow row in routeTable.Rows)
                    {
                        if (vehicleNameList.Find(i => i.Name == row["VEHICLE_NAME"].ToString()) == null)
                        {
                            var vehicle = new Vehicle {Name = row["VEHICLE_NAME"].ToString()};
                            vehicleNameList.Add(vehicle);
                        }

                        //if (vehicleNameList.Find(i=>i.FirstStart<row[""]))
                    }
                }
                else
                {
                    MessageBox.Show(@"File name is not valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
