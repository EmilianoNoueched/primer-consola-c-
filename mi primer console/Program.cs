using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_primer_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string ValorUsuario;
            Console.WriteLine("Ingrese su numbre: ");
            ValorUsuario = Console.ReadLine();
            string respuesta = "Hola, " + ValorUsuario;
            Console.WriteLine(respuesta);

          
            Console.WriteLine("Ingrese valor 1: ");
            string strNum1 = Console.ReadLine();
            int num1 = int.Parse(strNum1); //convierto el valor del string strnum1 a un numero


            Console.WriteLine("Ingrese valor 2: ");
            string strNum2 = Console.ReadLine();
            int num2 = int.Parse(strNum2);
           
            int resultado = num1 + num2;
            Console.WriteLine(resultado);

            if (resultado < 0)
            {
                Console.WriteLine("El resultado es negativo");
            }
            else
            {
                Console.WriteLine("El resultado es positivo");
            }

            
            
        }
    }
}
