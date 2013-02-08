using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LINQSelect
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinqSelect.TesteLinqSelect();
            Console.ReadKey();

            Console.Clear();
            LinqSelect.TesteLinqSlectAnonimo();
            Console.ReadKey();

            Console.Clear();
            LinqSelect.TesteLinqSelectComIndice();
            Console.ReadKey();
        }
    }
}
