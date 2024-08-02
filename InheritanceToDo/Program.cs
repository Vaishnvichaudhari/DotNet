using System.Net;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace InheritanceToDo
{
    internal class Program
    {
        static void Main()
        {
            Manager manager = new Manager("vaishnavi", 1000, 100);
            Manager manager1 = new Manager("Manali", 2000, 200);
            manager.display();
            manager1.display();
       
        }
    }
    public interface IDBFunctions
    {
        void insert();
        void Update();
        void delete();
    }

    public abstract class Employee:IDBFunctions
    {  
        private string name;
        private int empno;
        public string Name{
           set{ if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid name");
           } get { return name; } 
            
        }
       
        
        private static int id = 1;
        private int Empno{  get { return id; }
        }
        
          
        private short deptno;
        public short Deptno
        {
            set { if(value>0) deptno = value;
                else
                  Console.WriteLine("Invalid Deptno");
            }
            get {  return deptno; }
        }

  
        public abstract decimal Basic{ set; get;  }
        public abstract decimal CalcNetSalary();
        public void insert()
        {
            Console.WriteLine("Insert from IDbFunctions");
        }

        public void Update()
        {
            Console.WriteLine("Update from IDbFunctions");
        }

        public void delete()
        {
            Console.WriteLine("Delete from IDbFunctions");
        }
        
        public Employee(string name = "default", short deptno = 1, decimal basic = 10000)        {
           
            this.Name = name;
            this.Deptno = deptno;
            this.Basic = basic;
            empno = id++;

        }
        public virtual void display()
        {
            Console.WriteLine("Empno:" + empno + "," + "Name:" + name + "," +  "Deptno:" + deptno + "Basic:" + Basic);
        }
    }
    public class Manager : Employee, IDBFunctions
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value != " ") designation = value;
                else
                    Console.WriteLine("Invalid Designation");
            }
            get { return designation; }

        }

        private decimal basic;
        public override decimal Basic
        {
            set
            {
                if (value <= 10000 || value >= 100000)
                    value = basic;
                else Console.WriteLine("Invalid basic");
            }
            get { return basic; }
        }
        public Manager(string name = "default", short deptno = 1, decimal basic = 10000, string designation = "default") : base(name, deptno, basic){
            this.Designation = designation;
        }
        public override decimal CalcNetSalary()
        {
            return Basic * 2;
        }
    }
    public class GeneralManager : Manager,IDBFunctions {
        private string perks;
        public string Perks
        { set; get; }

        public override decimal Basic
        {set
            {if (value <= 10000 || value >= 100000)
                    value = Basic;
                else Console.WriteLine("Invalid basic");
            }
            get
            {
               return Basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 2;
        }

        public GeneralManager(string name = "default", short deptno = 1, decimal basic = 10000,string designation = "default", string perks="default"):base(name, deptno, basic)
        {
            this.Perks= perks;
        }

    }
   

    public class CEO : Employee, IDBFunctions
    {
        private static short deptno;
        public CEO(string name,short deptno=1,decimal basic=10000):base(name,deptno,basic)
        {
          
        }
        public override decimal Basic
        {
            set
            {
                if (value <= 10000 || value >= 100000)
                    value = Basic;
                else Console.WriteLine("Invalid basic");
            }
            get
            {
                return Basic;
            }
        }
        public sealed override decimal CalcNetSalary()
        {
            return Basic * 2;
        }
    }



}


        