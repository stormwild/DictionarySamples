using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionarySamplesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");

            var colors = new Dictionary<string, string>();

            colors["warm"] = "Red";

            Console.WriteLine($"A warm color is {colors.Values.FirstOrDefault()}");

            var codes = new Dictionary<decimal, decimal>();

            codes[1] = 1;

            Console.WriteLine($"Code 1 has a value of {codes[1]}");


            Console.ReadKey();
        }
    }
}
