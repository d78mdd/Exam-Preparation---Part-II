using System;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middleHeight = 2 * n;

            int width = 4 * n + 1;

            // top
            Console.Write(new string('.', (width - 3) / 2));
            Console.Write("/|\\");
            Console.Write(new string('.', (width - 3) / 2));
            Console.WriteLine();
            Console.Write(new string('.', (width - 3) / 2));
            Console.Write("\\|/");
            Console.Write(new string('.', (width - 3) / 2));
            Console.WriteLine();

            // middle
            for (int i = 0; i < middleHeight; i++)
            {
                int dots = width / 2 - 1 - i;
                int dashes = width / 2 - dots - 1;

                Console.Write(new string('.', dots));
                Console.Write('*');
                Console.Write(new string('-', dashes));
                Console.Write('*');
                Console.Write(new string('-', dashes));
                Console.Write('*');
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }

            // bottom
            Console.WriteLine(new string('*', width));
            Console.Write('*');
            for (int i = 1; i < width; i += 2)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', width));
        }
    }
}
