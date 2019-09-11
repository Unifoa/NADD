using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Disciplina
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } = System.DateTime.Now.Millisecond;
        public string Dis_Nome { get; set; }
        public int Dis_Ano { get; set; }
        public int Dis_Periodo { get; set; }

        //Foreign key for Area
        [ForeignKey("Curso"), Column(Order = 0)]
        public int CursosId { get; set; }
        public Curso Cursos { get; set; }


        //Foreign key for Prefessor
        [ForeignKey("Professor"), Column(Order = 0)]
        public int ProfessoresId { get; set; }
        public Professor Professores { get; set; }
        
        public ICollection<Prova> Provas { get; set; }
    }
}