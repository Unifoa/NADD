using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Disciplinas : Basica, DalGenerica{
        public Disciplinas(int dis_Id, string dis_Nome, int dis_Ano, int dis_Periodo, Cursos idCurso) : base(dis_Id, dis_Nome)
        {
            Dis_Ano = dis_Ano;
            Dis_Periodo = dis_Periodo;
            Dis_Id_Curso = idCurso;
        }

        public int Dis_Id { get; set; }
        public string Dis_Nome { get; set; }
        public int Dis_Ano { get; set; }
        public int Dis_Periodo { get; set; }
        public Cursos Dis_Id_Curso { get; set; }

        public override string nomeUpperCase(string nome)
        {
            throw new NotImplementedException();
        }

        public string Incluir()
        {
            return "Disciplina Incluída";
        }

        public string Alterar()
        {
            return "Disciplina Alterada";
        }

        public string Excluir()
        {
            return "Disciplina Excluída";
        }

        public string Consultar()
        {
            return "Consulta de Disciplina";
        }
    }
}