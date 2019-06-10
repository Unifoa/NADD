using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Program {
        
        public static Areas area = new Areas(1, "Exatas");
        public static Cursos curso = new Cursos(1, "S.I", 8, area);
        public static Disciplinas disciplina = new Disciplinas(1, "Programação Orientada a Objetos",1, 2019, curso);
        public static Professores prof = new Professores(1, 2005001, "Debora Amorim");
        public static DisciplinasProfessores discProf = new DisciplinasProfessores(prof, disciplina);
        public static Provas prova = new Provas(1, 5, 1, 8, 1, 1, discProf);
        public static Avaliacoes avaliacao1 = new Avaliacoes(1, 1, 1, 3, 1, "Boa Questão", 1, 2, 0, prova);
        public static Avaliacoes avaliacao2 = new Avaliacoes(1, 2, 1, 2, 1, "Boa Questão", 1, 1, 1, prova);
        public static Avaliacoes avaliacao3 = new Avaliacoes(1, 3, 1, 4, 1, "Boa Questão", 1, 2, 0, prova);
        public static Avaliacoes avaliacao4 = new Avaliacoes(1, 4, 1, 2, 1, "Boa Questão", 1, 1, 1, prova);
        public static Avaliacoes avaliacao5 = new Avaliacoes(1, 5, 1, 5, 1, "Boa Questão", 1, 4, 0, prova);
        
        
        static void Main(string[] args) {

            // Teste
            Console.WriteLine(prof.Nome);
            //prof.Prof_Nome = "Debora";          
            //Console.WriteLine(prof.Prof_Nome);
            Console.WriteLine(area.nomeUpperCase(area.Nome));  
            Console.ReadKey();
        }
    }
}
