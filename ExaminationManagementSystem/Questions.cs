using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    // defines the type of question
    public enum QuType
    {
        trueFales = 1,// true or false question
        choseOne = 2 // only chose one answer
    }
    public enum TruFls
    {
        TTrue = 1,
        FFalse = 2
    }

    public abstract class Questions
    {
        protected Questions(QuType qHead, int correctAns)
        {
            QHead = qHead;
            CorrectAns = correctAns;
        }

        public QuType QHead { get; set; }
        public int CorrectAns { get; set; }

    }


    // 1- true false question ------------------------------
    class TrueFalseQu : Questions
    {
        public TrueFalseQu(QuType qHead, int correctAns) : base(qHead, correctAns)
        {
        }
    }


    // 2- single choice question --------------------------
    class ChoseOneQu : Questions
    {
        public ChoseOneQu(QuType qHead, int correctAns) : base(qHead, correctAns)
        {
        }

        public List<string> Opts { get; set; }
       
    }

  








}
