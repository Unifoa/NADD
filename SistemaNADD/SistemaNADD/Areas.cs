using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNADD {
    class Areas {
        public Areas(int area_Id, string area_Nome) {
            Area_Id = area_Id;
            Area_Nome = area_Nome;
        }

        public int Area_Id { get; set; }
        public string Area_Nome { get; set; }

        public void cadastrarArea() { }
        public void consultarArea() { }
    }
}