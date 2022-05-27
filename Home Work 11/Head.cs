using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Head : Chief
    {
        //Department  myDepartment;

        public Head(string firstName, string surname, int id, byte age): base(firstName, surname, id, age)
        {
            
        }

        public override int SetSalary()
        {

            return base.SetSalary();
        }


    }
}
