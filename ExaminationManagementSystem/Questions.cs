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

    public abstract class Questions
    {
        protected Questions(QuType qTyp, string qBody, int correctAnsIndex)
        {
            QTyp = qTyp;
            QBody = qBody;
            CorrectAnsIndex = correctAnsIndex;
        }

        public QuType QTyp { get; set; }
        public string QBody { get; set; }
        public int CorrectAnsIndex { get; set; }

        public abstract void AddQu(Questions q);

    }


    // 1- true false question ------------------------------
    //------------------------------------------------------
    class TrueFalseQu : Questions
    {
        public TrueFalseQu(QuType qTyp, string qBody, int correctAnsIndex) : base(qTyp, qBody, correctAnsIndex)
        {
        }

        public override void AddQu(Questions q)
        {

        }
    }


    // 2- single choice question ---------------------------
    //------------------------------------------------------
    class ChoseOneAns : Questions
    {
       

        public ChoseOneAns(QuType qTyp, string qBody, List<string> opts , int correctAnsIndex) : base(qTyp, qBody, correctAnsIndex)
        {
            Opts = opts;
        }

        public List<string> Opts { get; set; }

        public override void AddQu(Questions q)
        {

        }
    }

  








}
