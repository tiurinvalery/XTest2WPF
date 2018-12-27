using System.Collections.Generic;

namespace XTest.Bl.Core.Entities.History
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
