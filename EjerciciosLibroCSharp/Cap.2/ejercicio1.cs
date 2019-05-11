using System;

namespace ejercicio1
{
    public class Ejercicio1
    {
        static void Main(string[] args)
        {

            
            float perimetro;
            float numeros_lados;
            float valor_lados;

            Console.WriteLine("Ingrese los lados del angulo");
            numeros_lados = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de los lados: ");
            valor_lados = Convert.ToSingle(Console.ReadLine());

            perimetro = numeros_lados * valor_lados;

            Console.WriteLine("El perimetro es: {0} ", perimetro);
            Console.Read();
        }
    }
}
