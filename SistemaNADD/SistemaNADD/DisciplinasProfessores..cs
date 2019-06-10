using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class DisciplinasProfessores {
        public DisciplinasProfessores(Professores dep_Professor, Disciplinas dep_Disciplina) {
            Dep_Professor = dep_Professor;
            Dep_Disciplina = dep_Disciplina;
        }

        public Professores Dep_Professor { get; set; }
        public Disciplinas Dep_Disciplina { get; set; }

    public void cadastrarDisciplinasProfessores() { }
    public void consultarDisciplinasProfessores() { }
    public void excluirDisciplinasProfessores() { }
    public void listarDisciplinasProfessores() { }
    }
}