using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo3
{
    class Ejercicio5
    {
        public static void Main(string[] args)
        {
            float resultado = 0.0f;
            string dato;
            float lado;
            int opcion = 0;
            int cantidad_lado;
            float apotema;

            Console.WriteLine("Que desea hacer con el poligono regular");
            Console.WriteLine("1- calcular perimetro");
            Console.WriteLine("2- calcular area");

            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            Console.Write("Ingrese lado de poligono:");
            dato = Console.ReadLine();
            lado = Convert.ToSingle(dato);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese cantidad de lados del poligono:");
                    cantidad_lado = int.Parse(Console.ReadLine());

                    resultado = lado * cantidad_lado;
                    break;

                case 2:
                    Console.WriteLine("Ingrese el apotema del poligono:");
                    apotema = float.Parse(Console.ReadLine());

                    resultado = (lado * apotema) / 2;
                    break;

                default: break;
            }
            Console.Write("Su resultado es:" + resultado);

            Console.ReadKey();
        }
    }
}
