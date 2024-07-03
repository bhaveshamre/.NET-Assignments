namespace Asignment03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();
    }
    public abstract class Employees : IDbFunction
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

        public abstract decimal Basic { get; set; }

        public abstract decimal CalNetSalary();

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    public void Manager : Employees
        {
        }

}