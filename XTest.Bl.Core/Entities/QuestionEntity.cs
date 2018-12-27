using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Entities
{
    public class QuestionEntity : IQuestionEntity
    {
        public string Description { get; set; }
        public IBaseValue Question { get; set; }
        public IBaseValue Answer { get; set; }
        public StateType StateType { get; set; }
        public QuestionType QuestionType { get; set; }
        public CodeType CodeType { get; set; }
    }
}
