using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;
using XTest.Core.Const.Enums;

namespace XTest.Core.Abstract.Processors
{
    public interface IGenerateProcess
    {
        IDataResult<ICollection<IBaseTestEntity>> GetBaseTests();

        IDataResult<ICollection<IQuestionEntity>> GetQuestions(QuestionType questionType);

        IDataResult<string> GetTheotry(string nameTest);
    }
}
