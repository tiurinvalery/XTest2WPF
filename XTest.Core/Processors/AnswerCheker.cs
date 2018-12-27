using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;
using XTest.Core.Const.Enums;
using XTest.Core.Entities;
using XTest.Core.Entities.Common;
using System.Linq;
using XTest.Core.Holders;

namespace XTest.Core.Processors
{
    public class AnswerCheker : IAnswerCheker
    {
        private readonly HistoryProcess _historyProcess;

        public AnswerCheker()
        {
            _historyProcess = new HistoryProcess();
        }
        public IDataResult<IMarkEntity> Check(ITestAnswerEntity answer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<StateType> CheckQuestion(ITestAnswerEntity testAnswerEntity)
        {
            IDataResult<StateType> methodResult = 
                new DataResult<StateType>();

            bool result = false;

           if (testAnswerEntity.Answer is IMatrixValue)
            {
                IMatrixValue matrixValue = testAnswerEntity.Answer as IMatrixValue;

                IMatrixValue answer = testAnswerEntity.QuestionEntity.Answer as IMatrixValue;

                //TODO
                result =  matrixValue.Matrix.Except(answer.Matrix).Count()==0;
            }
            else
            {
                result = testAnswerEntity.Answer.Value.ToLower()
                    .Equals(testAnswerEntity.QuestionEntity.Answer.Value.ToLower());
            }

            testAnswerEntity.QuestionEntity.StateType = result ? StateType.Corect : StateType.NonCorect;

            _historyProcess.AddHistory(testAnswerEntity, result);

            methodResult.Data = testAnswerEntity.QuestionEntity.StateType;
            methodResult.Success = true;

            return methodResult;
        }
    }
}
