using System;

namespace ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            string dato;

            Console.WriteLine("ingrese grados celsius: ");
            dato = Console.ReadLine();
            celsius = Convert.ToDouble(dato);

            fahrenheit = (9 / 5 * celsius) + 32;

            Console.WriteLine("{0} celcius = {1} fahrenheit", celsius, fahrenheit);
            Console.Read();
        }
    }
}
