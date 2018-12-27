using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;
using XTest.Core.Const.Enums;
using XTest.Core.Entities.Common;

namespace XTest.Core.Abstract
{
    public interface IAnswerCheker
    {
        IDataResult<IMarkEntity> Check(ITestAnswerEntity answer);

        IDataResult<StateType> CheckQuestion(ITestAnswerEntity testAnswerEntity);
    }
}
