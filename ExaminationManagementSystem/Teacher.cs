using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagementSystem
{
    public class Teacher
    {

        List<Questions> loq = new List<Questions>();

        public void AddQu(Questions q)
        {
            loq.Add(q);
        }

    }
}
