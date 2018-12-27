using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Entities.History;

namespace XTest.Core.Processors
{
    public class HistoryProcess
    {
        public void AddHistory(ITestAnswerEntity testAnswer,bool isSeccess)
        {
            List<CodingHistory> codingHistories = MainHistoryEntity.CodingHistorys;

            CodingHistory currentCoding = codingHistories.FirstOrDefault(p => p.NameTest.ToLower()
            .Equals(testAnswer.NameTest.ToLower()));

            if (currentCoding == null)
            {
                currentCoding = new CodingHistory()
                {
                    NameTest = testAnswer.NameTest,
                    TestHistorys = new List<TestHistory>()
                };

                if(!codingHistories.Contains(currentCoding))
                {
                    codingHistories.Add(currentCoding);
                }
            }
                if (currentCoding.TestHistorys == null)
                {
                    currentCoding.TestHistorys = new List<TestHistory>();
                }

                TestHistory currentTest =
                       currentCoding.TestHistorys.FirstOrDefault(p => !p.IsFinally);

                if (testAnswer.CurrentCount< testAnswer.AllCount)
                {                
                    if (currentTest==null)
                    {
                        currentTest = new TestHistory()
                        {
                            CreateTiem = DateTime.Now,
                            IsFinally = false,
                            AnswerHistorys = new List<AnswerHistoryEntity>()
                        };

                        currentCoding.TestHistorys.Add(currentTest);
                    }
                }
                else
                {
                currentTest.CreateTiem = DateTime.Now;
                    currentTest.IsFinally = true;
                currentTest.Mark = currentTest.AnswerHistorys.Count(p => p.IsCorrect);
                }

                currentTest.AnswerHistorys.Add(new AnswerHistoryEntity()
                {
                    Answer = testAnswer.QuestionEntity.Answer.Value,
                    UserAnswer = testAnswer.Answer.Value,
                    IsCorrect = isSeccess
                });

            SerializerProcess.Serializer();
        }
    }
}
