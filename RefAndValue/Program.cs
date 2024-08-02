using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace RefAndValue
{
    internal class Program
    {
        static  void Main1()
        {
            //Reference type
            class1 o1 = new class1();
            class1 o2= new class1();
            o1.x = 100;
            o2.x = 200;
            o1 = o2;
            o2.x = 300;
            Console.WriteLine(o1.x);
            Console.WriteLine(o2.x);

        }
        static void Main()
        {
            //int value type
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);


        }
        
        static void Main2() {
            //exception string type
            string o1, o2;
            o1 = "300";
            o2 = "600";
            o1 = o2;
            o2 = "200";
            Console.WriteLine(o1);
            Console.WriteLine(o2);

        }
       
    }
    public class class1
    {
        public int x;
    }
    public class class2
    {
        public int i;
    }
    public class class3
    {
        public string s;
    }
}