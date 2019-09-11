using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoNadd3;
using ProjetoNadd3.Models;

namespace ProjetoNadd3.Pages.Professores
{
    public class DeleteModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public DeleteModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Professor Professor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professor = await _context.Professor.FirstOrDefaultAsync(m => m.Id == id);

            if (Professor == null)
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

            Professor = await _context.Professor.FindAsync(id);

            if (Professor != null)
            {
                _context.Professor.Remove(Professor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
