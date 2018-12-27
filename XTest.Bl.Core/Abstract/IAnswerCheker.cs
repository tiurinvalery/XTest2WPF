using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Abstract.Entities.Common;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Abstract
{
    public interface IAnswerCheker
    {
        IDataResult<IMarkEntity> Check(ITestAnswerEntity answer);

        IDataResult<StateType> CheckQuestion(ITestAnswerEntity testAnswerEntity);
    }
}
