using System.Threading.Channels;

namespace ExpressionBodiedMembers
{
    internal class Program
    {
        static void Main()

        {
           
            Action o1 = () => Console.WriteLine("Display called");
            o1();

            Func<int, int,int > o2 = (a,b) => a + b;
            Console.WriteLine(o2(10,10));

            class1 o = new class1("Chaudhari");
            o.Name = "Vaishnavi";
            Console.WriteLine(o.Name);



        }
    }
    public class class1
    {
        //Methods
        public void Display() => Console.WriteLine("Display called");
        public int Add(int a, int b) => a + b;


        //Property
        private string name;
        public string Name
        {
            get=>name; set => name = value;
        }

        //readonly property
        private string props1;
        public string Props => props1;

        //constructor
        //only single statement is allowded -so ideal for constructor with one parameter
        public class1(string Name)=>this.Name = Name;
    }
}