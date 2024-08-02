using System.ComponentModel.DataAnnotations;

namespace functions
{
    internal class Program
    {
        static void Main()
        {
           class1 o = new class1();
           o.display();
            Console.WriteLine(o.Add(20, 30));
            Console.WriteLine(o.Add(c: 20));
            o.display2("vaishnavi");
            Console.WriteLine(o.sub(80,50));
            Console.WriteLine(o.Mul(2,4,3));

        }
    }

    public class class1
    {
        public void display()
        {
            Console.WriteLine("Display Functions");
        }
        public int Add(int a=0 , int b=0 , int c = 0)
        {
            return a+ b + c;
        }
        public void display2(string s)
        {
            Console.WriteLine( s);
        }
        public int sub(int a ,int b)
        {
            return a - b;
        }
        public int Mul(int a,int b,int c)
        {
            return a * b * c;
        }
     
    }
}