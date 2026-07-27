using System;
using System.Collections.Generic; // لتعريف IEnumerable
using System.Linq;                // لاستخدام ميثود Where

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            printNumbers("numbers", numbers);
            printNumbers("even numbers", numbers.Where(IsEven));
            printNumbers("odd numbers", numbers.Where(IsOdd));

            Console.ReadKey();
        }

        static void printNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (var number in numbers)
            {
                Console.Write($"{number},");
            }
            Console.WriteLine("]");
        }
        static bool IsEven(int number) => number % 2 == 0;

        static bool IsOdd(int number) => !IsEven(number);
    }
}