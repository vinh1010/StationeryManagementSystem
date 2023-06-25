using System;
using System.Collections.Generic;

namespace StationeryManagementSystem.Models
{
    public partial class Feedbacks
    {
        public int Idfeedback { get; set; }
        public int? Idemployee { get; set; }
        public string Content { get; set; }
        public DateTime DateCreate { get; set; }
        public int? Status { get; set; }

        public Employees IdemployeeNavigation { get; set; }
    }
}
