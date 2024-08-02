
namespace Day2HW1
{
    internal class Program
    {
        static void Main()
        {
            Employee o1 = new Employee(1, "Amol", 123465,10);
            Employee o2 = new Employee(1, "Amol", 123465);
            Employee o3 = new Employee(1, "Amol");
            Employee o4 = new Employee(1);
            Employee o5 = new Employee();
            o1.display();
            o2.display();
            o3.display();
            o4.display();
            o5.display();


        }     
    }
  public class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid name");
            }
            get { return name; }
        }
       
        private int id;
        private decimal basic;
        private short deptno;

        public Employee(int Id=1, string Name="default", decimal Basic=10000,short dept=1) {
            this.Name=Name;
            this.Id = Id;
            this.Basic = Basic;
            this.Deptno = dept;
        }
         public int Id
         {
            set
            {
                if (value > 0)
                    id = value;
                else
                {
                    Console.WriteLine("It must be greater than 0");
                }
            }
            get{ return id; }
        }

        public  decimal Basic
        {
            set
            {
                if (value <= 10000 || value >= 100000)
                    basic = value;
                else
                {
                    Console.WriteLine("Must be between in some range");
                }
            }
            get { return basic; }
        }
        public short Deptno
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                {
                    Console.WriteLine("Must be >0");
                }
            }
            get { return deptno; }
        }
        public decimal GetNetSalary()
        {
            return basic * 2;
        }
     public void display()
        {
            Console.WriteLine("name:" +Name +","+
                "id:" + id + "," +
                "Salary: " + GetNetSalary()+","+ 
                "deptno:" + deptno);
           ;
        }
  }

    
}
