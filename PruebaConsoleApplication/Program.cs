using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //como desplegar un mensaje en consola
            Console.WriteLine("el hola mundo de consola, diga algo");

            //como leer un  valor de la consola
            string dijo = Console.ReadLine();

            Console.WriteLine("usted dijo {0}, pero no le entendi", dijo);

            Console.WriteLine("digite la edad");

            string datoDigitado;
            int edad = 0;

            datoDigitado = Console.ReadLine();
            int.TryParse(datoDigitado, out edad);

            //hasta 11 niño
            //12 a 17 Adolecente
            //18 a 40 adulto
            //41 - 70 anciano
            //71 o mas viejecito
            if (edad == 0)
                Console.WriteLine(" edad no valida");
            else if (edad < 12)
                    Console.WriteLine(" nino");
            else if (edad >= 12 && edad <18)
                Console.WriteLine(" teenager");


            //ejemplo de switch
            int variableEvaluar = 1;
            switch (variableEvaluar)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                default:
                    Console.WriteLine("caso por defecto");
                    break;
            }


            

            //ejemplo de un for
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //ejemplo foreach
            int[] arregloConNumeros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in arregloConNumeros)
            {
                count += 1;
                System.Console.WriteLine("Elemento #{0}: {1}", count, element);
            }
            System.Console.WriteLine("La cantidad de numeros en el arreglo es: {0}", count);


            //ejemplo de un while, se evalua al inicio
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine("El Valor de n es {0}", n);
                n++;
            }



            //ejemplo de un do while, se evalua al final
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);


 }

        /// <summary>
        /// Metodo para leer un enter
        /// </summary>
        /// <param name="Mensaje"></param>
        /// <returns></returns>
        int LeerEntero(string Mensaje)
        {
            int edad = 0;
            string datoDigitado;

            Console.WriteLine(Mensaje);

            datoDigitado = Console.ReadLine();

            int.TryParse(datoDigitado, out edad);//intenta convertir el dato digitado a integer

            return edad;
        }

       
    }
}
