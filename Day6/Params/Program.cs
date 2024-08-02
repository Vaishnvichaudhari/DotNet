using System.Diagnostics.CodeAnalysis;

namespace Params
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Subtract(3,2));

        }
        static int Add(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static int Subtract(params int[] arr)
        {
            int sub = 0;
            foreach (int  item in arr)
            {
                sub -= item;
            }
            return sub;
        }
    }
}