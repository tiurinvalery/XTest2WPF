namespace Hurricane.XTest.Core.Abstract.Entities
{
    public interface ITestAnswerEntity
    {
        //string UserName { get; set; }
        int AllCount { get; set; }
        int CurrentCount { get; set; }
        string NameTest { get; set; }
        //ICollection<IQuestionEntity> Answers { get; set; }
        IBaseValue Answer { get; set; }
        IQuestionEntity QuestionEntity { get; set; }
    }
}
