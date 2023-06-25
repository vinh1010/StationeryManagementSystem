using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Stationeries
    {
        public Stationeries()
        {
            RequestStationery = new HashSet<RequestStationery>();
        }

        public int Idstationerie { get; set; }
        public string NameStationerie { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Idcategory { get; set; }
        public int? Status { get; set; }

        public Categories IdcategoryNavigation { get; set; }
        public ICollection<RequestStationery> RequestStationery { get; set; }
    }
}
