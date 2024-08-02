using System.Xml.Serialization;

namespace DefaultImplementationOfInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
           // o.Select();   works in default implementation

            IDbFunctions oIdb;
            oIdb = o;
            //oIdb.Select(); works in default implementation and public implementation of class

            (o as IDbFunctions).Select(); //defualt implementation explicit implementation in class
            
        }
    }
        public interface IDbFunctions
        {
            void Insert();
            void Update();
            void Delete();
           void Select()
           {
            Console.WriteLine("Default implementation of select");
           }
    }
    public class class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("idb.Delete from class1");
        }

        public void Insert()
        {
            Console.WriteLine("idb.Insert from class1");
        }

        public void Update()
        {
            Console.WriteLine("idb.Update from class1");
        }

        // public void Select()
        //{
        //   Console.WriteLine("Default implementation of select");
        // }
        void IDbFunctions.Select()
        {
            Console.WriteLine("Class1 explicit implementation of select");
        } 
    }

 }

   