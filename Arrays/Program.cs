using System.Collections;

namespace Arrays
{
    internal class Program
    {
        static void Main1()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++) { 
            //  Console.Write("Enter value of arr["+ i.ToString() + "]:");
            // Console.Write("Enter the value of arr[{0}]:" , i);
            Console.Write($"Enter the value of arr[{i}]:");

            arr[i] = Convert.ToInt32(Console.ReadLine());
            //arr[i]=int.parse(Console.ReadLine()); //converting string array into int array
        }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main2()
        {
            int[,] arr = new int[3,5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]:");

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                } 
            }
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {

                    Console.Write(arr[i,j]); 
                    //arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[3] { 1,2,3 };
            // int pos = Array.IndexOf(arr, 40);
            //int pos = Array.LastIndexOf(arr, 50);
            //int pos=Array.BinarySearch(arr, 30);
            // Array.Reverse(arr);
           // Array.Sort(arr);
           // Array.Reverse(arr);
          // Array.Copy(arr2,arr, 1);
          Array.ConstrainedCopy(arr2,2,arr,1,1);

            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
           
          // Console.WriteLine(arr);
            

        }
    }
}