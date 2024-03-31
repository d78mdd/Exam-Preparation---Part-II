using System;

namespace _06.Letters_Combinations_try_optimize_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());

            char excludeLetter = char.Parse(Console.ReadLine());

            int count = 0;

            string partialFinalString = "";

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
                                    partialFinalString = partialFinalString + ($"{i}{j}{k} ");

                                    if (partialFinalString.Length > 100)
                                    {
                                        Console.Write(partialFinalString);
                                        partialFinalString = "";
                                    }

                                    count++;
                                }
                            }
                        }
                    }
                }

            }

            Console.Write(partialFinalString);

            Console.Write(count);
        }
    }
}

