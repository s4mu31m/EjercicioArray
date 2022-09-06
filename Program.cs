using System;

namespace EjerciciosDeAlmacenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            byte i, numNotas;
            double sumaNotas = 0, promedio,min = 0,max = 0;

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
            foreach (double nota in notas )
            {
                sumaNotas += nota;
            }

            promedio = sumaNotas/ notas.Length;

            Console.WriteLine("El promedio es: "+promedio);


            //Calcular nota maxima
            foreach (double nota in notas)
            {
                if (max < nota)
                {
                    max = nota;
                }
            }

            Console.WriteLine("la nota mas alta es: " + max);

            min = max;

            //Calcular nota minima

            foreach (double nota in notas)
            {
                if (min > nota)
                {
                    min = nota;
                }
            }

            Console.WriteLine("la nota mas baja es: "+min);





            //Mostrar notas
            for (i = 0; i < numNotas; i++)
            {
                //Pedimos que ingrese la nota
                Console.WriteLine("La nota {0} es : {1}", i + 1, notas[i]);

            }
        }
    }
}
