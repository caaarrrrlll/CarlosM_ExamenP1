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
    public class IndexModel : PageModel
    {
        private readonly CarlosM_ExamenP1.Data.ApplicationDbContext _context;

        public IndexModel(CarlosM_ExamenP1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Propietario> Propietario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Propietario = await _context.Propietarios.ToListAsync();
        }
    }
}
