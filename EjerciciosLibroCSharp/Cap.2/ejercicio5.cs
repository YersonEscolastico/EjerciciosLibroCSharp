using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo2
{
    public class Ejercicio5
    {
        static void Main(string[] args)
        {
            double dolares;
            double euros = 0.89;
            string dato;

            Console.WriteLine("Ingrese monto en dolares:");
            dato = Console.ReadLine();
            dolares = Convert.ToDouble(dato);
            double convertir = dolares * euros;

            Console.WriteLine("{0} Dolares = {1} Euros", dolares, convertir);

        }
    }
}
