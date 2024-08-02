using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace StaticMember
{
    internal class Program
    {
        static void Main()
        {
            class1 c = new class1();
            c.display();
            class1.s_i = 90;
            Console.WriteLine(class1.s_i);

            c.P1 = 800;
            Console.WriteLine(c.P1);

            class1.s_P1 = 8;
            Console.WriteLine(class1.s_P1);
        }
    }
    public class class1
    {
        public int i;
        public static int s_i;
        public void display()
        {
            Console.WriteLine("Display called");
            //Console.WriteLine(class1.s_i);

        }
        private int p1;
        public int P1
        {
            set
            {
                if (value >= 100)
                    p1 = value;
                else
                    Console.WriteLine("Invalid");
            }
            get{ return p1;}

        }
        private static  int s_p1;
        public static int s_P1
        {
            set
            {
                Console.WriteLine("Using Static Data member");
                if (value<10)
                    s_p1 = value;
                else
                    Console.WriteLine("Unvalid static P1");
            }
            get { return s_p1; }
        }

      


        
    }
}