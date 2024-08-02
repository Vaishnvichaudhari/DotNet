//Formatted Data
namespace FileHandlingExample
{
    internal class Program
    {
        static void Main()
        {
          
            WriteToTextFileFormatted();
            ReadFromTextFileFormatted();
        }


        private static void WriteToTextFileFormatted()
        {

            StreamWriter wr = File.CreateText("C:\\.net\\sample.txt");
            wr.WriteLine("line 1");
            wr.WriteLine("Line 2");
            wr.WriteLine("line 3");

            wr.Close();
        }

        private static void ReadFromTextFileFormatted()
        {
            string s;
            StreamReader r = File.OpenText("C:\\.net\\sample.txt");
         
            while ((s = r.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            r.Close();
        }

    }
}