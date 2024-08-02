namespace LinqExample
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static void Main0()
        {
            AddRecs();

            //var returnvalue = from single_object in collection select something;

            var emps = from emp in lstEmp select emp;
            //IEnumerable<Employee> emps = from emp in lstEmp select emp;

            foreach (var item in emps)
            {
                // Console.WriteLine(item.Name);
                //Console.WriteLine(item.EmpNo);
                Console.WriteLine(item);
            }
            foreach (var item in emps)
            {
                // Console.WriteLine(item.Name);
                //Console.WriteLine(item.EmpNo);
                Console.WriteLine(item);
            }
        }
        static void Main1()
        {
            AddRecs();

            //var emps = from emp in lstEmp select emp.Name;
            var emps = from emp in lstEmp select emp.EmpNo;

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();

            //var emps = from emp in lstEmp select emp.Name;
            //var emps = from emp in lstEmp select emp.EmpNo;

            var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };


            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;

            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;

            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main5()
        {
            AddRecs();


            //var emps = from emp in lstEmp
            //               //where emp.Basic > 10000
            //           orderby emp.Name
            //           select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            var emps = from emp in lstEmp
                       orderby emp.DeptNo ascending, emp.Name descending
                       select emp;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main6()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       join dept in lstDept
                             on emp.DeptNo equals dept.DeptNo
                       select emp;

            var emps1 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select dept;

            var emps2 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp, dept };



            var emps3 = from emp in lstEmp
                        join dept in lstDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp.Name, dept.DeptName };
            foreach (var item in emps3)
            {
                Console.WriteLine(item);
            }
            foreach (var item in emps3)
            {

            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}

namespace LinqExample2
{
    internal class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static Employee GetEmployee1(Employee emp)
        {
            return emp;
        }
        static void Main0()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp;
            var emps = lstEmp.Select(GetEmployee1);
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return emp;
            });
            var emps_lambda = lstEmp.Select(e => e);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }

        static string GetEmployee2(Employee emp)
        {
            return emp.Name;
        }
        static void Main1()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp.Name;
            var emps = lstEmp.Select(GetEmployee2);
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return emp.Name;
            });
            var emps_lambda = lstEmp.Select(e => e.Name);
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }

        static void Main2()
        {
            AddRecs();
            //var emps = from emp in lstEmp select new{emp.Name, emp.EmpNo};
            var emps_anon = lstEmp.Select(delegate (Employee emp)
            {
                return new { emp.Name, emp.EmpNo };
            });
            var emps_lambda = lstEmp.Select(e => new { e.Name, e.EmpNo });

            foreach (var item in emps_anon)
            {
                Console.WriteLine(item);
            }
        }

            static bool IsBasicGreaterThan10000(Employee emp)
            {
                if (emp.Basic > 10000)
                    return true;
                else
                    return false;
                //return emp.Basic > 10000;
            }
        
        static void Main3()
        {
            AddRecs();
            //var emps = from emp in lstEmp where emp.Basic > 10000 select emp;
            var emps = lstEmp.Where(IsBasicGreaterThan10000);
            var emps1 = lstEmp.Where(e => e.Basic > 10000);
            var emps2 = lstEmp.Where(e => e.Basic > 10000).Select(e => e);
            var emps3 = lstEmp.Select(e => e).Where(e => e.Basic > 10000);

            //var emps = from emp in lstEmp where emp.Basic > 10000  select emp.Basic;
            var emps2a = lstEmp.Where(e => e.Basic > 10000).Select(e => e.Basic);
            //var emps3a = lstEmp.Select(e => e.Basic).Where(e => e.Basic > 10000);
            var emps3a = lstEmp.Select(e => e.Basic).Where(e => e > 10000);

            //var emps = from emp in lstEmp  where emp.Basic > 10000  select emp.Name;
            //var emps4a = lstEmp.Select(e => e.Name).Where(e => e > 10000); //ERROR

            foreach (var item in emps1)
            {
                Console.WriteLine(item);
            }
        }

        static void Main4()
        {
            AddRecs();

            //var emps = lstEmp.OrderBy(e => e.Name);
            //var emps = lstEmp.OrderByDescending(e => e.Name);


            var emps = from emp in lstEmp
                       orderby emp.DeptNo ascending, emp.Name descending
                       select emp;

            var emps1 = lstEmp.OrderBy(e => e.DeptNo).ThenByDescending(e => e.Name);



            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in emps1)
            {
                Console.WriteLine(item);
            }
        }
        static void Main5()
        {
            AddRecs();
            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //                 on emp.DeptNo equals dept.DeptNo
            //           select emp;

            //var emps = from  in 
            //           join  in 
            //                 on  equals 
            //           select emp;

            var emps2a = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp);
            var emps2b = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept);
            var emps2c = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp.DeptNo);
            var emps2d = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept.DeptNo);

            var emps2e = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp, dept });
            var emps2f = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp.Name, dept.DeptName });

            foreach (var item in emps2f)
            {
                Console.WriteLine(item);
            }
            //foreach (var item in emps)
            //{
            //    //item.dept.DeptName;
            //}

        }

        //Single
        static void Main6()
        {
            AddRecs();
            Employee emp = lstEmp.Single(e => e.EmpNo == 1); //one record = okay
            //Employee emp = lstEmp.Single(e => e.EmpNo == 10);  //no records = error
            //Employee emp = lstEmp.Single(e => e.Basic > 5000); //multiple records - error


            //Employee emp = lstEmp.SingleOrDefault(e => e.EmpNo == 1); //one record = okay
            //Employee emp = lstEmp.SingleOrDefault(e => e.EmpNo == 10); //no records=null
            //Employee emp = lstEmp.SingleOrDefault(e =>  e.Basic > 5000);//multiple records - error

            if (emp != null)
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            else
                Console.WriteLine("not found");
            Console.ReadLine();
        }

        //deferred execution
        static void Main7()
        {
            AddRecs();
            var emps = from emp in lstEmp select emp;

            Console.WriteLine();
            lstEmp.RemoveAt(0);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();

            Console.WriteLine();
            lstEmp.Add(new Employee { EmpNo = 9, Name = "New", Basic = 11000, DeptNo = 40, Gender = "F" });
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();
        }

        //immediate execution
        static void Main8()
        {
            AddRecs();
            var emps = from emp in lstEmp select emp;
            //immediate execution
            emps = emps.ToList();  //.ToArray .ToDictionary

            //var emps2 = (from emp in lstEmp select emp).ToList();

            //Employee [] arrEmps = emps.ToArray();
            //Dictionary<int, Employee> d = emps.ToDictionary(e => e.EmpNo);

            Console.WriteLine();
            lstEmp.RemoveAt(0);
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();
            Console.WriteLine();
            lstEmp.Add(new Employee { EmpNo = 9, Name = "New", Basic = 11000, DeptNo = 40, Gender = "F" });
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();
        }

        //simple group
        static void Main9()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       group emp by emp.DeptNo;

            foreach (var item in emps)
            {
                Console.WriteLine(item.Key); //deptno
                foreach (var e in item)  //e is an Employee, item is a grouping of Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //group with a name
        static void Main10()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       group emp by emp.DeptNo into group1
                       select group1;


            foreach (var item in emps)
            {
                Console.WriteLine(item.Key); //deptno
                foreach (var e in item)  //e is an Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        //properties of the group
        static void Main11()
        {
            AddRecs();

            var emps = from emp in lstEmp
                       group emp by emp.DeptNo into group1
                       select new { group1, Count = group1.Count(), Max = group1.Max(x => x.Basic), Min = group1.Min(x => x.Basic) };


            foreach (var item in emps)
            {

                Console.WriteLine(item.group1.Key); //DeptNo
                Console.WriteLine(item.Count); //count
                Console.WriteLine(item.Min); //min
                Console.WriteLine(item.Max); //max
                //emp.group1.Key;  //DeptNo

                foreach (var e in item.group1)  //e is an Employee
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}