namespace ThreadingExample
{
    internal class Program
    {
    static void Main1()
    {
         Thread t1 = new Thread(Func1);
         t1.Start();

         Thread t2 = new Thread(Func2);
         t2.Start();

         for(int i= 1; i<10; i++)
         {
            Console.WriteLine("Main:" +i);
         }
    }

    static void Main2()
        {
            Thread t1 = new Thread(Func1);
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Main:" + i);
            }
            t1.Join(); //join is a waiting call. next line will run only after func1 is over
            Console.WriteLine("this code should run only after func1 is over");
        } 

    static void Main3()
    {
            Thread t1 = new Thread(Func1);
            t1.Priority = ThreadPriority.Highest; //setting priority to come first highest
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Priority = ThreadPriority.Lowest; 
            t2.Start();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Main:" + i);
            }
    }

    static void Main4()
        {
            Thread t1=new Thread(Func1);
            t1.Start();

            if (t1.ThreadState == ThreadState.Stopped) ; //stops the execution after fun1 over 

            Thread t2 = new Thread(Func2);
            t2.Start();
             
             for(int i=0; i<10; i++)
            {
                Console.WriteLine("Main:" + i);
            }
        }

    static void Main5()
        {
            Thread t1=new Thread(Func1);
            t1.Start();

            Thread t2 =new Thread(Func2);
            t2.Start();
           
            for (int i=1; i<10; i++)
            {
                Console.WriteLine("Main:" + i);
                Thread.Sleep(1000); //sleep\waited for 1sec 
            }

        }

    static void Main6()
        {
            AutoResetEvent a = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main:" +i);

                    if (i % 5 == 0)
                    {
                        //instead of Suspend, use this
                        Console.WriteLine("Waiting");
                        a.WaitOne();
                    }
                }
            });
            t1.Start();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 1....");
            a.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 2....");
            a.Set();

    }
    static void Func1()
        {
      for (int i = 1; i < 10; i++){
          Console.WriteLine("Function1:" + i);
      }
    }

    static void Func2()
        {
        for (int i = 1; i < 10; i++){
            Console.WriteLine("Function2:" + i);
            }
        }
    }
}

//calling func with parameter
namespace ThreadingExample1
{
    internal class Program
    {
        static void Main1()
        {
            Thread t1 = new Thread(Func1);
            int x = 10;
            t1.Start(x);

            Thread t2 = new Thread(Func2);
            string s = "vaishnavi";
            t2.Start(s);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }

        }
        static void Func1(object obj)
        {
           int  x = (int)obj;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Function1:" + i + x);
            }
        }

        static void Func2(object obj)
        {
            string s= obj.ToString();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Function2:" + i + s);
            }
        }
    }
}

//ThreadPool
namespace ThreadingExamples3
{ 
    internal class program
    {
        static void Main()
        {
         
            ThreadPool.QueueUserWorkItem(PoolFunc1, "aaa");
            ThreadPool.QueueUserWorkItem(PoolFunc2);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            int workerthreads, iothreads;

            ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);
            //ThreadPool.SetMinThreads
            //ThreadPool.SetMaxThreads
            //ThreadPool.GetMinThreads(
            Console.WriteLine(workerthreads);
            Console.WriteLine(iothreads);

            Console.ReadLine();
        }
    

    
    static void PoolFunc1(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Thread " + i.ToString() + o.ToString());
            }
    }
    static void PoolFunc2(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread " + i.ToString());
    }
        }
    }
}
