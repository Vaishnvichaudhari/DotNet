using InheritanceExamples4;

//namespace InheritanceExamples1
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Baseclass o1 = new Baseclass();
//            o1.a=1;
//            Derivedclass o2 = new Derivedclass();
//            o2.a=2;

//        }
//    }
//    public class Baseclass //:object
//    {
//        public int a;
//    }
//    public class Derivedclass:Baseclass {
//        public int b;
//    }
//}

//namespace InheritanceExamples2
//{
//    internal class Program
//    {
//        static void Main()
//        {
//        //BaseClass o =new BaseClass();
//        //o.
//        TestAccessSpecifiers.Baseclass o2 = new TestAccessSpecifiers.Baseclass();
//         //o2.


//        }
//    }
//    public class Baseclass
//    {
//        public int PUBLIC;
//        private int PRIVATE;
//        protected int PROTECTED;
//        internal int INTERNAL;
//        protected internal int PROTECTED_INTERNAL;
//        private protected int PRIVATE_PROTECTED;
//    }
//    public class Derivedclass :TestAccessSpecifiers.Baseclass //.BaseClass
//    {
//       void DoNothing()
//        {
//            //this.
//        }
//    }
//}

//namespace InheritanceExamples3
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            //Baseclass b=new Baseclass();
//            //Derivedclass d=new Derivedclass();
//            Derivedclass d1=new Derivedclass(120,240);
//        }
//    }
//    public class Baseclass //:object
//    {
//        public int i;
//        public Baseclass()
//        {
//            Console.WriteLine("Base class no paramter constructor");
//            i = 10;
//        }
//        public Baseclass(int i)
//        {
//            Console.WriteLine("Base class with parameter");
//            this.i = i;
//        }
//    }
//    public class Derivedclass : Baseclass
//    {
//        public int j;
//        public Derivedclass()
//        {
//            Console.WriteLine("Derived with no parameter constructor");
//            //i=10; //base class member should only be intialized in the base class itself
//            j = 20;
//        }
//        public Derivedclass( int i,int j):base(i)
//            //call a specific constructor of the base class
//            //if not speciifed ,it calls no parameter constructor of the base class
//        {
//            Console.WriteLine("Derived class with parameters");
//            this.j = j;
//        }
//    }
//}

namespace InheritanceExamples4
{
    internal class Program

    { 
        static void Main1()
        {
            Derivedclass d = new Derivedclass();
            d.Display1();
            d.Display1("vaishnavi");
            d.Display2();
            d.Display3();


        }
        static void Main()
        {
            Baseclass o;
            o = new Baseclass();
           // o.Display2(); //non virtual,early bound(compile time binding);
           //o.Display3(); //virtual method ,late bound(run time binding)
            
           // o = new Derivedclass();
            //o.Display2(); //non virtual,late bound(run time binding);
            //for early binding, function depends on the reference

            // o.Display3();//virtual method,early bound(compile time binding)
            //for late binding, function called depends on object(memory allocated)

            Console.WriteLine();
            o = new SubDerivedClass();
           // o.Display3();


            Console.WriteLine();
            o = new SubSubderivedClass();
            o.Display3();


        }
        static void Main2()
        {
            Baseclass o1 = new Baseclass();
            Derivedclass o2 = new Derivedclass();
            callDisplay3(o1);
            callDisplay3(o2);
        }
        static void callDisplay3(Baseclass o)
        {
            o.Display3();
        }

    }
    public class Baseclass
    {
       
        public void Display1()
        {
            Console.WriteLine("Base Display1");
        }

        public void Display2()
        {
            Console.WriteLine("Base Display2");
        }

        public virtual void Display3()
        {
            Console.WriteLine("Base Display3");
        }
    }
    public class Derivedclass : Baseclass
    {
        //overload---same name different parameters 
        public void Display1(string s)
        {
            Console.WriteLine("Derived Display1");
        }

        //Hiding---Hides base class method Same name same parameter
        public new void Display2()//new-bcoz of warning 
        {
            Console.WriteLine("Derived Display2");
        }

        //override---must writepublic override for it--- base class method must be virtual
        public override void Display3()
        {
            Console.WriteLine("Derived Display3");
        }

    }
    public class SubDerivedClass : Derivedclass
    {
        public  sealed override void Display3() //sealed method cannot be overriden
        {
            Console.WriteLine("Subderived Display3");
        }
    }
    public class SubSubderivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("SubSubderived class");
        }
    }
}
