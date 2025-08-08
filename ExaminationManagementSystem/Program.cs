using System.Xml.Serialization;

namespace ExaminationManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mode.Welcome();


            Teacher t = new Teacher();
            Questions q = new TrueFalseQu("Easy", QuType.trueFales, "Is the sky blue?", 1);



        }
    }
}
