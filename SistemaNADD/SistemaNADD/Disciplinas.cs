using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Disciplinas {
        public Disciplinas(int dis_Id, string dis_Nome, int dis_Ano, int dis_Periodo, Cursos idCurso) {
            Dis_Id = dis_Id;
            Dis_Nome = dis_Nome;
            Dis_Ano = dis_Ano;
            Dis_Periodo = dis_Periodo;
            Dis_Id_Curso = idCurso;
        }

        public int Dis_Id { get; set; }
        public string Dis_Nome { get; set; }
        public int Dis_Ano { get; set; }
        public int Dis_Periodo { get; set; }
        public Cursos Dis_Id_Curso { get; set; }

        public void cadastrarDisciplina() { }
        public void consultarDisciplina() { }
        public void excluirDisciplina() { }
        public void listarDisciplina() { }
    }
}