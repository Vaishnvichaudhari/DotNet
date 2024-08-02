namespace ExceptionHandling
{
    internal class Program
    {
        static void Main1() //Simple code for Exception
        {
            class1 obj = new class1();
            try
            {
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());    //FormatException Occured
                obj.P1 = 100 / x;          //NullReferenceEceptionOcurred
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception Occured");
            }
            catch
            {
                Console.WriteLine("Exception Occured");
            }
        }

        static void Main2() //Different catch code for different Exception
        {
            class1 obj = new class1();
            try
            {
                obj = null;  //NullReferenceEceptionOcurred
                int x = Convert.ToInt32(Console.ReadLine());    //FormatException Occured
                obj.P1 = 100 / x;          //DividebyZeroEXception
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception Occured");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("DBException Occured");
            }
            catch(NullReferenceException )
            {
                Console.WriteLine("NullException Occured");
            }
            catch(FormatException )
            {
                Console.WriteLine("FormatEception Occured");
            }
            Console.ReadLine();
        }

        static void Main3() //Exception using base class Exception
        {
            class1 obj = new class1();
            try
            {
                obj = null;  
                int x = Convert.ToInt32(Console.ReadLine());    
                obj.P1 = 100 / x;        
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception Occured");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatEception Occured");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullException Occured");
            }
            //catch (DivideByZeroException ex)
            //catch (ArithmeticException ex)
            catch (SystemException ex) //Base  class Exception has to caught after derived class Exception
            {
                Console.WriteLine("DBException Occured");
            }
            //base class of all exception
            catch (Exception ex) //Catches all unhandled Exception
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void Main() //Finally Block
        {
            class1 obj = new class1();
            try
            {
               // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                 Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception Occured");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatEception Occured");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullException Occured");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException Occured");
            }
            //base class of all exception
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
                Console.WriteLine("After Finally");

            Console.ReadLine();
        }

    }
     public class class1
        {
          private int p1;
          public int P1
            {
               get { return p1; }
               set { p1 = value; }
          }
     }
    
}
namespace ExceptionHandling2
{
    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }

            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex) //all user defined exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex) //all .net exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //dont do this
                    //Console.WriteLine("invalid P1"  );

                    //throw an object of the Exception class or any of its derived classes
                    //Exception ex = new Exception();
                    //Exception ex = new Exception("Invalid P1");
                    //throw ex;
                    //throw new Exception("Invalid P1");

                    //throw new InvalidP1Exception();
                    throw new InvalidP1Exception("Invalid P1");

                }
            }
        }
    }

    public class InvalidP1Exception : ApplicationException
    {
        public InvalidP1Exception(string message) : base(message)
        {

        }
    }


}

