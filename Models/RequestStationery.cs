using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class RequestStationery
    {
        public int IdrequestStationery { get; set; }
        public int? Idemployee { get; set; }
        public int? Idstationerie { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }

        public Employees IdemployeeNavigation { get; set; }
        public Stationeries IdstationerieNavigation { get; set; }
    }
}
