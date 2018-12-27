using Exceptionless.Json;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane.XTest.Core.Processors
{
    public class JsonParser<T> where T : IQuestionEntity
    {
        public static List<int> SaveList = new List<int>();
        public static Random _random = new Random();

        public IQuestionEntity GetIQuestionEntity(int start, int end, string name)
        {
            int value = 1;

            //do
            //{

            //    value = _random.Next(start, end);
            //}
            //while (SaveList.Contains(value));

            // SaveList.Add(value);
            string path = Path.Combine(GenerateProcess.BasePath,
                name, value + ".json");

            using (StreamReader st = new StreamReader(path, Encoding.UTF8))
            {

                string json = st.ReadToEnd();

                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
