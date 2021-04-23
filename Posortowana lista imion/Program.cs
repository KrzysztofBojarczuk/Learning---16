using System;

namespace Posortowana_lista_imion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            string[] names = new string[SIZE];

            for (int i = 0; i <= SIZE-1; i++)
            {
                Console.WriteLine("Wprowadź imiona:");
                names[i] = Console.ReadLine();
            }
            Array.Sort(names);
            for (int i = 0; i <= SIZE-1; i++)
            {
                Console.WriteLine(names[i]);
            }


        }
    }
}
