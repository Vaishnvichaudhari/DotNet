using System.Threading.Channels;

namespace AnonymonusMethodsAndLambdas
{
    internal class Program
    {
        static void Main()
        {
            int i = 100;
            Action o1 = delegate ()

            {
                Console.WriteLine(i);
                Console.WriteLine("Anonymous method called"); ;

            };
            o1();
            Func<int, int, int> o2 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(o2(10, 20));


            Predicate<int> o3 = delegate (int a)
            {
                if (a % 2 == 0)
                    return true;
                else
                    return false;
            };
            //Console.WriteLine(o3(10));

            Func<int, int> o4 = (a) => a * 2;
            Console.WriteLine(o4(10));

            Func<int ,int ,int> o5=(a ,b) => a + b;  //with lambda function 
            Console.WriteLine(o5(10,30));

            Func<string> o6 =()=> DateTime.Now.ToLongTimeString(); 
             Console.WriteLine(o6());

            Employee e = new Employee { EmpNo = 1, Name = "a", Basic = 1200 };
            Predicate<Employee> o7 = (obj) => e.Basic > 10000;
         
            Console.WriteLine(o7(e));


            Func<int, bool> o8 = (int a) => a % 2 == 0;
            Console.WriteLine(o8(10));

            Action o9 = () =>  Console.WriteLine("Void return val function"); //if multiple then use {}
            o9();


        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }

        }
    }
}
