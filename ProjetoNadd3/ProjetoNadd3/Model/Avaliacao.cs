using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Avaliacao {

        [Key]
        public int Id { get; set; }
        public int Ava_Questao { get; set; }
        public double Ava_Clareza { get; set; }
        public double Ava_Complexibilidade { get; set; }
        public double Ava_Contextualizacao { get; set; }
        public string Ava_Observacao { get; set; }
        public int Ava_Questao_Explicito { get; set; }
        [Range(1, 100)]
        public int Ava_Valor_Questao { get; set; }
        public int Ava_Mult_Escolha { get; set; }

        //Foreign key for Prova
        [ForeignKey("Prova"), Column(Order = 0)]
        public int ProvasId { get; set; }
        public Prova Provas { get; set; }
        //public ICollection<Prova> Provas { get; set; }

    }
}
