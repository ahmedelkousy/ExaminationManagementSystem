using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    internal class Exam
    {
        public List<Questions> Ques { get; set; }

        public Exam(List<Questions> ques)
        {
            Ques = ques;
        }
    }
}
