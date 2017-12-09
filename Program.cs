using System;

namespace ConsoleApp.SQLite
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new EmployeeContext())
            {
                Console.WriteLine("Enter name of Employee, Age and Salary: ");
                db.Employees.Add(new Employee{
                    Name= Console.ReadLine(),
                    Age= Convert.ToDecimal(Console.ReadLine()),
                    Salary= Convert.ToDecimal(Console.ReadLine())
                    });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Employee in database:");
                foreach (var Employee in db.Employees)
                {
                    Console.WriteLine(" - Employee :{0}, Employee Age :{1}, Employee Salary :{2}", Employee.Name, Employee.Age, Employee.Salary);
                }
            }
        }
    }
}