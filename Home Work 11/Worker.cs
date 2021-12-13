using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    abstract class Worker
    {
        static int allId;

        static  Worker()
        {
            allId = 1;
        }

        public string FirstName { get; set; } 

        public string Surname  { get; set; }

        public int Id { get; }

        public byte Age { get; set; }

        public int Salary { get; set; }

        public Worker(string firstName, string surname, int id, byte age)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.Id = allId;
            allId++;
            this.Age = age; 
        }

    }
}
