using Microsoft.Data.SqlClient;
using System.Data;

namespace DataSetExample
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello World!");
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Emps");

                cmd.CommandText = "select * from Departments";
                da.Fill(ds, "Deps");

                //Primary key constraint
                DataColumn[] arrCols = new DataColumn[1];
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
                ds.Tables["Emps"].PrimaryKey = arrCols;

                //Forigen key constraint
                ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);

                dataGridView1.DataSource = ds.Tables["Emps"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { cn.Close(); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;";

            try
            {
                cn.Open();
                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmdUpdate = new SqlCommand();
                SqlCommand cmdInsert = new SqlCommand();
                SqlCommand cmdDelete = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdInsert.Connection = cn;
                cmdDelete.Connection = cn;
                cmdUpdate.CommandType = System.Data.CommandType.Text;
                cmdUpdate.CommandText = "update Employees set Name = @Name,Basic = @Basic where Empno = @Empno";
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Empno", SourceColumn = "Empno", SourceVersion = DataRowVersion.Original });


                cmdInsert.CommandText = "insert into Employees values(@Empno, @Name, @Basic,@DeptNo)";
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Empno", SourceColumn = "Empno", SourceVersion = DataRowVersion.Current });


                cmdDelete.CommandText = "delete from Employees where Empno = @Empno";
                cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@Empno", SourceColumn = "Empno", SourceVersion = DataRowVersion.Current });


                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = cmdUpdate;
                da.InsertCommand = cmdInsert;
                da.DeleteCommand = cmdDelete;
                da.Update(ds, "Emps");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }

        }
    }
}
