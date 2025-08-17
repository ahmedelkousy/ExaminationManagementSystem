using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    public class Teacher 
    {

        public virtual void Qqqq(QuType qTyp, string qBody, List<string> opts, int correctAnsIndex)
        {
            if (qTyp == QuType.choseOne)
            {
                ChoseOneAns qu = new(qTyp, qBody , opts, correctAnsIndex);
            }

            else if (qTyp == QuType.trueFales)
            {
                TrueFalseQu qu = new(qTyp, qBody, correctAnsIndex);
            }

            else
            {
                Console.WriteLine("Invalid question type");
            }
            
        }



    }
}
