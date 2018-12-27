using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;
using XTest.Core.Entities;
using System.Linq;

namespace XTest.Core.Processors.Encoders
{


    public interface IEncoder
    {
        IQuestionEntity QuestionEntity { get; set; }

        CodeType CodeType { get; set; }
    }

    public class EllieasCoder : IEncoder
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

        public EllieasCoder(CodeType codeType)
        {
            CodeType = codeType;
        }

        private IQuestionEntity Encoder()
        {

            IQuestionEntity questionEntity = new QuestionEntity();
            questionEntity.QuestionType = QuestionType.Ellieas;
            questionEntity.CodeType = CodeType;

            questionEntity.Description = "Закодируйте сообщение";

            // StringBuilder matrix = new StringBuilder();
            StringBuilder answer = new StringBuilder();

            int[][] matrix = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                int tempSum = 0;
                matrix[i] = new int[5];

                for (int j = 0; j < 5; j++)
                {
                    int randNumber = _random.Next(0, 2);

                    matrix[i][j] = randNumber;

                    tempSum += randNumber;
                }

                answer.Append(tempSum % 2);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                int tempSum = 0;

                for (int j = 0; i < matrix[i].Length; j++)
                {
                    tempSum += matrix[j][i];
                }

                answer.Append(tempSum % 2);
            }

            questionEntity.Answer = new BaseValue()
            { Value = answer.ToString() };

            questionEntity.Question = new MatrixValue()
            {
                Matrix = matrix.Select(p=>p.Select(s=>s.ToString()).ToArray()).ToArray()
            };

            return questionEntity;
        }

        private IQuestionEntity Decoder()
        {
            IQuestionEntity questionEntity = Encoder();

            questionEntity.Description = "Закодируйте сообщение";

            MatrixValue answer = questionEntity.Question as MatrixValue;
            answer.Value = questionEntity.Answer.Value;

            StringBuilder question = new StringBuilder();

            string[][] matrix = answer.Matrix;
          

            for (int i = 0; i < 5; i++)
            {
                int randNumber = _random.Next(1, 5);
                matrix[randNumber][randNumber - 1] =
                    matrix[randNumber][randNumber - 1] == "1" ? "0" : "1";
            }

            questionEntity.Question = new MatrixValue()
            { Matrix = matrix };

            questionEntity.Answer = answer;

            return questionEntity;
        }
    }
}
