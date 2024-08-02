namespace RefAndValue3 //call by reference

{
    internal class Program
    {
        static void Main()
        {
            class1 o = new class1();
            //o.i = 100;
            //DoSomething(o);
            //DoSomething2(o);
            //DoSomething3( ref o);
           // DoSomething4(out o);
            //DoSomething5(in o);
            Console.WriteLine(o.i);
        }
        static void DoSomething( class1 obj) {
            obj.i = 100;//changes made in func(changing value of properties) is reflected in calling code o
        }

        static void DoSomething2(class1 obj)
        {
            obj = new class1();//changes made in func (obj pointing to some other block) is NOT reflected in calling code o
            obj.i = 200;
        }
        static void DoSomething3( ref class1 obj) { 
            obj = new class1(); //changes made in func (obj pointing to some other block) is reflected in calling code o
            obj.i = 300;
        }
         static void DoSomething4(out class1 obj)
        {
            obj = new class1();
            //obj MUST be initialized
            //changes made in func (obj pointing to some other block) is reflected in calling code o
            obj.i = 400;
        }
        static void DoSomething5(in class1 obj)
        {
            //obj CANNOT be initialized
            //obj = new Class1();

            //changes made in func (changing value of properties) is reflected in calling code o

            obj.i = 500;
        }


    }
    public class class1
    {
        public int i;
    }
}