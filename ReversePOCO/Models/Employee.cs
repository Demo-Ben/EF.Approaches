using System;
using System.Collections.Generic;

#nullable disable

namespace ReversePOCO.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
