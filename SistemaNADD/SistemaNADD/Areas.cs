using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Areas : Basica, IGenerica{
        public Areas(int area_Id, string area_Nome) : base(area_Id, area_Nome) {
        }
        
        public override string nomeUpperCase(string nome)
        {
            return nome.ToUpper();
        }
        public string Incluir(){
            return "Área Incluida";
        }
        
        public String Consultar() 
        { 
            return "Consulta de Área";
        }
        public String Excluir() 
        { 
            return "Área Excluida";
        }
        public String Alterar() 
        { 
            return "Área Alterada";
        }
        
    }
}