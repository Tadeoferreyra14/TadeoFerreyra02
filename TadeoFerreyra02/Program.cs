using System;

namespace TadeoFerreyra02
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;
            Console.WriteLine("Ingrese lado A");
            ladoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado B");
            ladoB = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese lado C");
            ladoC = int.Parse(Console.ReadLine());

            if (ladoA == ladoB & ladoB==ladoC)
            {
                Console.Write("Es un triangulo equilatero");
            }
            else if (ladoA != ladoB & ladoA != ladoC & ladoC != ladoB)
            {
                Console.Write("es un triangulo escaleno");
            }
            else if (ladoA == ladoC && ladoB!=ladoC &&ladoB!=ladoA || ladoA==ladoB && ladoC!=ladoA && ladoC!=ladoB || ladoC==ladoB && ladoA!=ladoC && ladoA != ladoB)
            {
                Console.Write("Es un triangulo isoseles ");
            }
            Console.ReadLine();
            

        }
    }
}
