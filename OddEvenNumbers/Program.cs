using System;

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
            console.readkey();
        }



        static void printNumbers (string title , IEnumerable<int> numbers)
        { console.WriteLine();
            console.WriteLine($"{title}: [");
        foreach (var number in numbers)
            {
                Console.WriteLine($"{number},");
            }
            Console.WriteLine("]");
            console.WriteLine();
        }
        static bool IsEven(int number)
        { if (number % 2 == 0)
            {return true }
        else { return false; }
        }
        static bool IsOdd(int number)
        {
            if (number % 2 != 0)
            { return true }
            else { return false; }
        }
    }
}
