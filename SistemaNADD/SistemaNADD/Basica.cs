using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    abstract class Basica {
        public Basica(int id, string nome) {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }

        public abstract string nomeUpperCase(string nome);
    }
}