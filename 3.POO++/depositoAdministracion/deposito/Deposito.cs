using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposito
{
    internal class Deposito
    {
        private string almacenado;
        private string tamaño;
        private int pasillos;
        private int fila_de_estantes;
        private int compartimientos;

        public string Almacenado 
        {
            get { return almacenado; }
            set { almacenado = "solo se puede almacenar en seco"; } 
        }

        public string Tamaño 
        {
            get { return tamaño; }
            set { tamaño = "100.000m3"; }
        }

        public int Pasillos 
        {
            get { return pasillos; }
            set { pasillos = 6;}
        }
        public int Fila_de_estantes 
        {
            get { return fila_de_estantes;}
            set { fila_de_estantes = 5;}
        }
        public int Compartimientos 
        {
            get { return compartimientos;}
            set { compartimientos = 80;}
        }

    }
}
