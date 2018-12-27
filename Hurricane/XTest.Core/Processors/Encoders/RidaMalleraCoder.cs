using System;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class RidaMalleraCoder : IEncoder
    {
        public static Random _random = new Random();
        private JsonParser<MatrixQuestionEntity> _jsonParser;

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

        public RidaMalleraCoder(CodeType codeType)
        {
            CodeType = codeType;
            _jsonParser = new JsonParser<MatrixQuestionEntity>();
        }

        private IQuestionEntity Encoder()
        {
            return _jsonParser.GetIQuestionEntity(1, 4, "RidaMalleraCoder");
        }
        private IQuestionEntity Decoder()
        {
            return _jsonParser.GetIQuestionEntity(4, 7, "RidaMalleraCoder");
        }
    }
}
