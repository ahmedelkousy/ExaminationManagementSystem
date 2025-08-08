namespace ExaminationManagementSystem
{
    //multiple choice question
    class MultipleChoiseQu : Questions
    {
        public List<string> Opts { get; set; }
        public MultipleChoiseQu(string quesLvl, QuType quesHead, string quesBody, int correctAns)
            : base(quesLvl, quesHead, quesBody, correctAns)
        {

        }
    }
}
