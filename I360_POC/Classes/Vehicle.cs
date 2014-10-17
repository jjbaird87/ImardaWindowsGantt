using System;
using JetBrains.Annotations;

namespace I360_POC.Classes
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public string LocationName { get; set; }

        public DateTime FirstStart { get; set; }

        public DateTime LastFinish { get; set; }
    }
}
