using System.Collections.Generic;
using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Abstract.Entities.Common;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Abstract.Processors
{
    public interface IGenerateProcess
    {
        IDataResult<ICollection<IBaseTestEntity>> GetBaseTests();

        IDataResult<ICollection<IQuestionEntity>> GetQuestions(QuestionType questionType);

        IDataResult<string> GetTheotry(string nameTest);
    }
}
