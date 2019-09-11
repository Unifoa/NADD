using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoNadd3;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Pages.Provas
{
    public class EditModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public EditModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["DisciplinasId"] = new SelectList(_context.Disciplina, "Id", "Dis_Nome");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Prova).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvaExists(Prova.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProvaExists(int id)
        {
            return _context.Prova.Any(e => e.Id == id);
        }
    }
}
