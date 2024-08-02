using System;

namespace FileEmployeeToDo
{
    internal class Program
    {
        static void Main()
        {
            Employee e = new Employee(1,"vaishnavi",100000);
            StreamWriter sw = File.CreateText("C:\\.net\\Employee.txt");
            sw.Write("Empno:"+ e.EmpNo +"," +"Name:"+e.Name +"," + "salary:" + e.salary);
            sw.Close();

            StreamReader r = File.OpenText("C:\\.net\\Employee.txt");
            r.Close();

            
           
        }
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal salary { get; set; }

            public Employee(int EmpNo = 0, string Name = "default", decimal salary = 0)
            {
                this.EmpNo = EmpNo;
                this.Name = Name;
                this.salary = salary;
            }
        }
    }
}