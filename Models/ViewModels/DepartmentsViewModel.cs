using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StationeryManagementSystem.Models.ViewModels
{
    public class DepartmentsViewModel
    {
        [Required(ErrorMessage = "Id department cannot be null !")]
        public string Iddepartment { get; set; }
        [Required(ErrorMessage = "Name department cannot be null !")]
        public string NameDepartment { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }
    }
}
