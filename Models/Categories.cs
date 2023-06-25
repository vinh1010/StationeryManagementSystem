using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Stationeries = new HashSet<Stationeries>();
        }

        public int Idcategory { get; set; }
        public string NameCategory { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }

        public ICollection<Stationeries> Stationeries { get; set; }
    }
}
