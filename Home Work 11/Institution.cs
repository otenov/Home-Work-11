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
            departments = new List<Department>();
            OrgId = 0;
        }

        public Head head;

        public List<Department> departments;

        public int OrgId { get; set; }

        public override void Appoint(Chief ch)
        {
            if (ch is Head)
            {
                head = ch as Head;
                head.myInstitution = this;
            }
            else return;
        }

        public void Add(Department department)
        {
            if (!this.departments.Contains(department)  && department.InstId ==0)
            {
                this.departments.Add(department);
                department.InstId = this.Id;
            }
            else return; 
        }

        public void Delete(Department dep)
        {
            if (departments.Contains(dep))
            {
                departments.Remove(dep);
                dep.InstId = 0;
            }
            else return;
        }

        public override int CalculateSalary()
        {
            double assumedSalary = 0;
            for (int i = 0; i <= departments.Count - 1; i++)
            {
                assumedSalary += departments[i].CalculateSalary() + 0.15* departments[i].chief.Salary;
            }
            return Convert.ToInt32(assumedSalary);
        }

    }
}
