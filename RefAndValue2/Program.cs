using System.Diagnostics.CodeAnalysis;

namespace RefAndValue2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Init(out i, out j);
            Swap(ref i, ref j);
            print(in i);
            Console.WriteLine(i);
            Console.WriteLine(j);

        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
       
        static void Init(out int a, out int b)
        {
            a = 12;
            b = 13;
        }

        static void print(in int a) {
            Console.WriteLine(a);
        }
    
    }

}