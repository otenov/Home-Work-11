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

        public List<Worker> workers;

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
        }

        public string Checked()
        {
            for (; ; )
            {
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) return name;
            }
        }
    }
}
