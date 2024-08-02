using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EmployeeTodo2
{
    internal class Emp
    {
        public static int emp = 1;
        static void Main()
        {
            Employee e1 = new Employee("Vaishnavi",100,10);
            Employee e2 = new Employee("Ashana", 800, 20);
            Employee e3 = new Employee("Manali", 300, 30);
            Employee e4 = new Employee("shweta", 500, 40);
            e1.Display();
            e2.Display();
            e3.Display();
            e4.Display();

        }

    }
    public class Employee
    {
        private int empno;
        private string name;
        private decimal basic;
        private short deptno;
        public Employee(string name = "default", decimal basic = 10000, short deptno = 1)
        {

            empno =Emp.emp++;
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;

        }

        public int Empno
        {

            get
            {
                return empno;
            }
        }


        public string Name
        {
            set
            {
                if (name != null)
                {
                    this.name = value;
                }
            }
            get
            {
                return name;
            }
        }


        public decimal Basic
        {
            set
            {
                if (value >= 18000 && value <= 25000)
                {
                    this.basic = value;
                }
            }
            get
            {
                return basic;
            }
        }

        public short Deptno
        {
            set
            {
                if (value > deptno)
                {
                    this.deptno = value;
                }
            }
            get
            {
                return deptno;
            }
        }


        public decimal GetNetSalary()
        {
            return basic * 2;
        }

        public void Display()
        {
            Console.WriteLine("id: " + empno+","+ "Name: " + name + "," + "Salary: " + GetNetSalary() + "," + "Dept no.: " + deptno);
            
        }
    }
}