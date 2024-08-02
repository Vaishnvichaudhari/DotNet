using System;
using System.IO;
using System.Text;

namespace FileHandlingUnformatted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateFileUnformatted();
            WriteToTextFileUnFormatted();
        }

        private static void CreateFileUnformatted()
        {
            string s = "Vaishnavi";
            byte[] arr = Encoding.Default.GetBytes(s);
            FileStream stream = File.Open("C:\\.net\\unFormatted.txt", FileMode.Create);
            stream.Write(arr, 0, arr.Length);
            stream.Close();
        }

        private static void WriteToTextFileUnFormatted()
        {
            StreamWriter wr = File.CreateText("C:\\.net\\unFormatted.txt");
            wr.WriteLine("Hii Everyone");
            wr.WriteLine("nothing ");
            wr.WriteLine("HEHHEE");

            wr.Close();
        }
    }
}
