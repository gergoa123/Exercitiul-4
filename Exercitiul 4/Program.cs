using System;

namespace Exercitiul_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul!");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar > 0 ) 
            {
                Console.WriteLine(" + ");
            }

            if (numar < 0) 
            {
                Console.WriteLine(" - ");
            }

            if (numar == 0) 
            {
                Console.WriteLine(" 0 ");
            }
        }
    }
}
