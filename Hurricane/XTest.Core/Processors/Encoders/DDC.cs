using System;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class DDC : IEncoder
    {

        public static Random _random = new Random();

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

        public DDC(CodeType codeType)
        {
            CodeType = codeType;
        }

        private IQuestionEntity Encoder()
        {
            throw new Exception();
        }
        private IQuestionEntity Decoder()
        {
            throw new Exception();
        }
    }
}
