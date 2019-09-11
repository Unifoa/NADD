using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Curso {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } = System.DateTime.Now.Millisecond;
        public string Cur_Nome { get; set; }
        public int Cur_Num_Periodos { get; set; }
        public int Cur_Ano_Sem { get; set; }

        //Foreign key for Area
        [ForeignKey("Area"), Column(Order = 0)]
        public int AreasId { get; set; }
        public Area Areas { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }

    }
}