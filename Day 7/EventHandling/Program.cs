﻿namespace EventHandling
{
    internal class Program
    {
        //static void Main()
        //{
        //    Class1 objClass1 = new Class1();
        //    //add an event handler

        //    //if the InvalidP1 event happens for objClass1,
        //    //then call the event handling function(objClass1_InvalidP1())
        //    objClass1.InvalidP1 += objClass1_InvalidP1;

        //    objClass1.P1 = 20;

        //}

        //static void objClass1_InvalidP1()
        //{
        //    Console.WriteLine("Invalid P1 Event called");

        //}
        static void Main1()
        {
            Class1 objClass1 = new Class1();


            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.InvalidP1 += Handler2;
            objClass1.P1 = 0;

            Console.WriteLine();
            objClass1.InvalidP1 -= Handler2;
            objClass1.P1 = 0;

        }

        private static void ObjClass1_InvalidP1()
        {
            Console.WriteLine("Invalid P1 Event called");
        }
        private static void Handler2()
        {
            Console.WriteLine("Handler2 called");
        }
    }

    //developer
    //step 1 : create a delegate class having the same signature as the event
    public delegate void InvalidP1EventHandler();
    public class Class1
    {

        //step 2 : declare the event of the delegate type
        //event is a reference of the delegate type
        public event InvalidP1EventHandler InvalidP1;
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event
                    if (InvalidP1 != null)
                        InvalidP1();

                }
            }
        }
    }

}


namespace EventHandling2
{
    internal class Program
    {

        static void Main()
        {
            Class1 objClass1 = new Class1();


            objClass1.InvalidP1 += ObjClass1_InvalidP1;

            objClass1.P1 = 0;

        }

        private static void ObjClass1_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("event raised, invalid value was " + InvalidValue);
        }
    }

    //developer
    //step 1 : create a delegate class having the same signature as the event
    public delegate void InvalidP1EventHandler(int InvalidValue);
    public class Class1
    {

    //step 2 : declare the event of the delegate type
    //event is a reference of the delegate type
     public event InvalidP1EventHandler InvalidP1;
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value > 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event
                    if (InvalidP1 != null)
                        InvalidP1(value);

                }
            }
        }
    }

}