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
    public enum TrOrFl
    {
        True = 1, // true answer
        False = 2 // false answer
    }

    public abstract class Questions
    {
        public int score = 0;
        protected Questions(QuType qTyp, string qBody, int correctAnsIndex)
        {
            QTyp = qTyp;
            QBody = qBody;
            CorrectAnsIndex = correctAnsIndex;


        }

        public QuType QTyp { get; set; }
        public string QBody { get; set; }
        public int CorrectAnsIndex { get; set; }

    }


    // 1- true false question ------------------------------
    //------------------------------------------------------
    class TrueFalseQu : Questions
    {
        
        public TrueFalseQu(QuType qTyp, string qBody, int correctAnsIndex) : base(qTyp, qBody, correctAnsIndex)
        {
            Console.WriteLine(qBody);
            if(correctAnsIndex == (int)TrOrFl.True)
            {
                Console.WriteLine("Correct Answer: True");
                score++;
            }
            else if (correctAnsIndex == (int)TrOrFl.False) 
            {
                Console.WriteLine("Correct Answer: False");
            }
          
        }

       
    }


    // 2- single choice question ---------------------------
    //------------------------------------------------------
    class ChoseOneAns : Questions
    {
       

        public ChoseOneAns(QuType qTyp, string qBody, List<string> opts , int correctAnsIndex) : base(qTyp, qBody, correctAnsIndex)
        {
            Opts = opts;

            Console.WriteLine(qBody);
            for (int i = 0; i < opts.Count; i++)
            {
                Console.WriteLine($"Option {i + 1}: {opts[i]}");
            }

            if (correctAnsIndex == (int)TrOrFl.True)
            {
                Console.WriteLine("Correct Answer: True");
                score++;
            }
            else if (correctAnsIndex == (int)TrOrFl.False)
            {
                Console.WriteLine("Correct Answer: False");
            }
        }

        public List<string> Opts { get; set; }

    }

}
