using System.Runtime.InteropServices;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Const o= new Const();
            Console.WriteLine(o.i);

            Class1 c = new Class1();
            Console.WriteLine(c.a);

        }
        public class Const
        {
            
            public string i;
            public Const(string i = "Hello Constructor")
            {
                //Console.WriteLine("Calling constructor");
                this.i = i;
            }
        }
        public class Class1
        {
            public int a;
            public Class1(int a = 20)
            {
                this.a = a;
            }
        }
        
    }
}