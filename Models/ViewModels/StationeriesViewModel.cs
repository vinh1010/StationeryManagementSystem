using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StationeryManagementSystem.Models.ViewModels
{
    public class StationeriesViewModel
    {
        public int Idstationerie { get; set; }
        [Required(ErrorMessage = "Stationery name cannot be null !")]
        public string NameStationerie { get; set; }
        [Required(ErrorMessage = "Unit Of Measure cannot be null !")]
        public string UnitOfMeasure { get; set; }
        public string Image { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public double Price { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }
    }
}
