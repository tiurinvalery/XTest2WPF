using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using XTest.Bl.Core.Entities.History;

namespace XTest.Bl.Core.Processors
{
   public static class SerializerProcess
    {
        public static void Serializer()
        {
            MainHistory historyEntity = new MainHistory();

            XmlSerializer formatter = new XmlSerializer(typeof(List<CodingHistory>));

            using (FileStream fs = new FileStream("history.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, historyEntity.CodingHistorys);
            }
        }

        public static void Deserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<CodingHistory>));

            if (File.Exists("history.xml"))
            {
                try
                {
                    using (FileStream fs = new FileStream("history.xml", FileMode.OpenOrCreate))
                    {
                        List<CodingHistory> historyEntity = (List<CodingHistory>)formatter.Deserialize(fs);
                        MainHistoryEntity.CodingHistorys = historyEntity;
                    }
                }
                catch (Exception e)
                {

                }
            }
        }


        }
}
