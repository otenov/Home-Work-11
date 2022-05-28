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
        public Vice vicer;
        public Director dir;
        public List<Institution> institutions;
        public Organosation(string name, int inn, DateTime dateofcreation, string address, Vice vicer, Director dir, List<Institution> institutions = null)
        {
            this.Name = name;
            this.Inn = inn;
            this.DateOfCreation = dateofcreation;
            this.Address = address;
            this.vicer = vicer;
            this.dir = dir;
            this.institutions = institutions;
        }
    }
}
