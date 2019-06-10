using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Perfil : Basica {
        public Perfil(int perfil_Id, string perfil_Nome) : base (perfil_Id, perfil_Nome) {
        }

        public int Perfil_Id { get; set; }
        public string Perfil_Nome { get; set; }

        public override string nomeUpperCase(string nome)
        {
            return nome.ToUpper();
        }
    }
}