namespace ArraysToDo
{
    internal class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter No.of Batches:"); 
              a= Convert.ToInt32(Console.ReadLine()); //converting array string into int 
            Console.WriteLine("Enter No.of Student:");
             int[][] CDACYCP = new int[a][];
            for (int i = 0; i < CDACYCP.Length; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());  //converting array string into int 
                CDACYCP[i] = new int[b];

            }
              Console.WriteLine();
            for (int i = 0; i < CDACYCP.Length; i++)
            {
                for (int j = 0; j < CDACYCP[i].Length; j++)
                {
                    Console.Write($"arr[{i}][{j}]:");

                    CDACYCP[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < CDACYCP.Length; i++)
            {
                for (int j = 0; j < CDACYCP[i].Length; j++)
                {


                    Console.Write(CDACYCP[i] [j]);
                  
                }
                Console.WriteLine();
            }
        }
    }
 }
