using System.Collections.Generic;
using XTest.Bl.Core.Abstract.Entities;

namespace XTest.Bl.Core.Processors.Encoders
{
    public class BaseEncoderProcess
    {
        public List<IQuestionEntity> GetQuestionsEncoder(int count, IEncoder encoder)
        {
            List<IQuestionEntity> questionEntities = new List<IQuestionEntity>();
            
            for(int i=0; i<count;count++)
            {
                questionEntities.Add(encoder.QuestionEntity);
            }

            return questionEntities;
        }

    }
}
