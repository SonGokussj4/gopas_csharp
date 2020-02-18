using System;

namespace _04._02_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE LOOP
            {
                int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            }

            // FOR LOOP
            {
                //int i;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("For i :" + i);
                }
            }

            // FOR LOOP more complex
            {
                for (int i = 0, j = 10; i < 10; i++, j--)
                {
                    Console.WriteLine("i = {0:C}, j = {1:C}", i, j);
                }
            }

            // NESTED FOR LOOP
            {
                bool EndCycle = false;
                for (int i = 0; i < 10; i++)
                {
                    if (EndCycle == true) break;

                    for (int j = 0; j < 3; j++)
                    {
                        if (i == 6) break;
                        if (i == 7)
                        {
                            EndCycle = true;
                            break;
                        }

                        Console.WriteLine("i = {0}, j = {1}", i, j);
                    }
                }
            }

        }
    }
}
