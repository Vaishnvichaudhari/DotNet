namespace AbstractClasses
{
    internal class Program
    {
        static void Main()
        {
            DerivedClass1 o = new DerivedClass1();
            o.Display();
            o.Show();
          
        }
    }
        public abstract class AbsClass1
        {
        public abstract void Display();
        public abstract void Show();
            
        }
    public class DerivedClass1 : AbsClass1
    {
        public override void Display()
        {
            Console.WriteLine("display");
        }

        public override void Show()
        {
            Console.WriteLine("show");
        }
    }

}