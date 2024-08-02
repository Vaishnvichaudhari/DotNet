namespace Fields_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
            o.I = 3;
            Console.WriteLine(o.I);
            o.A = "vaishnavi";
            Console.WriteLine(o.A);
            o.D = 2.33;
            Console.WriteLine(o.D);
            o.Z = "Welcome to DotNet";
            Console.WriteLine(o.Z);
     

        }
    }
    public class class1
    {
        private int i;
            public int I
        {
            set
            {
                if (value <= 10)
                    i = value;
                
                    else
                    Console.WriteLine("Inavlid Data");
                }
            get
            {
                return i;
            }
        }
        private string a;
        public string A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
        private double d;
        public double D
        {
            set
            {
                d = value;
            }
            get
            {
                return d;
            }
        }

        public string Z { set; get; }
       
    }

}