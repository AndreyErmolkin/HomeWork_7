using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_7
{
    class Program
    {

        static void Main(string[] args)
        {

            //List<string> numbers = new List<string>() { "108", "655", "12", "7", "65", "98", "36", "898", "14", "111" };
            List<int> numbers = new List<int>() { 874, 424, 712, 113, 44, 667, 904, 12, 3, 881 };

            List<int> results = new List<int>();

            results = numbers.Select(r => r % 10).ToList();
            Console.WriteLine(string.Join(", ", results));
        }

    }
}
