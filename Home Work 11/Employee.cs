using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Employee : Worker
    {
        const int rate = 15;
        public Employee(string firstName, string surname, int id, byte age, int hour) : base(firstName, surname, id, age)
        {
            base.Salary = rate * hour;
        }

        public void SetSalary(int hour)
        {
            base.Salary = rate * hour;
        }
    }
}
