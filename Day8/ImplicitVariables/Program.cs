namespace ImplicitVariables
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;
            var j = 100; //implicit variable
                         //used for local variables
                         //cannot be used for class level vars,fn params and return types
            j = 200; //cannot change datatype but parameter can be changed
            //j = "aaa"; //error
           Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}

namespace AnonymousTypes
{
    internal class program
    {
        static void Main()
        {
            var o = new { id = 10, Name = "aaa", salary = 1.2, Reteried = true };
            var o2= new { id = 10, Name = "bbb", salary = 1.2 };

            Console.WriteLine(o.id);
            Console.WriteLine(o.GetType());
            Console.WriteLine(o2.GetType());
        }
    }
}