using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    abstract class Worker
    {
        public string FirstName { get; set; }

        public string Surname  { get; set; }

        public int Id { get; }

        public byte Age { get; set; }

    }
}
