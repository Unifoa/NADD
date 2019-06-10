using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Professores : Funcionarios, DalGenerica {
        public Professores(int prof_Id, int prof_Matricula, string prof_Nome) : base (prof_Id, prof_Matricula, prof_Nome) {
        }

        public int Prof_Id { get; set; }
        public string Prof_Nome { get; set; }
        public int Prof_Matricula { get; set; }
        
        protected override string nomeUpperCase(string nome)
        {
            return nome.ToUpper();
        }
        public String checkMatricula(String Matricula)
        {
            try
            {
                if (Matricula.Length == 9)
                {
                    var mat = int.Parse(Matricula);
                    return Matricula;
                }else
                {
                    return "A matricula deve conter 9 digitos.";
                }
            }
            catch
            {
                return "Matricula deve conter somente números.";
            }
        }
        public String checkMatricula(int Matricula)
        {
            if (Matricula >= 100000000 && Matricula <= 999999999)
            {
                return ""+Matricula;
            }
            else
            {
                return "A matricula deve conter 9 digitos.";
            }
        }

        public string Incluir()
        {
            return "Professor Cadastrado";
        }

        public string Consultar()
        {
            return "Consulta de Professores";
        }

        public string Excluir()
        {
            return "Professor Excluido";
        }

        public string Alterar()
        {
            return "Professor Alterado";
        }
    }
}