using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Avaliacoes {

        public Avaliacoes(int ava_Id, int ava_Questao, int ava_Clareza, int ava_Complexibilidade, int ava_Contextualizacao, string ava_Observacao, int ava_Questao_Explicito, double ava_Valor_Questao, int ava_Mult_Escolha, Provas idProva) {
            Ava_Id = ava_Id;
            Ava_Questao = ava_Questao;
            Ava_Clareza = ava_Clareza;
            Ava_Complexibilidade = ava_Complexibilidade;
            Ava_Contextualizacao = ava_Contextualizacao;
            Ava_Observacao = ava_Observacao;
            Ava_Questao_Explicito = ava_Questao_Explicito;
            Ava_Valor_Questao = ava_Valor_Questao;
            Ava_Mult_Escolha = ava_Mult_Escolha;
            IdProva = idProva;
        }

        public int Ava_Id { get; set; }
        public int Ava_Questao { get; set; }
        public int Ava_Clareza { get; set; }
        public int Ava_Complexibilidade { get; set; }
        public int Ava_Contextualizacao { get; set; }
        public string Ava_Observacao { get; set; }
        public int Ava_Questao_Explicito { get; set; }
        public double Ava_Valor_Questao { get; set; }
        public int Ava_Mult_Escolha { get; set; }
        public Provas IdProva { get; set; }

        public void cadastrarAvaliacao() { }
        public void consultarAvaliacao() { }
        public void gerarRelatorio() { }
    }
}
