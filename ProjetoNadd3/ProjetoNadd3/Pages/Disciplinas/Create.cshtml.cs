using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoNadd3;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Pages.Disciplinas
{
    public class CreateModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public CreateModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CursosId"] = new SelectList(_context.Curso, "Id", "Cur_Nome");
        ViewData["ProfessoresId"] = new SelectList(_context.Professor, "Id", "Prof_Nome");
            return Page();
        }

        [BindProperty]
        public Disciplina Disciplina { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Disciplina.Add(Disciplina);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}