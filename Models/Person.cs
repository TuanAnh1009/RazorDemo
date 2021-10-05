using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Hovaten { get; set; }
        public string Gioitinh { get; set; }
        public decimal Tuoi { get; set; }
    }
}