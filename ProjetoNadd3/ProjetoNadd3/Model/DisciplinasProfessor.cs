//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjetoNadd3 {
//    public class DisciplinasProfessor {

//        //Foreign key for Disciplina
//        [ForeignKey("Disciplina"), Column(Order = 0)]
//        public int DisciplinasId { get; set; }
//        public Disciplina Disciplinas { get; set; }

//        //Foreign key for Professor
//        [ForeignKey("Professor"), Column(Order = 1)]
//        public int ProfessoresId { get; set; }
//        public Professor Professores { get; set; }

//        public ICollection<Prova> Provas { get; set; }

//    }
//}