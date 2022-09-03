using System;

namespace EjerciciosDeAlmacenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            byte i, numNotas;
            double sumaNotas = 0, promedio;

            //Pedimos al profesor el numero de Notas
            Console.Write("Ingrese el número de notas: ");
            numNotas = Convert.ToByte(Console.ReadLine());

            //Creamos el array/arreglo/matriz unidimensional
            double[] notas = new double[numNotas];

            //Llenar el array con las notas
            for (i = 0; i < numNotas; i++)
            {
                //Pedimos que ingrese la nota
                Console.WriteLine("Ingrese la nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Calcular promedio

            //Calcular nota minima

            //Calcular nota maxima

            //Mostrar notas
            for (i = 0; i < numNotas; i++)
            {
                //Pedimos que ingrese la nota
                Console.WriteLine("La nota {0} es : {1}", i+1, notas[i]);

            }
        }
    }
}