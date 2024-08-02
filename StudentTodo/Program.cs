namespace Day2HW2
{
    internal class Program
    {
        static void Main()
        {
          Students s1 = new Students("vaishnavi" ,1,60,50,80);
            Students s2 = new Students("vaishnavi", 1, 60,50);
            Students s3= new Students("vaishnavi", 1, 60);
            Students s4 = new Students("vaishnavi", 1);
            Students s5 = new Students("vaishnavi");
            Students s6 = new Students();
            s1.display();
            s2.display();
            s3.display();
            s4.display();
            s5.display();
            s6.display();

        }
    }
    public class Students
    {
        private string name;
        private int rollno;
        private decimal subject1Marks;
        private decimal subject2Marks;
        private decimal subject3Marks;

   public Students(string name=" ", int rollno=0, decimal subject1Marks=0, decimal subject2Marks=0, decimal subject3Marks=0)
        {
           this.name = name;
            this.rollno = rollno;
            this.subject1Marks = subject1Marks;
            this.subject2Marks = subject2Marks;
            this.subject3Marks = subject3Marks;
            
        }

        public string Name
        {
            set
            {
                if (value.Length>50)
                    Name = value;
                else
                {
                    Console.WriteLine("Max 50 character allowded");

                }
            }
            get { return name; }
        }
        public int Rollno
        {
            set
            {
                if (value > 0) 
                    rollno = value;
                else
                {
                    Console.WriteLine("must be>0");
                }
            }
            get { return rollno; }  
        }
        public decimal Subject1Marks
        {
            set { 
                if(value<0  && value>=100)
                    subject1Marks = value;
                else
                {
                    Console.WriteLine("marks 0-100 only");
                }
            }
            get { return subject1Marks; }       
        }
        public decimal Subject2Marks
        {
            set
            {
                if(value<0 && value>=100)  
                    subject2Marks = value;
                else
                {
                    Console.WriteLine("marks 0-100 only");
                }
            }
            get { return subject2Marks; }
        }
        public decimal Subject3Marks
        {
            set
            {
                if (value<0 && value>=100)
                    subject3Marks = value;
                else
                {
                    Console.WriteLine("marks 0-100 only");
                }
            }
            get { return subject3Marks; }
        }
        public decimal CalculatePercentage()
        {
            decimal total = 0;  
            total=subject1Marks+subject2Marks+subject3Marks/3;
            return 0;
        }
        public void display()
        {
            Console.WriteLine("name:" +name);
            Console.WriteLine("rollno:" +rollno);
            Console.WriteLine("subject1Marks:"+ subject1Marks);
            Console.WriteLine("subject2Marks:" + subject2Marks);
            Console.WriteLine("subject3Marks:" + subject3Marks);

        }
    }
   
}