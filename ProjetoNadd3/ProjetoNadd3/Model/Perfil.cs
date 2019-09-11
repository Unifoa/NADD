using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNadd3 {
    public class Perfil {

        [Key]
        public int Id { get; set; }
        public string Perfil_Nome { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}