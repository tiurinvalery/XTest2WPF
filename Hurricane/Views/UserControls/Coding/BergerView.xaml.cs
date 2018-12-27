using Hurricane.XTest.Core.Abstract;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Abstract.Processors;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;
using Hurricane.XTest.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hurricane.Views.UserControls.Coding
{
    /// <summary>
    /// Логика взаимодействия для BergerView.xaml
    /// </summary>
    public partial class BergerView : UserControl
    {
        private readonly IGenerateProcess _generateProcess;
        private readonly ICollection<IQuestionEntity> _questionEntities;
        private IQuestionEntity _currentQuestionEntity;
        private int number = 1;
        private readonly IAnswerCheker _answerCheker;
        private Grid _grid;

        public BergerView(Grid grid)
        {
            InitializeComponent();
            _grid = grid;
            StaertTest.Click += StaertTest_Click;
            _generateProcess = new GenerateProcess();
            _answerCheker = new AnswerCheker();
            _questionEntities = _generateProcess.GetQuestions(QuestionType.Berger).Data;
            _currentQuestionEntity = _questionEntities.FirstOrDefault(p => p.StateType == StateType.Default);
            DescriptionText.Text = _currentQuestionEntity?.Description;
            QuestionText.Text = _currentQuestionEntity?.Question.Value;
            Number.Text = number.ToString();
            Correct.Text = $"{_questionEntities.Count(p => p.StateType == StateType.Corect)}/{_questionEntities.Count}";
        }

        private void StaertTest_Click(object sender, RoutedEventArgs e)
        {
            StateType stateType = _answerCheker.CheckQuestion(new TestAnswerEntity()
            {
                AllCount = _questionEntities.Count,
                Answer = new BaseValue()
                {
                    Value = Answer.Text
                },
                CurrentCount = number,
                NameTest = QuestionType.Berger.ToString(),
                QuestionEntity = _currentQuestionEntity
            }).Data;
            _currentQuestionEntity = _questionEntities
                .FirstOrDefault(p => p.StateType == StateType.Default);
            Answer.Text = null;
            if (_currentQuestionEntity != null)
            {
                DescriptionText.Text = _currentQuestionEntity?.Description;
                QuestionText.Text = _currentQuestionEntity?.Question.Value;
                number++;
                Number.Text = number.ToString();
                Correct.Text = $"{_questionEntities.Count(p => p.StateType == StateType.Corect)}/{_questionEntities.Count}";
            }
            else
            {
                JsonParser<IQuestionEntity>.SaveList.Clear();
                _grid.Children.Clear();
                _grid.Children.Add(new ResultView(_grid, this));
            }
        }
    }
}
