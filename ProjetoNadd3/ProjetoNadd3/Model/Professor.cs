using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Professor {
        [Key]
        public int Id { get; set; }
        public string Prof_Nome { get; set; }
        public int Prof_Matricula { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }

        //public ICollection<DisciplinasProfessor> DisciplinasProfessores { get; set; }
    }
}