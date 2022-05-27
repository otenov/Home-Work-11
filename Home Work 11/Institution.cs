using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Institution : Department
    {
        public Institution(string name) : base(name)
        {

        }

        public Head head;

        public List<Department> departments;

        public override void Appoint(Chief ch)
        {
            if (ch is Head) head = ch as Head;
            else return;
        }

        public void Add(Department department)
        {
            if (!this.departments.Contains(department) && department.Id == 0)
            {
                workers.Add(w);
                w.DepId = this.Id;
            }
            else return;
        }
    }
}
