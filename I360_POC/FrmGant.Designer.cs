namespace I360_POC
{
    partial class FrmGant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.gantTestDataSet = new I360_POC.GantTestDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter = new I360_POC.GantTestDataSetTableAdapters.ResourcesTableAdapter();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new I360_POC.GantTestDataSetTableAdapters.AppointmentsTableAdapter();
            this.taskDependenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDependenciesTableAdapter = new I360_POC.GantTestDataSetTableAdapters.TaskDependenciesTableAdapter();
            this.btnLoadRoutes = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtFileDir = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.AppointmentDependencies.DataSource = this.taskDependenciesBindingSource;
            this.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "DependentId";
            this.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "ParentId";
            this.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type";
            this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.AppointmentId = "UniqueId";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("CustomField1", "CustomField1"));
            this.schedulerStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("IdSort", "IdSort"));
            this.schedulerStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerStorage1.Resources.Mappings.Caption = "Description";
            this.schedulerStorage1.Resources.Mappings.Color = "Color";
            this.schedulerStorage1.Resources.Mappings.Id = "Id";
            this.schedulerStorage1.Resources.Mappings.Image = "Image";
            this.schedulerStorage1.Resources.Mappings.ParentId = "ParentId";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadRoutes);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileDir);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 561);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(724, 561);
            this.schedulerControl1.Start = new System.DateTime(2011, 10, 26, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleYear1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleQuarter1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleMonth1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleWeek1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleDay1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleHour1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScale15Minutes1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // gantTestDataSet
            // 
            this.gantTestDataSet.DataSetName = "GantTestDataSet";
            this.gantTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.gantTestDataSet;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.gantTestDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // taskDependenciesBindingSource
            // 
            this.taskDependenciesBindingSource.DataMember = "TaskDependencies";
            this.taskDependenciesBindingSource.DataSource = this.gantTestDataSet;
            // 
            // taskDependenciesTableAdapter
            // 
            this.taskDependenciesTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoadRoutes
            // 
            this.btnLoadRoutes.Location = new System.Drawing.Point(27, 41);
            this.btnLoadRoutes.Name = "btnLoadRoutes";
            this.btnLoadRoutes.Size = new System.Drawing.Size(295, 23);
            this.btnLoadRoutes.TabIndex = 21;
            this.btnLoadRoutes.Text = "Load Routes";
            this.btnLoadRoutes.UseVisualStyleBackColor = true;
            this.btnLoadRoutes.Click += new System.EventHandler(this.btnLoadRoutes_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(287, 11);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(35, 21);
            this.btnLoadFile.TabIndex = 20;
            this.btnLoadFile.Text = "...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtFileDir
            // 
            this.txtFileDir.Location = new System.Drawing.Point(104, 12);
            this.txtFileDir.Name = "txtFileDir";
            this.txtFileDir.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtFileDir.Size = new System.Drawing.Size(177, 20);
            this.txtFileDir.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Route File:";
            // 
            // FrmGant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmGant";
            this.Text = "FrmGant";
            this.Load += new System.EventHandler(this.FrmGant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDir.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private GantTestDataSet gantTestDataSet;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private GantTestDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private GantTestDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource taskDependenciesBindingSource;
        private GantTestDataSetTableAdapters.TaskDependenciesTableAdapter taskDependenciesTableAdapter;
        private System.Windows.Forms.Button btnLoadRoutes;
        private System.Windows.Forms.Button btnLoadFile;
        private DevExpress.XtraEditors.TextEdit txtFileDir;
        private System.Windows.Forms.Label label4;
    }
}