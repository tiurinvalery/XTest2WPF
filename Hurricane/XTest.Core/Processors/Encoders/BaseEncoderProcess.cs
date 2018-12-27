using System.Collections.Generic;
using Hurricane.XTest.Core.Abstract.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class BaseEncoderProcess
    {
        public List<IQuestionEntity> GetQuestionsEncoder(int count, IEncoder encoder)
        {
            List<IQuestionEntity> questionEntities = new List<IQuestionEntity>();
            
            for(int i=0; i<count;i++)
            {
                questionEntities.Add(encoder.QuestionEntity);
            }

            return questionEntities;
        }

    }
}
