using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;
using XTest.Core.Entities;

namespace XTest.Core.Processors.Encoders
{
    public class AbramsonCoder : IEncoder
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

        public AbramsonCoder(CodeType codeType)
        {
            CodeType = codeType;
        }

        private IQuestionEntity Encoder()
        {
            IQuestionEntity questionEntity = new QuestionEntity();
            questionEntity.QuestionType = QuestionType.Abramson;
            questionEntity.CodeType = CodeType;

            questionEntity.Description = "Закодируйте сообщение";
            questionEntity.Answer = new BaseValue()
            { Value = "1101010100 \n\n" +
            "Непроводимый полином P1: 11101" };
            questionEntity.Answer = new BaseValue()
            {
                Value = "110101010011010"
            };

            return questionEntity;
        }
        private IQuestionEntity Decoder()
        {
            IQuestionEntity questionEntity = new QuestionEntity();
            questionEntity.QuestionType = QuestionType.Abramson;
            questionEntity.CodeType = CodeType;

            questionEntity.Description = "Закодируйте сообщение";
            questionEntity.Answer = new BaseValue()
            {
                Value = "011010001000110\n\n" +
            "Непроводимый полином P1: 10111"
            };
            questionEntity.Answer = new BaseValue()
            {
                Value = "110101010011010"
            };

            return questionEntity;
        }
    }
}
