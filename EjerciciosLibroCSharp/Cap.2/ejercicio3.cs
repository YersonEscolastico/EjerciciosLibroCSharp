using System;

namespace ejercicio1
{
    public class Ejercicio1
    {
        static void Main(string[] args)
        {

            double grados;
            double radianes;
            string dato;


            Console.WriteLine("Ingrese grados:");
            dato = Console.ReadLine();
            grados = Convert.ToDouble(dato);

            radianes = grados * (180 / Math.PI);
            Console.WriteLine("{0} Grados = {1} Radianes", grados, radianes);
            Console.Read();
        }
    }
}
