using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoNadd3;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Pages.Disciplinas
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public DeleteModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Disciplina Disciplina { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Disciplina = await _context.Disciplina
                .Include(d => d.Cursos)
                .Include(d => d.Professores).FirstOrDefaultAsync(m => m.Id == id);

            if (Disciplina == null)
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

            Disciplina = await _context.Disciplina.FindAsync(id);

            if (Disciplina != null)
            {
                _context.Disciplina.Remove(Disciplina);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
