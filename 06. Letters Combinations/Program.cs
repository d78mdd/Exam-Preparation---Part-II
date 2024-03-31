using System;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());

            char excludeLetter = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (excludeLetter != i && excludeLetter != j && excludeLetter != k)
                        {
                            Console.Write(i);
                            Console.Write(j);
                            Console.Write(k + " ");

                            count++;
                        }
                    }
                }

            }

            Console.Write(count);
        }
    }
}
