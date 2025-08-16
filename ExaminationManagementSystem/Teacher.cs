using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    public class Teacher
    {



        Exam e = new(new());
        public void AddQu(QuType qTyp, string qBody, List<string> opts, int correctAnsIndex)
        {
            if (qTyp == QuType.choseOne)
            {
                ChoseOneAns qu = new(qTyp, opts, correctAnsIndex);
                e.AddQu(qu);
            }
            else if (qTyp == QuType.trueFales)
            {
                TrueFalseQu qu = new(qTyp, qBody, correctAnsIndex);
                e.AddQu(qu);
            }
            else
            {
                Console.WriteLine("Invalid question type");
            }
        }



    }
}
