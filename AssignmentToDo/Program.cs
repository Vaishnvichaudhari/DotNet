namespace AssignmentToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[3];             // creating array of employee class
            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i] = new Employee();          // initiating objects
                Console.Write("Enter Name of an Employee : ");
                empArr[i].Name = Console.ReadLine();
                Console.Write("Enter Basic of an Employee : ");
                empArr[i].Basic = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter DeptNO of an Employee : ");
                empArr[i].DeptNo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
            }

            // Employee with Highesh Salary
            Console.WriteLine("Employee with highest salary : ");
            int maxSalEmp = 0;
            for (int j = 1; j < empArr.Length; j++)
            {
                decimal maxSal = empArr[0].getNetSalary();
                if (empArr[j].getNetSalary() > maxSal)
                    maxSalEmp = j;
            }
            empArr[maxSalEmp].display();
            Console.WriteLine();

            // Displaying Emp Details by getting EmpNo
            Console.Write("Enter EmpNo : ");
            int emp = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < empArr.Length; i++)
            {
                if (empArr[i].EmpNo == emp)
                {
                    flag = 1;
                    empArr[i].display();
                    return;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("EmpNo not Found !");
            }

        }
    }

    public class Employee
    {
        public Employee(string name = "default", decimal salary = 1000000, short deptNo = 1)
        {
            this.Name = name;
            this.Basic = salary;
            this.DeptNo = deptNo;
            count++;
            this.empNo = count;
        }
        private string name;
        public string Name
        {
            set
            {
                if (value != "") name = value;
                else Console.WriteLine("Plese Enter Emp Name !");
            }
            get
            {
                return name;
            }
        }
        private static int count = 0;
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value >= 10000 && value <= 1500000)
                {
                    basic = value;
                }
                else Console.WriteLine("Low Salary!");
            }
            get
            {
                return basic;
            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0) deptNo = value;
                else Console.WriteLine("Dept No must be greater than 0");
            }
            get
            {
                return deptNo;
            }
        }
        public decimal getNetSalary()
        {
            return (basic - 10000);
        }
        public void display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("EmpNO : " + EmpNo);
            Console.WriteLine("Basic : " + Basic);
            Console.WriteLine("DeptNo : " + DeptNo);
            Console.WriteLine("Net Salary : " + getNetSalary());
        }
    }
}