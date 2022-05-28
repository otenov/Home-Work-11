using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Head : Chief
    {

        public Head(string firstName, string surname, int id, byte age): base(firstName, surname, id, age)
        {
            myInstitution = null;
        }

        public Institution myInstitution;

        public override void SetSalary()
        {
            int conteiner = myInstitution.CalculateSalary();
            if (conteiner < 1300) Salary = 1300;
            else Salary = conteiner;
        }


    }
}
