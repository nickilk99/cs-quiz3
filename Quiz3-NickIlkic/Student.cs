using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_NickIlkic
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean? IsRegistered { get; set; }

        public Student(int Id, string first, string last, bool? isReg)
        {
            this.Id = Id;
            this.FirstName = first;
            this.LastName = last;
            this.IsRegistered = isReg;
        }

    }
}
