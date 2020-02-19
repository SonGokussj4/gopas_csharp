using System;

namespace command_line_params
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i]) { 


                case "cas":
                    Console.WriteLine(DateTime.Now);
                     break;

                case "nahoda":
                        Random rnd = new Random();
                        Console.WriteLine(rnd.Next(0,1000));
                        break;

                }
            }
        }
    }
}
