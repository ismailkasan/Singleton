using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingleClass tek = SingleClass.getInstance();

            Console.WriteLine("\n Ilk Instance: {0}", tek.deger);

            SingleClass tek2 = SingleClass.getInstance();
            Console.WriteLine("\n Ikinci Instance: {0}", tek2.deger);
        }
    }
}
