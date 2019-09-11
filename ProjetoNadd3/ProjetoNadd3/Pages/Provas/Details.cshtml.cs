using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoNadd3;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Pages.Provas
{
    public class DetailsModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public DetailsModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        public Prova Prova { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Prova = await _context.Prova
                .Include(p => p.Disciplinas).FirstOrDefaultAsync(m => m.Id == id);

            if (Prova == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
