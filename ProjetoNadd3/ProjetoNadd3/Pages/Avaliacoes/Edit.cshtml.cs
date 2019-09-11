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

namespace ProjetoNadd3.Pages.Avaliacoes
{
    public class EditModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public EditModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Avaliacao Avaliacao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Avaliacao = await _context.Avaliacao
                .Include(a => a.Provas).FirstOrDefaultAsync(m => m.Id == id);

            if (Avaliacao == null)
            {
                return NotFound();
            }
           ViewData["ProvasId"] = new SelectList(_context.Prova, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Avaliacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaliacaoExists(Avaliacao.Id))
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

        private bool AvaliacaoExists(int id)
        {
            return _context.Avaliacao.Any(e => e.Id == id);
        }
    }
}
