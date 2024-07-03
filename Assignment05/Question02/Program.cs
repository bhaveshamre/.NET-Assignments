/*2. Create an array of Employee objects. Convert it to a List<Employee>.  Display all the Employees in the list.*/

namespace Question02
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

                Employee[] employees = new Employee[numEmployees];

                for (int i = 0; i < numEmployees; i++)
                {
                    Console.WriteLine($"Enter Empno for Employee {i + 1}: ");

                    int empNo = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter Name for Employee{i + 1}: ");
                    string name = Console.ReadLine();

                    Console.WriteLine($"Enter Salary for Employee{i + 1}: ");
                    decimal salary = decimal.Parse(Console.ReadLine());

                    employees[i] = new Employee(empNo, name, salary);

                }


                //Convert the array to list 
                List<Employee> emplist = new List<Employee>(employees);

            Console.WriteLine("\nDisplay all employess in the list: ");
            foreach (Employee emp in emplist)
            {
                emp.Display();
            }
            }
        }
    
}
