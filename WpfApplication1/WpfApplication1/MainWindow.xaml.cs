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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clear2Btn_Click(object sender, RoutedEventArgs e)
        {
            WeightBox.Text = "0";
        }

        private void Clear1Btn_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Answer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void HeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double h = double.Parse(HeightBox.Text) / 100;
            double w = double.Parse(WeightBox.Text);
            double bmi = w / (h * h);

            Answer.Text = bmi.ToString();
            HeightBox.Text = HeightBar.Value.ToString();            
        }

        private void WeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double h = double.Parse(HeightBox.Text) / 100;
            double w = double.Parse(WeightBox.Text);
            double bmi = w / (h * h);

            Answer.Text = bmi.ToString();
            WeightBox.Text = WeightBar.Value.ToString();
        }
    }
}
