using System.Collections.Generic;

namespace Hurricane.XTest.Core.Entities.History
{
    public static class MainHistoryEntity
    {
        public static List<CodingHistory> CodingHistorys { get; set; }

        static MainHistoryEntity()
        {
            if (CodingHistorys == null)
            {
                CodingHistorys = new List<CodingHistory>();
            }
        }
    }

    public class MainHistory
    {
        public List<CodingHistory> CodingHistorys { get; set; } = MainHistoryEntity.CodingHistorys;
    }
}
