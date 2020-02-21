using System;

namespace _10._07_AbstractClass
{
    abstract class Stream
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Nelze zkompilovat, protoze z abstraktni classy nejde udelat instance
            //Stream stream = new Stream();
        }
    }
}
