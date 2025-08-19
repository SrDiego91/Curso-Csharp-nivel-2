using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un proyecto de consola **.Net Framework * *.
            //2.Crear la clase **Telefono * *(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
            //3. Agregale los siguientes atributos:
                //1. Modelo string.
                // 2. Marca string.
                //3. NumeroTelefonico string.
                //4. CodigoOperador int (1, 2 o 3).
            //4. Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
                //1. Modelo: solo lectura. Es decir, solo get.
                //2. Marca: solo lectura.
                //3. NumeroTelefonico: lectura y escritura.
                //4. CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
            //5. Agregar Constructor que reciba Modelo y Marca.
            //6. Crear algunos objetos en el** main** de Program y probar escribirle datos y mostrar en pantalla el estado del** Telefono**.
            //7. Agregar método **Llamar()** sin parámetros que devuelva un string con la leyenda *"Realizando llamada..."*.
            //8. Sobrecargar el método** Llamar(string contacto)** para que reciba un contacto y devuelva un string con la leyenda *"Llamando a " + contacto*.
            //9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            Telefono telefono = new Telefono();
            Console.Write("Ingrese el numero: ");
            telefono.NumeroTelefonico = Console.ReadLine();
            Console.Write("Ingrese el codigo de operador: ");
            telefono.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine(telefono.Llamar());
            Console.WriteLine(telefono.LLamar("Pepita"));
            Console.WriteLine("Con el codigo de operador: " + telefono.CodigoOperador);


        }
    }
}
