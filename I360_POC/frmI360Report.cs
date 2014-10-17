using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraMap;
using I360_POC.Classes;
using I360_POC.Properties;
using JetBrains.Annotations;

namespace I360_POC
{
    public partial class FrmI360Report : Form
    {
        readonly VectorItemsLayer _itemsLayer = new VectorItemsLayer();
        readonly InformationLayer _infoLayer = new InformationLayer();
        readonly BingRouteDataProvider _routeProvider = new BingRouteDataProvider();
        MapPolyline _polyLine = new MapPolyline();
        readonly I360Api _api = new I360Api();

        public FrmI360Report()
        {
            InitializeComponent();

            schedulerStorage1.Appointments.CommitIdToDataSource = false;
            appointmentsTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;

            mapVehicles.Layers.Add(_itemsLayer);
            mapVehicles.Layers.Add(_infoLayer);
            
            _infoLayer.DataProvider = _routeProvider;
            _routeProvider.BingKey = "AhNjTy6kPkmhzlUONM7Tuazd1ngz6jFglbyIAcPv5oIovPxSsDzYEwG-tBatY5GJ";
            _routeProvider.RouteCalculated += _routeProvider_RouteCalculated;

            var imageCollection = new ImageCollection();
            var image = new Bitmap(Resources.Location_marker_pin_map_gps);
            imageCollection.ImageSize = new Size(40, 40);
            imageCollection.Images.Add(image);
            
            mapVehicles.ImageList = imageCollection;
            _itemsLayer.ItemImageIndex = 0;

            //Initialise DateTime
            dtStartDate.DateTime = DateTime.Now.Date;
            dtEndDate.DateTime = DateTime.Now.Date.AddDays(1).AddTicks(-1);
        }

        void Adapter_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void _routeProvider_RouteCalculated([NotNull] object sender, [NotNull] BingRouteCalculatedEventArgs e)
        {
            RouteCalculationResult result = e.CalculationResult;

            if (result.ResultCode == RequestResultCode.Success)
            {
                _polyLine.Points.AddRange(result.RouteResults[0].RoutePath);

                // Customize the appearance of the calculated route path.  
                _polyLine.Stroke = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
                _polyLine.StrokeWidth = 20;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {                
                _api.Login(txtUserName.Text, txtPassword.Text);

                lblCompanyName.Text = String.Format("Company Name: {0}", _api.GetCompany());
                List<Vehicle> trackables = _api.GetTrackableList();
                lblVehicles.Text = string.Format("Vehicles: {0}", trackables.Count);

                //Get Trips
                GetTrips(trackables);

                var adapter = new ListSourceDataAdapter {DataSource = trackables};
                _itemsLayer.Data = adapter;

                adapter.Mappings.Latitude = "Latitude";
                adapter.Mappings.Longitude = "Longitude";
                adapter.AttributeMappings.Add(new MapItemAttributeMapping {Member = "Name", Name = "Name"});
                adapter.AttributeMappings.Add(new MapItemAttributeMapping { Member = "LocationName", Name = "LocationName" });

                //Customize tooltips
                mapVehicles.ToolTipController = new ToolTipController {AllowHtmlText = true};
                _itemsLayer.ToolTipPattern = "<b>Vehicle {Name} </b> Location: {LocationName}";

                if (trackables.Count > 0)
                {
                    mapVehicles.CenterPoint = new GeoPoint(trackables[0].Latitude, trackables[0].Longitude);
                    mapVehicles.ZoomLevel = 10;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }

        private void GetTrips(IEnumerable<Vehicle> vehicleList)
        {
            foreach (Vehicle vehicle in vehicleList)
            {
                _api.GetTripListByDateRange(vehicle.VehicleId, dtStartDate.DateTime, dtEndDate.DateTime);
            }
            
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog {Filter = @".csv files (*.csv)|*.csv|All files (*.*)|*.*"};
            if (openFile.ShowDialog() == DialogResult.OK)
                txtFileDir.Text = openFile.FileName;
        }

        private void btnLoadRoutes_Click([NotNull] object sender, [NotNull] EventArgs e)
        {
            try
            {
                if (txtFileDir.Text != "")
                {
                    var reader = new CsvReader(txtFileDir.Text);
                    DataTable routeTable = reader.ReadIntoDataTable();

                    var waypoints = new List<RouteWaypoint>();
                    foreach (DataRow row in routeTable.Rows)
                    {
                        string latitude = row["LATITUDE"].ToString();
                        string longitude = row["LONGITUDE"].ToString();
                        var point = new GeoPoint(Convert.ToDouble(latitude), Convert.ToDouble(longitude));
                        waypoints.Add(new RouteWaypoint(string.Format("Vehicle: {0}\nTime:{1}", row["VEHICLE_NAME"], row["ARR_TIME"]), point));
                    }

                    _routeProvider.CalculateRoute(waypoints);                                                           
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

        private void FrmI360Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gantTestDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            this.taskDependenciesTableAdapter.Fill(this.gantTestDataSet.TaskDependencies);
            // TODO: This line of code loads data into the 'gantTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.gantTestDataSet.Resources);
            // TODO: This line of code loads data into the 'gantTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.gantTestDataSet.Appointments);

        }
    }
}
