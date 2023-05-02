using System;
using System.Collections.Generic;

#nullable disable

namespace RollOff.Models
{
    public partial class Employee
    {
        public double? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
