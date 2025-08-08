using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{

    public abstract class Questions
    {

        public Questions(string quesLvl, QuType quesHead, string quesBody, int correctAns)
        {
            QLvl = quesLvl;
            QHead = quesHead;
            QBody = quesBody;
            CorrectAns = correctAns;
        }

        public string QLvl { get; set; }
        public QuType QHead { get; set; }
        public string QBody { get; set; }
        public int CorrectAns { get; set; }
    }
}
