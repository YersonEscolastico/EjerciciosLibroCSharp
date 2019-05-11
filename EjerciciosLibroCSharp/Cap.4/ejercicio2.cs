using System;


namespace Aplicada1_2019.EjerciciosCSharp.Capitulo4
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            double resultado, numero;
            int value;

            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese potencia a elevar: ");
            value = Convert.ToInt16(Console.ReadLine());

            resultado = Math.Pow(numero, value);

            Console.WriteLine("La potencia de " + numero + " elevada a " + value + " potencia es " + resultado);
            Console.ReadLine();

        }
    }
}