using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_NickIlkic.Services
{
    class NumbersChecker
    {
        public List<int> list { set; get; }

        public NumbersChecker()
        {
            
        }


        public List<int> CheckList(List<int> list)
        {
            List<int> returnList = new List<int>();
            Console.WriteLine("The numbers greater than 80 are: ");
            foreach (int i in list)
            {
                if (i > 80)
                {
                    returnList.Add(i);
                }
            }

            return returnList;
        }

    }
}
