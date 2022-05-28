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
        }

        public Department myDepartment;

        public virtual void SetSalary()
        {
            int conteiner = myDepartment.CalculateSalary();
            if (conteiner < 1300) Salary =  1300;
            else Salary = conteiner;
        }


    }
}
