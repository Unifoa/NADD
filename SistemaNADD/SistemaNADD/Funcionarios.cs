using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    abstract class Funcionarios {
        public Funcionarios(int id, int matricula, string nome)
        {
            Id = id;
            Matricula = matricula;
            Nome = nome;
        }

        public int Id { get; private set; }
        public int Matricula { get; private set; }
        public string Nome { get; private set; }

        protected abstract string nomeUpperCase(string nome);
    }
}