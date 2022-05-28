using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Employee : Worker
    {
        public int Rate { get; set; }
        public Employee(string firstName, string surname, int id, byte age, int rate) : base(firstName, surname, id, age)
        {
            this.Rate = rate;
        }

        public void SetSalary(int hour)
        {
            base.Salary = Rate * hour;
        }
    }
}
