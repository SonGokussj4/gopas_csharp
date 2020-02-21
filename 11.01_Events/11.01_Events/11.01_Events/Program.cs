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

            // Druhy casovac
            System.Timers.Timer timer2 = new System.Timers.Timer();
            timer2.Interval = 3000;
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Enabled = true;

            // Cekani na klavesu, aby se metoda Main() neukoncila
            Console.ReadKey();

        }

        private static void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("World");
            ((System.Timers.Timer)sender).Enabled = false;
        }

        private static void Timer1_Elapsed(object sender,
                                           System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
