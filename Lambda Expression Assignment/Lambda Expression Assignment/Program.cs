using System;
using System.Collections.Generic;
using System.Linq;


namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Bloggs" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Alice", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Bob", LastName = "White" },
                new Employee { Id = 7, FirstName = "Charlie", LastName = "Black" },
                new Employee { Id = 8, FirstName = "Diana", LastName = "Green" },
                new Employee { Id = 9, FirstName = "Edward", LastName = "Blue" },
                new Employee { Id = 10, FirstName = "Fiona", LastName = "Gray" }
            };

            // Create a new list to hold employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();

            // Use a foreach loop to filter employees with the first name "Joe"
            foreach (Employee employee in employees)
            {
                // Check if the employee's first name is "Joe"
                if (employee.FirstName == "Joe")
                {
                    // Add the employee to the list of Joes
                    joes.Add(employee);
                }
            }

            // Output the filtered list of employees with the first name "Joe"
            Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
            foreach (Employee joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to filter employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Output the filtered list of employees with the first name "Joe" using lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to create a list of employees with Id greater than 5
            List<Employee> highIdEmployees = employees.Where(e => e.Id > 5).ToList();

            // Output the filtered list of employees with Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee emp in highIdEmployees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Keep the console open until a key is pressed
            Console.ReadLine();
        }
    }
}
