using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Entities.History
{
    public static class MainHistoryEntity
    {
        public static List<CodingHistory> CodingHistorys { get; set; }
    }

    public class MainHistory
    {
        public List<CodingHistory> CodingHistorys { get; set; } = MainHistoryEntity.CodingHistorys;
    }
}
