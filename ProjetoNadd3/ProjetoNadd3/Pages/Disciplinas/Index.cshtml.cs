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
    public class IndexModel : PageModel
    {
        private readonly ProjetoNadd3.Models.ProjetoNadd3Context _context;

        public IndexModel(ProjetoNadd3.Models.ProjetoNadd3Context context)
        {
            _context = context;
        }

        public IList<Disciplina> Disciplina { get;set; }

        public async Task OnGetAsync()
        {
            Disciplina = await _context.Disciplina
                .Include(d => d.Cursos)
                .Include(d => d.Professores).ToListAsync();
        }
    }
}
