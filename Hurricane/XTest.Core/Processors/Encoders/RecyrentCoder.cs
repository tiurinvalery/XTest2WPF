using System;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    class RecyrentCoder : IEncoder
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

        public RecyrentCoder(CodeType codeType)
        {
            CodeType = codeType;
            _jsonParser = new JsonParser<QuestionEntity>();
        }

        private IQuestionEntity Encoder()
        {
            return _jsonParser.GetIQuestionEntity(1, 11, "RecyrentCoder");
        }
        private IQuestionEntity Decoder()
        {
            return _jsonParser.GetIQuestionEntity(11, 21, "RecyrentCoder");
        }
    }
}
