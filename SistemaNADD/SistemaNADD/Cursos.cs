using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Cursos {
        public Cursos(int cur_Id, string _cur_Nome, int cur_Num_Periodos, Areas cur_Id_Area) {
            Cur_Id = cur_Id;
            Cur_Nome = _cur_Nome;
            Cur_Num_Periodos = cur_Num_Periodos;
            Cur_Id_Area = cur_Id_Area;
        }

        public int Cur_Id { get; set; }
        public string Cur_Nome { get; set; }
        public int Cur_Num_Periodos { get; set; }
        public Areas Cur_Id_Area { get; set; }

        public void cadastrarCurso() { }
        public void consultarCurso() { }
        public void excluirCurso() { }
        public void listarCurso() { }

    }
}