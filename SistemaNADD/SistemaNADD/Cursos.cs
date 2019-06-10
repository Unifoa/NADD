using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Cursos : Basica, DalGenerica {
        public Cursos(int cur_Id, string cur_Nome, int cur_Num_Periodos, Areas cur_Id_Area) : base (cur_Id, cur_Nome)
        {
            Cur_Num_Periodos = cur_Num_Periodos;
            Cur_Id_Area = cur_Id_Area;
        }

        public int Cur_Id { get; set; }
        public string Cur_Nome { get; set; }
        public int Cur_Num_Periodos { get; set; }
        public Areas Cur_Id_Area { get; set; }
        
        public string Incluir()
        {
            return "Curso Cadastrado";
        }

        public string Consultar()
        {
            return "Consulta de Cursos";
        }

        public string Excluir()
        {
            return "Cusrso Excluido";
        }

        public string Alterar()
        {
            return "Curso Alterado";
        }

        public override string nomeUpperCase(string nome)
        {
            return ("Curso: "+nome).ToUpper();
        }
    }
}