using System.Xml.Serialization;

namespace ExaminationManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mode.Welcome();

            
            Exam t = new Exam();


            t.AddQu(QuType.trueFales, "is the water liquid?", new List<string> { "True", "False" }, (int)TrOrFl.True);

            t.AddQu(QuType.choseOne, "What is the capital of Egypt?",
                  new List<string> { "Berlin", "Madrid", "Cairo", "Rome" }, 2);

            foreach (Questions qu in Exam.LOQ)
            {
                Console.WriteLine(qu);
            }




        }
    }
}
