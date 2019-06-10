using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Perfil {
        public Perfil(int perfil_Id, string perfil_Nome) {
            Perfil_Id = perfil_Id;
            Perfil_Nome = perfil_Nome;
        }

        public int Perfil_Id { get; set; }
        public string Perfil_Nome { get; set; }
    }
}