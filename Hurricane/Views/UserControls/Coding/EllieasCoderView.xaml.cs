﻿using Hurricane.XTest.Core.Abstract;
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
    /// Логика взаимодействия для EllieasCoderView.xaml
    /// </summary>
    public partial class EllieasCoderView : UserControl
    {
        private readonly IGenerateProcess _generateProcess;
        private readonly ICollection<IQuestionEntity> _questionEntities;
        private IQuestionEntity _currentQuestionEntity;
        private int number = 1;
        private readonly IAnswerCheker _answerCheker;
        private Grid _grid;
        private List<TextBox> _textAnswer;

        public EllieasCoderView(Grid grid)
        {
            InitializeComponent();
            _grid = grid;
            _textAnswer = new List<TextBox>();
            StaertTest.Click += StaertTest_Click;
            _generateProcess = new GenerateProcess();
            _answerCheker = new AnswerCheker();
            _questionEntities = _generateProcess.GetQuestions(QuestionType.Ellieas).Data;
            _currentQuestionEntity = _questionEntities.FirstOrDefault(p => p.StateType == StateType.Default);
            DescriptionText.Text = _currentQuestionEntity?.Description;
            InitMatrix();
            Number.Text = number.ToString();
            Correct.Text = $"{_questionEntities.Count(p => p.StateType == StateType.Corect)}/{_questionEntities.Count}";
        }

        private void StaertTest_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var s in _textAnswer)
            {
                sb.Append(s.Text);
            }
            StateType stateType = _answerCheker.CheckQuestion(new TestAnswerEntity()
            {
                AllCount = _questionEntities.Count,
                Answer = new BaseValue()
                {
                    Value = sb.ToString()
                },
                CurrentCount = number,
                NameTest = QuestionType.Abramson.ToString(),
                QuestionEntity = _currentQuestionEntity
            }).Data;
            _currentQuestionEntity = _questionEntities
                .FirstOrDefault(p => p.StateType == StateType.Default);
          
            if (_currentQuestionEntity != null)
            {
                InitMatrix();
                DescriptionText.Text = _currentQuestionEntity?.Description;

                number++;
                Number.Text = number.ToString();
                Correct.Text = $"{_questionEntities.Count(p => p.StateType == StateType.Corect)}/{_questionEntities.Count}";
            }
            else
            {
                _grid.Children.Clear();
                _grid.Children.Add(new ResultView(_grid, this));
            }
        }

        private void InitMatrix()
        {
            MatrixValue matrix = (MatrixValue)_currentQuestionEntity.Question;
            if (QuestionMatrix.Children.Count == 0)
            {
                for (int i = 0; i < matrix.Matrix.Length + 1; i++)
                {
                    QuestionMatrix.RowDefinitions.Add(new RowDefinition()
                    { Height = new GridLength(1, GridUnitType.Star) });
                    QuestionMatrix.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(1, GridUnitType.Star)
                    });
                }
            }
            else
            {
                _textAnswer.Clear();
                QuestionMatrix.Children.Clear();
            }

            for (int i = 0; i < matrix.Matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Matrix[i].Length; j++)
                {

                    TextBlock textBlock = new TextBlock();
                    textBlock.IsEnabled = false;
                    textBlock.Margin = new Thickness(5);
                    textBlock.FontSize = 17;
                    textBlock.Text = matrix.Matrix[i][j];
                    QuestionMatrix.Children.Add(textBlock);
                  
                    Grid.SetRow(textBlock, i);
                    Grid.SetColumn(textBlock, j);
                }
            }

            for (int i = 0; i < matrix.Matrix.Length+1; i++)
            {
                for (int j = 0; j < matrix.Matrix.Length + 1; j++)
                {
                    if (i != j && (matrix.Matrix.Length==i || matrix.Matrix.Length == j))
                    {
                        TextBox textBlock = new TextBox();
                    
                        textBlock.Margin = new Thickness(5);
                        textBlock.FontSize = 17;
                        textBlock.Text = "0";
                        QuestionMatrix.Children.Add(textBlock);
                        _textAnswer.Add(textBlock);
                        Grid.SetRow(textBlock, i);
                        Grid.SetColumn(textBlock, j);
                    }
                }
            }


        }
    }
}