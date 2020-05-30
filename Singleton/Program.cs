using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingleClass first = SingleClass.getInstance();

            Console.WriteLine("\n First Instance: {0}", first.deger);

            SingleClass second = SingleClass.getInstance();
            Console.WriteLine("\n Second Instance: {0}", second.deger);
        }
    }
}
