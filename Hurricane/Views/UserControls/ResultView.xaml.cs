using Hurricane.XTest.Core.Entities.History;
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

namespace Hurricane.Views.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ResultView.xaml
    /// </summary>
    public partial class ResultView : UserControl
    {
        private Grid _grid;
        private UserControl _userControl;

        public ResultView(Grid grid, UserControl userControl)
        {
            InitializeComponent();
            _grid = grid;
            _userControl = _userControl;
            StartTest.Click += StartTest_Click;
            NameTest.Text += MainHistoryEntity.CodingHistorys.Last().NameTest;
            NumberQuestions.Text += MainHistoryEntity.CodingHistorys.Last()
                .TestHistorys.Last().AnswerHistorys.Count;
            NumberCorrectQuestions.Text +=
                MainHistoryEntity.CodingHistorys.Last()
                .TestHistorys.Last().AnswerHistorys.Count(p=>p.IsCorrect);
            TryNumber.Text +=
                      MainHistoryEntity.CodingHistorys.Last()
                .TestHistorys.Count();
        }

        private void StartTest_Click(object sender, RoutedEventArgs e)
        {
            _grid.Children.Clear();
          ///  _grid.Children.Add(_userControl);
        }
    }
}
