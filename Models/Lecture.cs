using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Lecture
    {
        public int LectureID { get; set; }
        
        public string Tenmonhoc { get; set; }
        public decimal Sotiet { get; set; }
        public string Noidung { get; set; }
        
    }
}