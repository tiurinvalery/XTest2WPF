using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Entities
{
    public class QuestionEntity : IQuestionEntity
    {
        public string Description { get; set; }
        public BaseValue Question { get; set; }
        public BaseValue Answer { get; set; }
        public StateType StateType { get; set; }
        public QuestionType QuestionType { get; set; }
        public CodeType CodeType { get; set; }
    }
}
