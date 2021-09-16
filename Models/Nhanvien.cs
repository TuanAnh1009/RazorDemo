using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Nhanvien
    {
        public int NhanvienID { get; set; }
        public string Hovaten { get; set; }

        [DataType(DataType.Date)]
        public DateTime Namsinh { get; set; }
        public string Gioitinh { get; set; }
    }
}