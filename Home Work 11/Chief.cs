using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Chief : Worker
    {
        public Chief(string firstName, string surname, int id, byte age) : base(firstName, surname, id, age)
        {
            myDepartment = null;
            Salary = 1300;
        }

        public Department myDepartment;

        public virtual int SetSalary()
        {
            double assumedSalary = 0;
            for (int i = 0; i <= myDepartment.workers.Count-1;i++)
            {
               assumedSalary = assumedSalary + 0.15 * myDepartment.workers[i].Salary;
            }
            if (assumedSalary > 1300) return Convert.ToInt32(assumedSalary);
            else return 1300;
        }
    }
}
