using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeSignIn.Models
{
    public partial class EmpDetails
    {
        public int Id { get; set; }
        public string EmpFirstname { get; set; }
        public string EmpLastname { get; set; }
        public byte[] Photo { get; set; }
    }
}
