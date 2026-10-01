using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("System Check - Enter operator ID or system name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName} 👋");
        }
    }

}
