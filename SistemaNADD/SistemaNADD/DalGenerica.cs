using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    interface DalGenerica {

        String Incluir();
        String Consultar();
        String Excluir();
        String Alterar();
    }
}