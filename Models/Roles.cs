using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Employees = new HashSet<Employees>();
        }

        public int Idrole { get; set; }
        public string RoleName { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
