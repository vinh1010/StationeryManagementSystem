using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public string Iddepartment { get; set; }
        public string NameDepartment { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
