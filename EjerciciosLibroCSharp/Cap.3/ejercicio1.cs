using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo3
{
    public class Ejercicio1
    {
        static void Main(String[] args)
        {
            int dato;
            Console.WriteLine("Ingrese numero");
            dato = Convert.ToInt16(Console.ReadLine());

            if ((dato % 2) == 0)
                Console.WriteLine("Su numero es par");
            else
                Console.WriteLine("Su numero es impar");
            Console.Read();
        }
    }
}
