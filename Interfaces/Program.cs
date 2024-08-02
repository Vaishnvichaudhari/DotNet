namespace Interfaces
{
    internal class Program
    {
        static void Main1()
        {
            class1 o=new class1();
            o.Display();
            //Method1
            o.Insert();
            o.Update();
            o.Delete();
           
          

            //Method2
            IDbFunctions oIDb; //Explicitly casting
            oIDb = o;
            oIDb.Update();
            oIDb.Delete();
            oIDb.Insert();

            //Ifile functions 
            IFileFunctions oIFile;
            oIFile = o;
            oIFile.open();
            oIFile.close();
            oIFile.delete();

            //Method3 ---type casting with interface
            ((IDbFunctions)o).Insert();    //implictily casting
            ((IFileFunctions)o).close();

            //Method4 ---type casting with interface
            (o as IDbFunctions).Update();
            (o as IFileFunctions).close();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFileFunctions
    {
        void open();
        void close();   
        void delete();
    }

    public class class1 : IDbFunctions,IFileFunctions //implements all interface explicitly
    {
        public void Display()
        {
            Console.WriteLine("Display from class1");
        }
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




        //void IFileFunctions.open()
        //{
        //    Console.WriteLine("ifile.open from class1");
        //}

        //void IFileFunctions.close()
        //{
        //    Console.WriteLine("ifile.close from class1");
        //}

        void IFileFunctions.delete()
        {
            Console.WriteLine("ifile.delete from class1");
        }

        public void open()
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Interfaces2 //polymorphic code
{
    internal class Program
    {
        static void Main()
        {
            class1 o = new class1();
            o.Display();
            //Method1
            o.Insert();
            class2 o2 = new class2();
            o2.Insert();




            //Method2
            IDbFunctions oIDb; //Explicitly casting
            oIDb = o;
            oIDb.Update();
            oIDb = o2;
            o2.Update();

            //Method3 ---type casting with interface
            ((IDbFunctions)o).Insert();    //implictily casting
            ((IDbFunctions)o2).Insert();

            //Method4 ---type casting with interface
            (o as IDbFunctions).Update();
            (o2 as IDbFunctions).Update();

        }
        public interface IDbFunctions
        {
            void Insert();
            void Update();
            void Delete();
        }
       public class class1 : IDbFunctions //implements all interface explicitly
        {
            public void Display()
            {
                Console.WriteLine("Display from class1");
            }
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
        }
       public class class2 : IDbFunctions //implements all interface explicitly
            {
                public void Display()
                {
                    Console.WriteLine("Display from class2");
                }
                public void Delete()
                {
                    Console.WriteLine("idb.Delete from class2");
                }

                public void Insert()
                {
                    Console.WriteLine("idb.Insert from class2");
                }

                public void Update()
                {
                    Console.WriteLine("idb.Update from class2");
                }
            }
        }
    }