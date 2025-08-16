using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    internal class Exam
    {
        public List<Questions> LOQ { get; set; } // List of questions (LOQ)

        public Exam(List<Questions> listOfQues)
        {
            LOQ = listOfQues;
        }
        public void AddQu(Questions q)
        {
            LOQ.Add(q);
        }


    }
}
