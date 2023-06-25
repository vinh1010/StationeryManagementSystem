using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StationeryManagementSystem.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int Idemployee { get; set; }
        [Required(ErrorMessage = "Employee name cannot be null !")]
        public string NameEmployee { get; set; }
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$",ErrorMessage = "Wrong email format !")]
        [Required(ErrorMessage = "Email id cannot be null !")]
        public string EmailId { get; set; }
        [RegularExpression("^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Wrong password format. At least one lower case letter. At least one upper case letter. At least special character. At least one number. At least 8 characters length !")]
        [Required(ErrorMessage = "Password cannot be null !")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Adress cannot be null !")]
        public string Adress { get; set; }
        public int Sex { get; set; }
        [Required(ErrorMessage = "BirthDay cannot be null !")]
        public DateTime BirthDay { get; set; }
        public int RegistrationNumber { get; set; }
        [Required(ErrorMessage = "Please select a department !")]
        public string Iddepartment { get; set; }
        [Required(ErrorMessage = "Please choose a position !")]
        public int? Idrole { get; set; }
        public int? Status { get; set; }
    }
}
