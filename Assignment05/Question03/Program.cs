/*3. Create a List<Employee>. Convert it to an array. Display all the array elements.*/

namespace Question03
{
    public class Employee
    {
        public int empno
        {
            get; set;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }


        public Employee(int empNo, string name, decimal salary)
        {
            empno = empNo;
            Name = name;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"EmpNo: {empno} , Name: {Name} , Salary: {Salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Employees: ");

            int numEmployees = int.Parse(Console.ReadLine());


            List<Employee> Employees = new List<Employee>(numEmployees);


            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter Empno for Employee {i + 1}: ");

                int empNo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Name for Employee{i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter Salary for Employee{i + 1}: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Employees.Add(new Employee(empNo, name, salary));

            }


            //Convert the list to an Array 

            Employee[] employArray = Employees.ToArray();

            Console.WriteLine("\nDisplay all employess in the list: ");
            foreach (Employee emp in employArray)
            {
                emp.Display();
            }
        }
    }
}
