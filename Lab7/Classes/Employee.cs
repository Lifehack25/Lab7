using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Classes
{
    internal class Employee(int id, string name, bool isMale, int salary)
    {
        public int Id = id;
        public string Name = name;
        public bool IsMale = isMale;
        public int Salary = salary;

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, IsMale: {IsMale}, Salary: {Salary}");
        }
    }
}
