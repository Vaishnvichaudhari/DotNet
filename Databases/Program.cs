using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Databases
{
    internal class Program
    {
        static void Main0(string[] args)
        {
            // Connect();
            // Insert();
            // Update();

            // Employee obj = new Employee() { EmpNo = 4, Name = "Shubham", Basic = 1200, DeptNo = 40 };
            //Employee obj = new Employee() { EmpNo = 5, Name = "pranav", Basic = 10200, DeptNo = 50 };
            //Insert2();
            //InsertWithParameters(obj);
            // InsertWithStoredPro(obj);

            // SingleValued();
            // DataReader1();
            //DataReader2();
            // UpdateWithParameters(obj);
            // UpdateWithStoredPro(obj);
            // DeleteWithParameters(obj); 
            //Employee obj = new Employee() { EmpNo = 4 };
            //DeleteWithStoredPro(obj);
            // MARS();
            // CallDataReaderFunction();
            //Transactions();
            // CallDataReaderFunction();
     
            // Delete();
        }

        static void Main()
        {

            //Employee obj = GetSingleEmployee(1);
            //Console.WriteLine(obj.Name);

            List<Employee> list = GetAllEmployees();

        }
        static void Insert()//Connect() 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(3 ,'Shweta', 12345,10)";
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void Insert2(Employee obj)// To store Multiple records  //error with special character 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(3 ,'Shweta', 12345,10)";
                cmd.CommandText = $"insert into Employees values({obj.EmpNo} ,'{obj.Name}' ,{obj.Basic} ,{obj.DeptNo})";

                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void InsertWithParameters(Employee obj) // Insert with parameters 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "insert into Employees values(3 ,'Shweta', 12345,10)";
                cmd.CommandText = $"insert into Employees values(@EmpNo ,@Name, @Basic, @DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }


        static void InsertWithStoredPro(Employee obj) // Insert with stored procedure
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // cmd.CommandText = "insert into Employees values(3 ,'Shweta', 12345,10)";
                cmd.CommandText = "InsertEmployee";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }


        static void Update()//To Update  single Employee 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update Employees set Basic=1000 where EmpNo=3";
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void UpdateWithParameters(Employee obj)//Update with parameters 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"update Employees set Name=@Name, Basic=@Basic, DeptNo=@DeptNo where Empno=@EmpNo ";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void UpdateWithStoredPro(Employee obj)// Update with stored procedures
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = $"UpdateEmployees";

                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }


        static void Delete()//To Delete a record 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Employees WHERE  EmpNo=4";
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void DeleteWithParameters(Employee obj)//To Delete a record with parameters 
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Employees WHERE  EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void DeleteWithStoredPro(Employee obj) //Delete with stored Procedures
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = $"DeleteEmployees";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);

                cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void SingleValued()  //return only single value
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.CommandText = "select Name from Employees where EmpNo=1";
                cmd.CommandText = "select count(*) from Employees";

                object retval = cmd.ExecuteScalar(); //ExecuteScaler is only used for single value
                Console.WriteLine(retval);


                // cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        static void MARS()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=true;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmdDepts = new SqlCommand();
            cmdDepts.Connection = cn;
            cmdDepts.CommandType = CommandType.Text;
            cmdDepts.CommandText = "Select * from Departments";

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;

            SqlDataReader drDepts = cmdDepts.ExecuteReader();
            while (drDepts.Read())
            {
                Console.WriteLine((drDepts["DeptName"]));

                cmdEmps.CommandText = "Select * from Employees where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    Console.WriteLine(("    " + drEmps["Name"]));
                }
                drEmps.Close();
            }
            drDepts.Close();
            cn.Close();

        }

        static void CallDataReaderFunction()
        {
            SqlDataReader dr = GetDataReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["EmpNo"]);
            }
            dr.Close();
            //if (cn.State == ConnectionState.) 
            //Console.WriteLine(cn.State);
        }
  

        static SqlDataReader GetDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True";
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "select * from Employees ";
           // SqlDataReader dr = cmdInsert.ExecuteReader();
           SqlDataReader dr = cmdInsert.ExecuteReader(CommandBehavior.CloseConnection);
            //cn.Close();
            return dr;
        }

        static void Transactions()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True";
            cn.Open();
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.Transaction = t;

            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into Employees values(10, 'Aniket', 12345, 30)";

            SqlCommand cmdInsert2 = new SqlCommand();
            cmdInsert2.Connection = cn;
            cmdInsert2.Transaction = t;

            cmdInsert2.CommandType = System.Data.CommandType.Text;
            cmdInsert2.CommandText = "insert into Employees values(20, 'Pranav', 12345, 10)";
            try
            {
                cmdInsert.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();
                t.Commit();
                Console.WriteLine("no errors- commit");
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine("Rollback");
                Console.WriteLine(ex.Message);
            }
            cn.Close();

        }
    

        static void DataReader1()  //read single table
    {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
        try
        {
            cn.Open();
            // SqlCommand cmd = cn.CreateCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Console.WriteLine(dr[0]);
                // Console.WriteLine(dr["EmpNo"]);
                Employee obj = new Employee();
                obj.EmpNo = dr.GetInt32("EmpNo");
            }
            dr.Close();

            // cmd.ExecuteNonQuery(); //To run the database

            Console.WriteLine("Success");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { cn.Close(); }


    }

        static Employee GetSingleEmployee(int EmpNo)
        {
            Employee obj = new Employee();
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                //dr.HasRows
                if (dr.Read())
                {
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");

                }
                else
                    obj = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return obj;
        }
        static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();
            //
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee obj = new Employee();
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");
                    lstEmps.Add(obj);

                    //lstEmps.Add(new Employee { EmpNo = dr.GetInt32("EmpNo") })
                }
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return lstEmps;
        }

        static void DataReader2()  //read Multiple table
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees; select * from Departments";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Console.WriteLine(dr[0]);
                    // Console.WriteLine(dr["EmpNo"]);
                    //Employee obj = new Employee();
                    //obj.EmpNo = dr.GetInt32("EmpNo");
                    Console.WriteLine(dr.GetInt32("EmpNo"));
                }
             
                dr.NextResult();
                while(dr.Read())
                {
                    Console.WriteLine(dr.GetInt32("DeptNo"));

                }



                // cmd.ExecuteNonQuery(); //To run the database

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }



        public class Employee
        {
            public int EmpNo { set; get; }
            public string Name { set; get; }
            public decimal Basic { set; get; }
            public int DeptNo { set; get; }
        }
    }
}