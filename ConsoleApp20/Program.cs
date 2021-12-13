using System;
using ClassLibrary1;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();
            Console.WriteLine(cl.Ustegel(12, 6));
            Console.WriteLine(cl.Cix(12, 6));
            Console.WriteLine(cl.Vur(12, 6));
            Console.WriteLine(cl.Bol(12, 6));
        }
    }
}
