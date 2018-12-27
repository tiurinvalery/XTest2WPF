namespace XTest.Bl.Core.Abstract.Entities
{
    public interface IQuestionAnswerEntity
    {
        IQuestionEntity Question { get; set; }
        string Answer { get; set; }
    }
}
