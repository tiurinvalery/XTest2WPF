using System;
using System.Collections.Generic;

namespace Hurricane.XTest.Core.Entities.History
{
    public class CodingHistory
    {
        public string NameTest { get; set; }

        public List<TestHistory> TestHistorys { get; set; }
    }

    public class TestHistory
    {
       // public Guid GuidId { get; set; }

        public DateTime CreateTiem { get; set; }

        public int Mark { get; set; }

        public bool IsFinally { get; set; }

        public List<AnswerHistoryEntity> AnswerHistorys { get; set; }
    }
}
