using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeSignIn.Models
{
    public partial class EmployeeDetails
    {
        public string Id { get; set; }
        
        [Required(ErrorMessage ="Please enter First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter First name")]
        public string LastName { get; set; }
        public string Photo { get; set; }
    }
}
