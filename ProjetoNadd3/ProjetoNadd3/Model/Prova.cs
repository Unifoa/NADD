using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Prova {
        [Key]
        public int Id { get; set; }
        public int Prova_Avd { get; set; }
        public int Prova_Qnt_Questao { get; set; }
        public int Prova_Valor_Explicito { get; set; }
        public double Prova_Valor_Prova { get; set; }
        public int Prova_Equilibrio_Questao { get; set; }
        public int Prova_Ref_Bibliografica { get; set; }

        
        //Foreign key for Disciplinas
        [ForeignKey("Disciplina")]
        public int DisciplinasId { get; set; }
        public Disciplina Disciplinas { get; set; }
        //public DisciplinasProfessor DisciplinasProfessores { get; set; }


        public ICollection<Avaliacao> Avaliacoes { get; set; }

    }
}
