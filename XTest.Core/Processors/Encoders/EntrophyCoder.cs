using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;

namespace XTest.Core.Processors.Encoders
{
    class EntrophyCoder : IEncoder
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

        public EntrophyCoder(CodeType codeType)
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

  
