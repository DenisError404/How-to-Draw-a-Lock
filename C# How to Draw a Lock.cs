using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",
                 new string('_', n),
                 new string('^', n));

            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('_', n - 2),
                new string('^', 3),
                new string('_', n - 2));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string('_', ((n - 4) - 2 * i)),
                    new string('^', 2),
                    new string('_', 2 + 2 * i),
                    new string('^', 1),
                    new string('_', n - 2));
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string('_', (1 + (2 * i))),
                    new string('^', 2),
                    new string('_', (n - 3) - 2 * i),
                    new string('^', 1),
                    new string('_', n - 2));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('_', n - 2),
                    new string('^', 3),
                    new string('_', n - 2));

            Console.WriteLine("{0}{1}{0}",
                     new string('_', n),
                     new string('^', n));
            Console.ReadKey();
        }
        
    }
}
