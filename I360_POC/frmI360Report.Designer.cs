namespace I360_POC
{
    partial class FrmI360Report
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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.mapVehicles = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lblVehicles = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileDir = new DevExpress.XtraEditors.TextEdit();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnLoadRoutes = new System.Windows.Forms.Button();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.taskDependenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gantTestDataSet = new I360_POC.GantTestDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new I360_POC.GantTestDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new I360_POC.GantTestDataSetTableAdapters.ResourcesTableAdapter();
            this.taskDependenciesTableAdapter = new I360_POC.GantTestDataSetTableAdapters.TaskDependenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mapVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(114, 89);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Bidvest Laundry";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(297, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "bidvestpilot999!";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(34, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(37, 202);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(374, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Get Tracked Vehicles";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(34, 144);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 13);
            this.lblCode.TabIndex = 5;
            // 
            // mapVehicles
            // 
            this.mapVehicles.CenterPoint = new DevExpress.XtraMap.GeoPoint(-30D, 25D);
            bingMapDataProvider1.BingKey = "AhNjTy6kPkmhzlUONM7Tuazd1ngz6jFglbyIAcPv5oIovPxSsDzYEwG-tBatY5GJ";
            bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            this.mapVehicles.Layers.Add(imageTilesLayer1);
            this.mapVehicles.Location = new System.Drawing.Point(13, 7);
            this.mapVehicles.Name = "mapVehicles";
            this.mapVehicles.Size = new System.Drawing.Size(728, 465);
            this.mapVehicles.TabIndex = 6;
            this.mapVehicles.ToolTipController = this.toolTipController1;
            this.mapVehicles.ZoomLevel = 5D;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(6, 29);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(79, 13);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.EditValue = new System.DateTime(2014, 10, 16, 16, 30, 8, 0);
            this.dtStartDate.Location = new System.Drawing.Point(114, 141);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtStartDate.Size = new System.Drawing.Size(297, 20);
            this.dtStartDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "End Date:";
            // 
            // dtEndDate
            // 
            this.dtEndDate.EditValue = null;
            this.dtEndDate.Location = new System.Drawing.Point(114, 167);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndDate.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.dtEndDate.Size = new System.Drawing.Size(297, 20);
            this.dtEndDate.TabIndex = 10;
            // 
            // lblVehicles
            // 
            this.lblVehicles.Location = new System.Drawing.Point(6, 48);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(42, 13);
            this.lblVehicles.TabIndex = 12;
            this.lblVehicles.Text = "Vehicles:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.lblVehicles);
            this.groupBox1.Location = new System.Drawing.Point(37, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 74);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Route File:";
            // 
            // txtFileDir
            // 
            this.txtFileDir.Location = new System.Drawing.Point(114, 12);
            this.txtFileDir.Name = "txtFileDir";
            this.txtFileDir.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtFileDir.Size = new System.Drawing.Size(256, 20);
            this.txtFileDir.TabIndex = 15;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(376, 8);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(35, 24);
            this.btnLoadFile.TabIndex = 16;
            this.btnLoadFile.Text = "...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnLoadRoutes
            // 
            this.btnLoadRoutes.Location = new System.Drawing.Point(37, 41);
            this.btnLoadRoutes.Name = "btnLoadRoutes";
            this.btnLoadRoutes.Size = new System.Drawing.Size(374, 23);
            this.btnLoadRoutes.TabIndex = 17;
            this.btnLoadRoutes.Text = "Load Routes";
            this.btnLoadRoutes.UseVisualStyleBackColor = true;
            this.btnLoadRoutes.Click += new System.EventHandler(this.btnLoadRoutes_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(430, 8);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(764, 515);
            this.xtraTabControl1.TabIndex = 18;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.mapVehicles);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(758, 487);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.schedulerControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(758, 487);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Location = new System.Drawing.Point(23, 10);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(732, 463);
            this.schedulerControl1.Start = new System.DateTime(2014, 10, 16, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 2;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.ToolTipController = this.toolTipController1;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
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
            // taskDependenciesBindingSource
            // 
            this.taskDependenciesBindingSource.DataMember = "TaskDependencies";
            this.taskDependenciesBindingSource.DataSource = this.gantTestDataSet;
            // 
            // gantTestDataSet
            // 
            this.gantTestDataSet.DataSetName = "GantTestDataSet";
            this.gantTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.gantTestDataSet;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.gantTestDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // taskDependenciesTableAdapter
            // 
            this.taskDependenciesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmI360Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 535);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnLoadRoutes);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtFileDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "FrmI360Report";
            this.Text = "frmI360Report";
            this.Load += new System.EventHandler(this.FrmI360Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gantTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblCode;
        private DevExpress.XtraMap.MapControl mapVehicles;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.LabelControl lblVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtFileDir;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadRoutes;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private GantTestDataSet gantTestDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private GantTestDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private GantTestDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource taskDependenciesBindingSource;
        private GantTestDataSetTableAdapters.TaskDependenciesTableAdapter taskDependenciesTableAdapter;
    }
}