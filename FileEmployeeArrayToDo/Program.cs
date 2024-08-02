using System;
using System.Collections;

namespace FileEmployeeArrayToDo
{
    internal class Program
    {
        static void Main()
        {
            ArrayList arr=new ArrayList();
            arr.Add(new Employee(1, "Vaishnavi", 100000));
            arr.Add(new Employee(2, "Pranav", 2000)); ;
            arr.Add(new Employee(3, "Aashna", 1100)); ;
            arr.Add(new Employee(4, "Manali", 60000)); ;
            arr.Add(new Employee(5, "Shweta", 12000)); ;
           

           StreamWriter sw = File.CreateText("C:\\.net\\Employee2.txt");
            foreach(Employee  obj in arr)
            {
                sw.WriteLine("EmpNo:" +obj.EmpNo +"," +"Name:" + obj.Name + "," +"salary:" +obj.salary);
            }
            sw.Close();


           StreamReader r = File.OpenText("C:\\.net\\Employee2.txt");
            foreach (Employee obj in arr)
            {
                sw.WriteLine("EmpNo:" + obj.EmpNo + "," + "Name:" + obj.Name + "," + "salary:" + obj.salary);
            }
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