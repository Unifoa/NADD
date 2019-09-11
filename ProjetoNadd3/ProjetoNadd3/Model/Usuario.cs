using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Usuario {

        [Key]
        public int Id { get; set; } = System.DateTime.Now.Millisecond;
        public string Usu_Nome { get; set; }
        [DataType(DataType.Password)]
        public string Usu_Senha { get; set; }

        //Foreign key for Perfil
        [ForeignKey("Perfil"), Column(Order = 0)]
        public int PerfisId { get; set; }
        public Perfil Perfis { get; set; }

    }
}