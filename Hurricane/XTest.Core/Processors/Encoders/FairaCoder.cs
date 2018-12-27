using System;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class FairaCoder : IEncoder
    {
        public static Random _random = new Random();
        private JsonParser<QuestionEntity> _jsonParser;

        public IQuestionEntity QuestionEntity
        {
            get
            {
                return CodeType.Dencoding == CodeType ? Decoder() : Encoder();
            }
            set
            {
            }
        }
        public CodeType CodeType { get; set; }

        public FairaCoder(CodeType codeType)
        {
            CodeType = codeType;
            _jsonParser = new JsonParser<QuestionEntity>();
        }

        private IQuestionEntity Encoder()
        {
            return _jsonParser.GetIQuestionEntity(1, 11, "FairaCoder");
        }
        private IQuestionEntity Decoder()
        {
            return _jsonParser.GetIQuestionEntity(11, 21, "FairaCoder");
        }
    }
}
