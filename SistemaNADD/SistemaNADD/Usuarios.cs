using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Usuarios {
        public Usuarios(int usu_Id, string usu_Nome, string usu_Senha, Perfil idPerfil) {
            Usu_Id = usu_Id;
            Usu_Nome = usu_Nome;
            Usu_Senha = usu_Senha;
            Perfil = idPerfil;
        }

        public int Usu_Id { get; set; }
        public string Usu_Nome { get; set; }
        public string Usu_Senha { get; set; }
        public Perfil Perfil { get; set; }

        public void cadastrarUsuario() { }
        public void excluirUsuario() { }
        public void consultarUsuario() { }
        public void listarUsuario() { }
        public void verificarLogin() { }
    }
}