using System;

namespace _10._07_AbstractClass
{
    abstract class Stream
    {
        public void Close()
        {
            Console.WriteLine("Closing Stream");
        }
        public abstract void Open();
    }

    class FileStream : Stream
    {
        public override void Open()
        {
            Console.WriteLine("Opening File Stream");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nelze zkompilovat, protoze z abstraktni classy nejde udelat instance
            //Stream stream = new Stream();

            FileStream fs = new FileStream();
            fs.Open();
            fs.Close();
        }
    }
}
