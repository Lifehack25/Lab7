using Lab7.Classes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Lab7
{
    internal class Program
    {

        // Utvecklare: Pontus D'Orsay
        static void Main(string[] args)
        {
            // DEL 1
         
            /* Stack<Employee> stack = new();

            // adderar 5 Emplopyees till stacken
            stack.Push(new Employee(1, "John", true, 1000));
            stack.Push(new Employee(2, "Jane", false, 2000));
            stack.Push(new Employee(3, "Jack", true, 3000));
            stack.Push(new Employee(4, "Jill", false, 4000));
            stack.Push(new Employee(5, "James", true, 5000));

            foreach (Employee employee in stack)
            {
                employee.Display();
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            // Eftersom listan ändras efter varje pop så är det bäst att använda en while-loop
            while (stack.Count > 0)
            {
                Employee employee = stack.Pop();
                employee.Display();
                Console.WriteLine($"There are {stack.Count} more employees in the stack.");
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            // Lägger till 5 Employees till stacken
            stack.Push(new Employee(1, "John", true, 1000));
            stack.Push(new Employee(2, "Jane", false, 2000));
            stack.Push(new Employee(3, "Jack", true, 3000));
            stack.Push(new Employee(4, "Jill", false, 4000));
            stack.Push(new Employee(5, "James", true, 5000));

            for (int i = 0; i < 2; i++)
            {
                stack.Peek().Display();
                Console.WriteLine($"There are {stack.Count} more employees in the stack.");
                Console.WriteLine();

                if (i == 1)
                {
                    string message = stack.Any(e => e.Name == "Jack") ? "Jack is in the stack." : "Jack is not in the stack.";
                    Console.WriteLine(message);
                }
            }*/

            // DEL 2

            List<Employee> list = new();

            var employee1 = new Employee(1, "John", true, 1000);
            var employee2 = new Employee(2, "Jane", false, 2000);
            var employee3 = new Employee(3, "Jack", true, 3000);
            var employee4 = new Employee(4, "Jill", false, 4000);
            var employee5 = new Employee(5, "James", true, 5000);

            Employee[] array = [employee1, employee2, employee3, employee4, employee5];
            list.AddRange(array);

            string message = list.Contains(employee1) ? "Jack is in the list." : "Jack is not in the list.";
            Console.WriteLine(message);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            // Hittar alla manliga Employees och skriver ut dem.
            list.FindAll(e => e.IsMale == true)
                .ForEach(e => e.Display());
        }
    }
}
