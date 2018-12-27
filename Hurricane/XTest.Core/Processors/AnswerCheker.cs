using System;
using System.Linq;
using Hurricane.XTest.Core.Abstract;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Abstract.Entities.Common;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;
using Hurricane.XTest.Core.Entities.Common;

namespace Hurricane.XTest.Core.Processors
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

           if (testAnswerEntity.Answer is MatrixValue)
            {
                IMatrixValue matrixValue = testAnswerEntity.Answer as IMatrixValue;

                IMatrixValue answer = testAnswerEntity.QuestionEntity.Answer as IMatrixValue;

                try
                {
                    for(int i=0;i < matrixValue.Matrix.Length;i++)
                    {
                        for(int j=0;j<matrixValue.Matrix[i].Length;j++)
                        {
                            if (matrixValue.Matrix[i][j]== answer.Matrix[i][j])
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                                break;
                            }
                        }

                        if(!result)
                        {
                            break;
                        }
                    }

                }
                catch
                {
                    result = false;
                }
                //TODO
               // result =  matrixValue.Matrix.Except(answer.Matrix).Count()==0;
            }
            else
            {
                result = testAnswerEntity.Answer.Value.ToLower()
                    .Equals(testAnswerEntity?.QuestionEntity?.Answer?.Value?.ToLower());
            }

            testAnswerEntity.QuestionEntity.StateType = result ? StateType.Corect : StateType.NonCorect;

            _historyProcess.AddHistory(testAnswerEntity, result);

            methodResult.Data = testAnswerEntity.QuestionEntity.StateType;
            methodResult.Success = true;

            return methodResult;
        }
    }
}
