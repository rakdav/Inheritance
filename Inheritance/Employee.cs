using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee:Human
    {
        private double _salary;
        public Employee(string fName,string lName, double salary)
        {
            LastName = fName;
            FirstName = lName;
            _salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия:{LastName}\n" +
                $"Имя:{FirstName}\n" +
                $"Заработная плата:{_salary}");
        }
    }
}
