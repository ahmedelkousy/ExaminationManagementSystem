namespace ExaminationManagementSystem
{
    //single choice question
    class ChoseOneQu : Questions
    {
        public List<string> Opts { get; set; }
        public ChoseOneQu(string quesLvl, QuType quesHead, string quesBody, int correctAns)
            : base(quesLvl, quesHead, quesBody, correctAns)
        {

        }
    }
}
