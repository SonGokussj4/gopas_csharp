using System;

namespace CmdLineParams
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                ShowHelp();
                return;
            }

            if (args[0] == "-h" || args[0] == "--help")
            {
                ShowHelp();
                return;
            }
            else if (args[0] == "-d" || args[0] == "--date")
            {
                ShowDate();
                return;
            }
            else if (args[0] == "-t" || args[0] == "--time")
            {
                ShowTime();
                return;
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine(
                "Usage: datetool.exe [-h || --help] [-d || --date] [-t || --time]\n" +
                "\n" +
                "Options:\n" +
                "  -h, --help   Show this help\n" +
                "  -d, --date   Show current date\n" +
                "  -t, --time   Show current time");
        }

        private static void ShowDate()
        {
            string curDate = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(curDate);
        }

        private static void ShowTime()
        {
            string curDate = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(curDate);
        }
    }
}