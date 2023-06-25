using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Feedbacks = new HashSet<Feedbacks>();
            RequestStationery = new HashSet<RequestStationery>();
        }

        public int Idemployee { get; set; }
        public string NameEmployee { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public int Sex { get; set; }
        public DateTime BirthDay { get; set; }
        public int RegistrationNumber { get; set; }
        public string Iddepartment { get; set; }
        public int? Idrole { get; set; }
        public int? Status { get; set; }

        public Departments IddepartmentNavigation { get; set; }
        public Roles IdroleNavigation { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }
        public ICollection<RequestStationery> RequestStationery { get; set; }
    }
}
