using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    class Organosation
    {
        public string Name { get; set; }
        public int Inn { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Address { get; set; }
        public int id;
        public Vice vicer;
        public Director dir;
        public List<Institution> institutions;
        public Organosation(string name, int inn, int id, DateTime dateofcreation, string address, Vice vicer, Director dir, List<Institution> institutions = null)
        {
            this.Name = name;
            this.Inn = inn;
            this.DateOfCreation = dateofcreation;
            this.Address = address;
            this.vicer = vicer;
            this.dir = dir;
            if (institutions != null)
            {
                for(int i = 0; i<=institutions.Count-1 ;i++)
                {
                    institutions[i].OrgId = id;
                }
                this.institutions = institutions;
            }
            this.id = id;
        }

        public void Add(Institution inst)
        {
            if (!institutions.Contains(inst) && inst.OrgId == 0)
            {
                institutions.Add(inst);
                inst.OrgId = this.id;
            }
            else return;
        }

        public void Delete(Institution inst)
        {
            if (institutions.Contains(inst))
            {
                institutions.Remove(inst);
                inst.OrgId = 0;
            }
            else return;
        }
    }
}
