using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Hovaten { get; set; }

        [DataType(DataType.Date)]
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
    }
}