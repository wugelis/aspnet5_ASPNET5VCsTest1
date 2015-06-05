using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNET5VCsTest1.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string EmpName { get; set; }
    }
}