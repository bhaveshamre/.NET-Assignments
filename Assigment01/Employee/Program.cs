namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employees emp = new Employees();
            Employees emp1 = new Employees(1, "Amol", 123465, 10);
            Employees emp2 = new Employees(1, "Amol", 123465);
            Employees emp3 = new Employees(1, "Amol");
            Employees emp4 = new Employees(1);

            Console.WriteLine(emp.GetNetSalary());
            Console.WriteLine(emp1.GetNetSalary());
            Console.WriteLine(emp2.GetNetSalary());
            Console.WriteLine(emp3.GetNetSalary());
            Console.WriteLine(emp4.GetNetSalary());
        }
    }

    public class Employees
    {
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
                else {
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
            set {
                if (value < 10000 || value > 1000000)
                {
                    Console.WriteLine("Salary should between 10000 and 1000000");
                }
                else {
                    basic = value;
                }
            }
        }

        private short deptno;
        public short Deptno
        {
            get { return deptno; }
            set {
                if (value <= 0) {
                    
                    Console.WriteLine("Dept no should greater than zero");
                } else {
                    deptno = value;
                }
            }
        }
        public decimal GetNetSalary()
        {
            decimal incomeTax = Basic * 0.2M;  // Assuming a 20% income tax rate
            decimal socialSecurity = Basic * 0.0765M;  // Assuming a 7.65% social security rate
            decimal otherDeductions = 200;  // Assuming a flat $200 for other deductions

            decimal netSalary = Basic - (incomeTax + socialSecurity + otherDeductions);
            return netSalary;
        }


        public Employees(int empno , String name , decimal basic , short deptno)
        {
            Empno = empno;
            Name = name;
            Basic = basic;
            Deptno = deptno;
        }

        public Employees() 
            :this(1, "Aryan", 67090, 2) { }

        public Employees(int empno, String name, decimal basic)
            : this(empno , name ,basic ,3) { }

        public Employees(int empno, string name)
         : this(empno, name, 1000, 1) { }

        public Employees(int empno)
            : this(empno, "Aryan" +
                  "", 1000, 1) { }

        
    }
}
