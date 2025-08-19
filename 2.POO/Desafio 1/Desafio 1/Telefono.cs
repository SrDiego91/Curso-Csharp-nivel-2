using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private string numerotelefonico;
        private int codigooperador;

        public string Modelo 
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico 
        {
            get { return numerotelefonico; }
            set { numerotelefonico = value; }
        }
        public int CodigoOperador 
        {
            get { return codigooperador; }
            set 
            {
                if (value >= 1 && value < 4)
                {
                    codigooperador = value;   
                }
                else
                {
                    codigooperador = 0;
                }
            }
        }
        public Telefono() 
        {
            this.modelo = "Vintage";
            this.marca = "Samsung";
        }
        public string Llamar() 
        {
            return "Realizando llamada...";
        }
        public string LLamar(string contacto) 
        {
           
            return "Llamando a " + contacto;
        }

    }
}
