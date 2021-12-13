using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Intern : Worker
    {
        public Intern(string firstName, string surname, int id, byte age) : base(firstName, surname, id, age)
        {
            base.Salary = 500;
        }

        public void SetSalary()
        {
            base.Salary = 700;
        }
    }
}

