using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Provas {
        public Provas(int prova_Id, int prova_Qnt_Questao, int prova_Valor_Explicito, double prova_Valor_Prova, int prova_Equilibrio_Questao, int prova_Ref_Bibliografica, DisciplinasProfessores dep_Id) {
            Prova_Id = prova_Id;
            Prova_Qnt_Questao = prova_Qnt_Questao;
            Prova_Valor_Explicito = prova_Valor_Explicito;
            Prova_Valor_Prova = prova_Valor_Prova;
            Prova_Equilibrio_Questao = prova_Equilibrio_Questao;
            Prova_Ref_Bibliografica = prova_Ref_Bibliografica;
            Dep_Id = dep_Id;
        }

        public int Prova_Id { get; set; }
        public int Prova_Qnt_Questao { get; set; }
        public int Prova_Valor_Explicito { get; set; }
        public double Prova_Valor_Prova { get; set; }
        public int Prova_Equilibrio_Questao { get; set; }
        public int Prova_Ref_Bibliografica { get; set; }
        public DisciplinasProfessores Dep_Id { get; set; }

        public void cadastrarProva() { }
        public void consultarProva() { }
        public void excluirProva() { }
        public void listarProva() { }
    }
}
