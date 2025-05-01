using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarlosM_ExamenP1.Data;
using CarlosM_ExamenP1.Models;

namespace CarlosM_ExamenP1.Views.Propietario
{
    public class DeleteModel : PageModel
    {
        private readonly CarlosM_ExamenP1.Data.ApplicationDbContext _context;

        public DeleteModel(CarlosM_ExamenP1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Propietario Propietario { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietarios.FirstOrDefaultAsync(m => m.Id == id);

            if (propietario == null)
            {
                return NotFound();
            }
            else
            {
                Propietario = propietario;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietarios.FindAsync(id);
            if (propietario != null)
            {
                Propietario = propietario;
                _context.Propietarios.Remove(Propietario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
