using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Entities.History;
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
    /// Логика взаимодействия для BaseView.xaml
    /// </summary>
    public partial class BaseView : UserControl
    {
        private Grid _currentGrid;
        public BaseView(string name,Grid currentGrid)
        {
            InitializeComponent();
            NameTest.Text = name;
            var temp = MainHistoryEntity.CodingHistorys?.FirstOrDefault(p => p.NameTest ==
                name);
            DateTest.Text += temp?.TestHistorys?.Last()?.CreateTiem.Date;
            BestMark.Text+= temp?.TestHistorys?.Max(p=>p.Mark)??0;
            Try.Text +=
                   temp?
              .TestHistorys?.Count()??0;
            _currentGrid = currentGrid;
            StaertTest.Click += StaertTest_Click;
        }

        private void StaertTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentGrid.Children.Clear();
                JsonParser<IQuestionEntity>.SaveList.Clear();
                if (NameTest.Text.ToLower().Equals("Abramson".ToLower()))
                {

                    _currentGrid.Children.Add(new AbramsoneView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("BCH".ToLower()))
                {
                    _currentGrid.Children.Add(new BCHView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Haffman".ToLower()))
                {
                    _currentGrid.Children.Add(new HaphmanaView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Ellieas".ToLower()))
                {
                    _currentGrid.Children.Add(new EllieasCoderView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("DDC".ToLower()))
                {
                    _currentGrid.Children.Add(new DDCView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Berger".ToLower()))
                {
                    _currentGrid.Children.Add(new BergerView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Recurent".ToLower()))
                {
                    _currentGrid.Children.Add(new RecyrentView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Systematic".ToLower()))
                {
                    _currentGrid.Children.Add(new SystematicHemmingView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("CyclicHemming".ToLower()))
                {
                    _currentGrid.Children.Add(new CycleHemmingView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Faira".ToLower()))
                {
                    _currentGrid.Children.Add(new FairaView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("PrimaryNonDouble".ToLower()))
                {
                    _currentGrid.Children.Add(new PrimaryNonDualOnesView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("CheckQ".ToLower()))
                {
                    _currentGrid.Children.Add(new ModuleCodeQView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("EasyReturt".ToLower()))
                {
                    _currentGrid.Children.Add(new EasyReturnView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Greu".ToLower()))
                {
                    _currentGrid.Children.Add(new GrayView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Iterative".ToLower()))
                {
                    _currentGrid.Children.Add(new IterativeCoderView(_currentGrid));
                }
                else if (NameTest.Text.ToLower().Equals("Code Rida-Mallera".ToLower()))
                {
                    _currentGrid.Children.Add(new RidaMalleraView(_currentGrid));
                }
            }
            catch { }

        }

    
    }
}
