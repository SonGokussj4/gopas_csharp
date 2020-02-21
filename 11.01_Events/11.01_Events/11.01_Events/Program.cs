using System;

namespace _11._01_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoreni casovace
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;

            // Napojeni na metodu
            timer1.Elapsed += Timer1_Elapsed;

            // Povolime spusteni casovace
            timer1.Enabled = true;

            // Cekani na klavesu, aby se metoda Main() neukoncila
            Console.ReadKey();

        }

        private static void Timer1_Elapsed(object sender,
                                           System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
