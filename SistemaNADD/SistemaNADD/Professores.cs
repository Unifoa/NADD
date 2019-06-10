using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Professores {
        public Professores(int prof_Id, int prof_Matricula, string prof_Nome) {
            Prof_Id = prof_Id;
            Prof_Matricula = prof_Matricula;
            Prof_Nome = prof_Nome;
        }

        public int Prof_Id { get; set; }
        public string Prof_Nome { get; set; }
        public int Prof_Matricula { get; set; }

    public void cadastrarProfessor() { }
    public void consultarProfessor() { }
    public void excluirProfessor() { }
    public void listarProfessor() { }
    }
}