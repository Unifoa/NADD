using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Areas {
        public Areas(int id, string nome) {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public void Incluir() { }
        public void consultar() { }
        public void Excluir() { }
        public void Alterar() { }
    }
}