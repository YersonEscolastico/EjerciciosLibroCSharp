using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo4
{
    public class Ejercicio1
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;
            Console.WriteLine("Ingrese un numero del 1 al 10");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + "*" + i + "=" + resultado);
            }
            Console.Read();
        }
    }
}
