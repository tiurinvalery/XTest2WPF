using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Abstract.Entities.Common;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Abstract
{
    public interface IAnswerCheker
    {
        IDataResult<IMarkEntity> Check(ITestAnswerEntity answer);

        IDataResult<StateType> CheckQuestion(ITestAnswerEntity testAnswerEntity);
    }
}
