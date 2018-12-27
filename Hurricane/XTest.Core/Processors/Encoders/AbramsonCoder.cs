using System;
using System.Collections.Generic;
using System.IO;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class AbramsonCoder : IEncoder
    {
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

        public AbramsonCoder(CodeType codeType)
        {
            _jsonParser = new JsonParser<QuestionEntity>();
            CodeType = codeType;
           
        }

        private IQuestionEntity Encoder()
        {
            return _jsonParser.GetIQuestionEntity(1, 11, "AbramsonCoder");
        }
        private IQuestionEntity Decoder()
        {
            return _jsonParser.GetIQuestionEntity(11, 21, "AbramsonCoder");
        }
    }
}
