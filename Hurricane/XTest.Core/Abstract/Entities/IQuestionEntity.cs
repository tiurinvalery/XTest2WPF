using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Abstract.Entities
{
    public interface IQuestionEntity
    {
        string Description { get; set; }
        BaseValue Question { get; set; }
        BaseValue Answer { get; set; }
        StateType StateType { get; set; }
        QuestionType QuestionType { get; set; }
        CodeType CodeType { get; set; }
    }

    public interface IBaseValue
    {
        string Value { get; set; }
    }

    public interface IMatrixValue : IBaseValue
    {
        string [][] Matrix { get; set; }
    }
}
