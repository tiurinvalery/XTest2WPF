using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;
using XTest.Core.Abstract.Entities.Config;
using XTest.Core.Abstract.Processors;
using XTest.Core.Entities.Common;
using System.Linq;
using XTest.Core.Const.Enums;
using XTest.Core.Processors.Encoders;

namespace XTest.Core.Processors
{
    public class GenerateProcess : IGenerateProcess
    {       
        private readonly BaseEncoderProcess _baseEncoderProcess;

        public GenerateProcess()
        {
            _baseEncoderProcess = new BaseEncoderProcess();
        }

        public IDataResult<ICollection<IBaseTestEntity>> GetBaseTests()
        {
            IDataResult<ICollection<IBaseTestEntity>> methodResult =
                new DataResult<ICollection<IBaseTestEntity>>();

            methodResult.Data = ConfigTest.TestEntities;
            methodResult.Success = true;

            return methodResult;
        }

        public IDataResult<ICollection<IQuestionEntity>> GetQuestions(QuestionType questionType)
        {
            IDataResult<ICollection<IQuestionEntity>> methodResult =
                new DataResult<ICollection<IQuestionEntity>>();

            IBaseTestEntity baseTest = ConfigTest.TestEntities
                .FirstOrDefault(p => p.QuestionType== questionType);

            if(baseTest==null)
            {
                methodResult.Success = false;

                return methodResult;
            }

            List<IQuestionEntity> questionEntities = new List<IQuestionEntity>();

            switch(baseTest.QuestionType)
            {
                case QuestionType.Ellieas:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest,new EllieasCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new EllieasCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Varshamova:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new VarshamovaCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new VarshamovaCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Abramson:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new AbramsonCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new AbramsonCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.BCH:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new BCHCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new BCHCoder(CodeType.Dencoding)));
                    break;

                case QuestionType.Berger:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new BergerCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new BergerCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Channel:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new ChannelCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new ChannelCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.CycleHemming:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new HemmingCycleCode(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new HemmingCycleCode(CodeType.Dencoding)));
                    break;
                case QuestionType.DDC:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new DDC(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new DDC(CodeType.Dencoding)));
                    break;
                case QuestionType.EasyReturn:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new EasyReturnCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new EasyReturnCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Entrophy:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new EntrophyCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new EntrophyCoder(CodeType.Dencoding)));
                    break;
                //case QuestionType.Faira:
                //    questionEntities.AddRange(_baseEncoderProcess
                //        .GetQuestionsEncoder(baseTest.CountEncodTest, new FairaCoder(CodeType.Encoding)));
                //    questionEntities.AddRange(_baseEncoderProcess
                //             .GetQuestionsEncoder(baseTest.CountDecodTest, new FairaCoder(CodeType.Dencoding)));
                //    break;
                case QuestionType.Gray:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new GrayCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new GrayCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Haphmana:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new HaphmanaCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new HaphmanaCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Iterative:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new IterativeCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new IterativeCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.ModulationCheck:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new ModulationCheckCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new ModulationCheckCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.ModuleCodeQ:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new ModuleCodeQ(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new ModuleCodeQ(CodeType.Dencoding)));
                    break;
                case QuestionType.PrimaryNonDualOnes:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new PrimaryNonDualOnes(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new PrimaryNonDualOnes(CodeType.Dencoding)));
                    break;
                case QuestionType.Recyrent:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new RecyrentCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new RecyrentCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.RidaMallera:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new RidaMalleraCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new RidaMalleraCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Satellite:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new SatelliteСodes(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new SatelliteСodes(CodeType.Dencoding)));
                    break;
                case QuestionType.ShenonPhano:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new ShenonPhanoCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new ShenonPhanoCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.SystematicHemming:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new TheSystematicCodeOfHemming(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new TheSystematicCodeOfHemming(CodeType.Dencoding)));
                    break;
                










            }

            questionEntities.ForEach(p => p.StateType = StateType.Default);

            methodResult.Data = questionEntities;
            methodResult.Success = true;

            return methodResult;

        }

        public IDataResult<string> GetTheotry(string nameTest)
        {
            return null;
        }
    }
}
