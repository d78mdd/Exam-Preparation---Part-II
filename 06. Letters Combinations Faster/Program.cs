using System;

namespace _06.Letters_Combinations_Faster
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
                if (excludeLetter != i)
                {
                    for (char j = startLetter; j <= endLetter; j++)
                    {
                        if (excludeLetter != j)
                        {
                            for (char k = startLetter; k <= endLetter; k++)
                            {
                                if (excludeLetter != k)
                                {
                                    Console.Write(i);
                                    Console.Write(j);
                                    Console.Write(k + " ");

                                    count++;
                                }
                            }
                        }
                    }
                }

            }

            Console.Write(count);
        }
    }
}
