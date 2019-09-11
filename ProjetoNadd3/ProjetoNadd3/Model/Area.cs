using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3
{
    public class Area
    {
        [Key]
        public int Id { get; set; }
        public string Area_Nome { get; set; }

        public ICollection<Curso> Cursos { get; set; }

    }
}