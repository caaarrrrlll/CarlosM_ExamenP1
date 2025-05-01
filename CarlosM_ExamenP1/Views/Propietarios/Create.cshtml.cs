using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarlosM_ExamenP1.Data;
using CarlosM_ExamenP1.Models;

namespace CarlosM_ExamenP1.Views.Propietarios
{
    public class CreateModel : PageModel
    {
        private readonly CarlosM_ExamenP1.Data.ApplicationDbContext _context;

        public CreateModel(CarlosM_ExamenP1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Propietario Propietario { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Propietarios.Add(Propietario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
