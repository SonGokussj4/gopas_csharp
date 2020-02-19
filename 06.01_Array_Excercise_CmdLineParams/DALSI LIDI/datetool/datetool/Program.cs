using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetool
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "/?":
                        Console.WriteLine("HeLLp");
                        break;
                    case "/d":
                        Console.WriteLine(DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
                        break;
                    case "/t":
                        Console.WriteLine(DateTime.Now.TimeOfDay);
                        break;
                    default:
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
