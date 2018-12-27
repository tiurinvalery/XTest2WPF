using System.Collections.Generic;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Abstract.Entities.Common;
using Hurricane.XTest.Core.Const.Enums;


namespace Hurricane.XTest.Core.Abstract.Processors
{
    public interface IGenerateProcess
    {
        IDataResult<ICollection<IBaseTestEntity>> GetBaseTests();

        IDataResult<ICollection<IQuestionEntity>> GetQuestions(QuestionType questionType);

        IDataResult<string> GetTheotry(string nameTest);
    }
}
