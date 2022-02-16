using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Иван", "Матрасов", 45600);
            employee.Print();
        }
    }
}