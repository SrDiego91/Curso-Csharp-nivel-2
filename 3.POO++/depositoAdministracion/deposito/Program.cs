using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero_del_deposito = 1;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 81; y++)
                {
                    Console.WriteLine("Esta almacenando en el deposito " + Numero_del_deposito);
                    clase_compartimiento compartimiento = new clase_compartimiento();
                    clase_compartimiento[] vector_de_compartimientos = new clase_compartimiento[80];
                    Console.WriteLine("ingrese el contenido del compartimiento");
                    compartimiento.Que_contiene = Console.ReadLine();
                    Console.WriteLine("ingrese el numero de cliente");
                    compartimiento.Numero_de_cliente = int.Parse(Console.ReadLine());
                    vector_de_compartimientos[y] = compartimiento;
                    Console.WriteLine("el la posicion " + (y + 1) + " guardo " + compartimiento.Que_contiene + " con el numero de cliente " + compartimiento.Numero_de_cliente);
                        

                }
                Numero_del_deposito++;

            }







        }
        
    }
}
