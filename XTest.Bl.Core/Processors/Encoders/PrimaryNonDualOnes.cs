﻿using System;
using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Processors.Encoders
{
    public class PrimaryNonDualOnes : IEncoder
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

        public PrimaryNonDualOnes(CodeType codeType)
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
