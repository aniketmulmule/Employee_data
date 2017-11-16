using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee First Name is required")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Employee Last Name is required")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Employee DOB is required")]
        public string DOB { get; set; }
    }
}