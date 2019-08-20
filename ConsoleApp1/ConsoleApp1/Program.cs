using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los números");
            Console.WriteLine("De donde arrancamos el ciclo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Como ira avanzando?");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i <= y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else if (x < y)
            {
                for (int i = x; i >= y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                Console.WriteLine("i = " + x);
            }
        }
    }
}
