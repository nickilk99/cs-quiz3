using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_NickIlkic.Services
{
    class StudentService
    {
        public bool AddStudent(Student student)
        {
            List<String> list = new List<String>();
            list.Add(student.FirstName);
            list.Add(student.LastName);
            list.Add(student.Id.ToString());
            list.Add(student.IsRegistered.ToString());

            return true;
        }

    }
}
