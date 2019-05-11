using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo4
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int numero = 0, i;
            string dato = "";
            float suma = 0.0f;
            float minimo = 0.0f;
            float maximo = 0.0f;

            Console.WriteLine("Ingrese cantidad de personas: ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            float[] edades = new float[numero];

            for (i = 0; i < numero; i++)
            {
                Console.WriteLine("Ingrese la lista de edades: ");
                dato = Console.ReadLine();
                edades[i] = Convert.ToSingle(dato);

            }
            for (i = 0; i < numero; i++)
            {
                suma = suma + edades[i];
            }
            for (i = 0; i < numero; i++)
            {
                if (edades[i] < minimo)
                    minimo = edades[i];
            }

            for (i = 0; i < numero; i++)
            {
                if (edades[i] > maximo)
                    maximo = edades[i];
            }
            Console.WriteLine("La edad maxima es {0}", maximo);
            Console.WriteLine("La edad minima es {0}", minimo);

            Console.ReadLine();
        }
    }
}
