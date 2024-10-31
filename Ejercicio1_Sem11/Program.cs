//N00458733
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número entero de orden {i+1} en el arreglo: ");
                while(!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Recuerda que el número debe ser entero.");
                    Console.Write($"Ingrese el número entero de orden {i + 1} en el arreglo: ");
                }
                
            }
            Console.Write("Los números ingresados son: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.ReadKey();
        }
    }
}
