using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ModelBindingToDo.Models;
using System.Data;

namespace ModelBindingToDo.Controllers
{
    public class EmployessController : Controller
    {
        // GET: EmployessController
        public ActionResult Index()
        {
            List<Employee> lstEmps = new List<Employee>();
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
            return View(lstEmps);
        }

        // GET: EmployessController/Details/5
        public ActionResult Details(int id)
        {

            Employee e = new Employee();
            e.EmpNo = id;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    e.Name = dr.GetString(dr.GetOrdinal("Name"));
                    e.Basic = dr.GetDecimal(dr.GetOrdinal("Basic"));
                    e.DeptNo = dr.GetInt32(dr.GetOrdinal("DeptNo"));
                }


                else
                    e = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally{cn.Close(); }

            return View(e);
        }

        // GET: EmployessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.Text;
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployessController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee e = new Employee();
            e.EmpNo = id;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    e.Name = dr.GetString(dr.GetOrdinal("Name"));
                    e.Basic = dr.GetDecimal(dr.GetOrdinal("Basic"));
                    e.DeptNo = dr.GetInt32(dr.GetOrdinal("DeptNo"));
                }


                else
                    e = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return View(e);
        }

        // POST: EmployessController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee obj)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
                cn.Open();
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"update Employees set Name=@Name, Basic=@Basic, DeptNo=@DeptNo where Empno=@EmpNo ";
                obj.EmpNo = id;
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery(); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployessController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee e = new Employee();
            e.EmpNo = id;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    e.Name = dr.GetString(dr.GetOrdinal("Name"));
                    e.Basic = dr.GetDecimal(dr.GetOrdinal("Basic"));
                    e.DeptNo = dr.GetInt32(dr.GetOrdinal("DeptNo"));
                }


                else
                    e = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return View(e);
         
        }

        // POST: EmployessController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee obj)
        {
            obj.EmpNo = id;
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
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                return View(    );
            }
            finally { cn.Close(); }


        }
     }
}
