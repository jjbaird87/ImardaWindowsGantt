using System;
using System.Collections.Generic;
using System.Linq;
using I360_POC.CompanyAPI;
using I360_POC.Login;
using I360_POC.TrackingAPI;

namespace I360_POC.Classes
{
    class I360Api
    {
        private Guid _sessionGuid;
        private Guid _companyId;

        readonly TrackingAPISoapClient _trackingApi = new TrackingAPISoapClient();
        readonly CompanyAPISoapClient _companyApi = new CompanyAPISoapClient();

        public void Login(string userName, string password)
        {
            var connectApi = new ConnectAPISoapClient();
            ResponseOfi360Session session = connectApi.Login(userName, password);
            if (session.Code.ToString() != "Fail")
                _sessionGuid = session.Value.SessionID;
            else
                throw new Exception("Login Failed");
        }

        public List<Vehicle> GetTrackableListById(IEnumerable<string> trackableIDs)
        {
            var trackableList = new ArrayOfString();
            trackableList.AddRange(trackableIDs);
            ResponseOfListOfi360Trackable response = _trackingApi.GetTrackableListByTrackIDList(_sessionGuid,
                trackableList);

            return response.Value.Select(i360Trackable => new Vehicle
            {
                Name = i360Trackable.Name,
                Latitude = (Double) i360Trackable.LastLocation.Latitude,
                Longitude = (Double) i360Trackable.LastLocation.Longitude,
                LocationName = i360Trackable.LastLocation.Description
            }).ToList();
        }

        public List<Vehicle> GetTrackableList()
        {            
            ResponseOfListOfi360Trackable response = _trackingApi.GetTrackableList(_sessionGuid);

            return response.Value.Select(i360Trackable => new Vehicle
            {
                VehicleId = i360Trackable.ID,
                Name = i360Trackable.Name,
                Latitude = (Double)i360Trackable.LastLocation.Latitude,
                Longitude = (Double)i360Trackable.LastLocation.Longitude,
                LocationName = i360Trackable.LastLocation.Description
            }).ToList();
        }

        public string GetCompany()
        {
            ResponseOfListOfi360Company companyList = _companyApi.GetCompanyList(_sessionGuid);
            if (companyList.Value.Count > 0)
            {
                _companyId = companyList.Value[0].CompanyID;
                return companyList.Value[0].Name;
            }
            return "";
        }

        public void GetTripListByDateRange(Guid vehicleId, DateTime startDateTime, DateTime endDateTime)
        {
            ResponseOfListOfi360Trip tripList = _trackingApi.GetTripListByDateRange(_sessionGuid, _companyId, vehicleId, startDateTime, endDateTime);
        }
    }
}
