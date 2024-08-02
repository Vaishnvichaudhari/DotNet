using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace DeligatesExample
{
    public delegate void Del1();
    public delegate int DelAdd(int a, int b);
    internal class Program
    {
    static void Main1()
        {
            Del1 odel = new Del1(Display);
            odel();


            static void Display()
            {
                Console.WriteLine("Display");
            }

        }
    static void Main2()
        {
            Del1 odel = Display;
            odel();
            odel = Show;
            odel();
            static void Display()
            {
                Console.WriteLine("Display");
            }
            static void Show()
            {
                Console.WriteLine("Show");
            }
        }
        //Multicast delegates
    static void Main3()
        {
            Del1 odel = Display;
            odel();

            Console.WriteLine();
            odel += Show;
            odel();

            Console.WriteLine();
            odel += Display;
            odel();

            Console.WriteLine();
            odel -= Display;
            odel();

            Console.WriteLine();
            DelAdd oDel = Add;
            Console.WriteLine(Add(20, 30));

            Console.WriteLine();
            oDel += Subtract;
            Console.WriteLine(oDel(30, 10));

            static void Display()
            {
                Console.WriteLine("Display");
            }
            static void Show()
            {
                Console.WriteLine("Show");
            }


            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Subtract(int a, int b)
            {
                return a - b;
            }
        }
    static void Main()
      {
            Del1 odel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show),new Del1(Display));
            odel();

            Console.WriteLine();
            odel = (Del1)Delegate.Remove(odel,new Del1(Display));//Removes an element
            odel();

            Console.WriteLine();
            odel=(Del1)Delegate.RemoveAll(odel,new Del1(Display));
            odel();


    static void Display()
      {
      Console.WriteLine("Display");
      }
    static void Show()
      {
      Console.WriteLine("Show");
      }
     }
    }
}