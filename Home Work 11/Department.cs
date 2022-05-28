using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Department
    {
        static List<string> depNames;

        static int allId;

        static Department()
        {
            depNames = new List<string>();
            allId = 1;
        }

        public string Name { get; set; }

        public int Id { get; }

        public DateTime DateOfCreation { get; }

        public List<Worker> workers;

        public Chief chief;

        public int InstId { get; set; }

        public Department(string name)
        {
            for(; ; )
            {
                if (!depNames.Contains(name)) { this.Name = name; break; }
                else name = Checked();
            }
            depNames.Add(name);
            this.Id = allId;
            allId++;
            workers = new List<Worker>();
            DateOfCreation = DateTime.Now;
            InstId = 0;
        }

        public string Checked()
        {
            for (; ; )
            {
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) return name;
            }
        }

        public void Add(Worker w)
        {
            if (!workers.Contains(w) && w.DepId == 0)
            {
                workers.Add(w);
                w.DepId = this.Id; 
            }
            else return;
        }

        public void Delete(Worker w)
        {
            if (workers.Contains(w))
            {
                workers.Remove(w);
                w.DepId = 0;
            }
            else return;
        }

        public void Rename()
        {
            depNames.Remove(Name);
            Name = Checked();
            for (; ; )
            {
                if (!depNames.Contains(Name)) { this.Name = Name; break; }
                else Name = Checked();
            }
            depNames.Add(Name);
        }

        public virtual void Appoint(Chief ch)
        {
            if (ch.myDepartment == null)
            {
                chief = ch;
                ch.myDepartment = this;
            }
            else return;
        }

        public virtual int CalculateSalary()
        {
            double assumedSalary = 0;
            for (int i = 0; i <= workers.Count - 1; i++)
            {
                assumedSalary = assumedSalary + 0.15 * workers[i].Salary;
            }
            return Convert.ToInt32(assumedSalary);
        }

    }
}
