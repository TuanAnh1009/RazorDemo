using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public decimal Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        
    }
}