using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            Console.WriteLine("Hello {0}", name);
        }
    }
}
