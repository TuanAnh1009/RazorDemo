using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_Nhanvien
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Nhanvien Nhanvien { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nhanvien = await _context.Nhanvien.FirstOrDefaultAsync(m => m.NhanvienID == id);

            if (Nhanvien == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nhanvien = await _context.Nhanvien.FindAsync(id);

            if (Nhanvien != null)
            {
                _context.Nhanvien.Remove(Nhanvien);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
