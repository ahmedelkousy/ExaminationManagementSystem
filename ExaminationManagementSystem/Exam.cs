using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    public class Exam
    {
        public List<Questions> LOQ = new(); // List Of Questions (LOQ)

       public void AddQu(Questions q)
        {
            LOQ.Add(q);
        }


    }
}
