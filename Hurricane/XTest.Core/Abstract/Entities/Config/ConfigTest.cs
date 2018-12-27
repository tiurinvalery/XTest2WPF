using System.Collections.Generic;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Abstract.Entities.Config
{
   public static class ConfigTest
    {
        public static List<IBaseTestEntity> TestEntities { get; set; } = new List<IBaseTestEntity>();

        static ConfigTest()
        {
            Init();
        }

        private static void Init()
        {
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Эллайеса",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest=5,
                QuestionType = QuestionType.Ellieas
            });

            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Варшамова",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Ellieas
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Коды Рида-Маллера",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.RidaMallera
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Абрамсона",
                GroupType = GroupType.CyclicCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Abramson
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Файра",
                GroupType = GroupType.CyclicCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Faira
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код БЧХ",
                GroupType = GroupType.CyclicCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.BCH
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Первичные недвоичные коды",
                GroupType = GroupType.NonBinaryCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.PrimaryNonDualOnes
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код c простым повторением",
                GroupType = GroupType.NonBinaryCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.EasyReturn
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Итеративный код",
                GroupType = GroupType.NonBinaryCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Iterative
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Грея",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Gray
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Двоично-десятичный код",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.DDC
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Бергера",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Berger
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Шеннона-Фано",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.ShenonPhano
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Хаффмена",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Haphmana
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Количество информации и энтропия",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Entrophy
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Рекурентный код",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Recyrent
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Канальные коды",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Channel
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Циклический код Хемминга",
                GroupType = GroupType.CyclicCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.CycleHemming
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Систематический код Хемминга",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.SystematicHemming
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код с проверкой по модулю q",
                GroupType = GroupType.NonBinaryCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.ModuleCodeQ
            });
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Коды-спутники",
                GroupType = GroupType.OtherСodesAndLaboratoryWork,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Satellite
            });









        }
    }
}
