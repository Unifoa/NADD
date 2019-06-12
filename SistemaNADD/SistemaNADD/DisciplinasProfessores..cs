using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class DisciplinasProfessores : IGenerica {
        public DisciplinasProfessores(Professores dep_Professor, Disciplinas dep_Disciplina) {
            Dep_Professor = dep_Professor;
            Dep_Disciplina = dep_Disciplina;
        }

        public Professores Dep_Professor { get; set; }
        public Disciplinas Dep_Disciplina { get; set; }

        public string Incluir()
        {
            return "Professro incluido na Disciplina";
        }

        public string Consultar()
        {
            return "Disciplinas Consultadas";
        }

        public string Excluir()
        {
            return "Professor não esta mais na disciplina";
        }

        public string Alterar()
        {
            return "Disciplina Alterada";
        }
    }
}