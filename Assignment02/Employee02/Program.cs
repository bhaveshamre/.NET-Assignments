namespace Employee02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* Employees emp = new Employees();
             Employees emp1 = new Employees( "Amol", 50000, 10);
             Employees emp2 = new Employees( "Amol", 50000);
             Employees emp3 = new Employees( "Amol");


             Console.WriteLine(emp.GetNetSalary());
             Console.WriteLine(emp1.GetNetSalary());
             Console.WriteLine(emp2.GetNetSalary());
             Console.WriteLine(emp3.GetNetSalary());
            */

            Employees o1 = new Employees();
            Employees o2 = new Employees();
            Employees o3 = new Employees();
            Console.WriteLine(o1.Empno+ "  "+ o1.Name);

            Console.WriteLine(o2.Empno + "  " + o2.Name);
            Console.WriteLine(o3.Empno + "  " + o3.Name);
            Console.WriteLine(o3.Empno + "Amol", 50000, 10);

        }
    }

    public class Employees
    {
        private static int nextEmpno = 1; 
        private int empno;
        public int Empno
        {

            get { return empno; }

            set
            {
                if (value > 0)
                {
                    empno = value;
                }
                else
                {
                    Console.WriteLine("Id should be greater than 0");
                }

            }
        }

        private String name;
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            get
            { return basic; }
            set
            {
                if (value > 1000   && value <1000000)
                {
                    basic = value;
                    
                }
                else
                {
                    Console.WriteLine("Salary should between 10000 and 1000000");
                }
            }
        }

        private short deptno;
        public short Deptno
        {
            get { return deptno; }
            set
            {
                if (value <= 0)
                {

                    Console.WriteLine("Dept no should greater than zero");
                }
                else
                {
                    deptno = value;
                }
            }
        }
        public decimal GetNetSalary()
        {
            decimal netSalary = Basic - (Basic * 0.1M); // Assuming 10% deduction for simplicity
            return netSalary;
        }


        public Employees( String name, decimal basic, short deptno)
        {
          
            Name = name;
            Basic = basic;
            Deptno = deptno;
            Empno = nextEmpno++;
        }

        public Employees()
            : this( "Aryan", 67090, 2) { }

        public Employees( String name, decimal basic)
            : this( name, basic, 3) { }

        public Employees( string name)
         : this( name, 25000, 1) { }

    
       


    }
}

