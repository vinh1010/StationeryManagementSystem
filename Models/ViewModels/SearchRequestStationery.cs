using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationeryManagementSystem.Models.ViewModels
{
    public class SearchRequestStationery
    {
        public int Search { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
