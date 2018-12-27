using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Entities
{
   public class BaseValue : IBaseValue
    {
        public string Value { get; set; }
    }

    public class  MatrixValue : BaseValue, IMatrixValue
    {
       public string[][] Matrix { get; set; }
    }

    public class MatrixQuestionEntity : IQuestionEntity
    {
       public string Description { get; set; }
       public BaseValue Question { get; set; } = new MatrixValue();
       public BaseValue Answer { get; set; } =new MatrixValue();
       public StateType StateType { get; set; }
       public QuestionType QuestionType { get; set; }
       public CodeType CodeType { get; set; }
    }
}
