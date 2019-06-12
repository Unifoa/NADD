using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Usuarios : Basica, IGenerica{
        public Usuarios(int usu_Id, string usu_Nome, string usu_Senha, Perfil idPerfil) : base(usu_Id, usu_Nome) {
            Usu_Senha = usu_Senha;
            Perfil = idPerfil;
        }

        public int Usu_Id { get; set; }
        public string Usu_Nome { get; set; }
        public string Usu_Senha { get; set; }
        public Perfil Perfil { get; set; }
        
        public void listarUsuario() { }
        public void verificarLogin() { }

        public string Incluir()
        {
            return "Cadastro de Usuário";
        }

        public string Consultar()
        {
            return "Consulta de Usuários";
        }

        public string Excluir()
        {
            return "Usuário Excluído";
        }

        public string Alterar()
        {
            return "Usuário Alterado";
        }

        public override string nomeUpperCase(string nome)
        {
            return nome.ToUpper();
        }
    }
}