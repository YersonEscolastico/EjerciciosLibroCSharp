using System;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo3
{
    public class Ejercicio4
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Ingrese numero del 1 al 7:");
            dia = Convert.ToInt16(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes");break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo");break;
                default: break;
            }
        }
    }
}
