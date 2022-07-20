using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
