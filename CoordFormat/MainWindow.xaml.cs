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

namespace CoordFormat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal x = Convert.ToDecimal(textBox1.Text);
            decimal y = Convert.ToDecimal(textBox2.Text);

            string xy = (x + " " + y).ToString();
            xy = xy.Replace(',', '.');
            xy = xy.Replace(' ', ',');

            Enter(xy);
        }

        void Enter(string cord)
        {
            var split = cord.Split(',');

            var str1 = split[0].Replace('.', ',');
            var str2 = split[1].Replace('.', ',');

            textBox3.Text = string.Format("X: {0:D}   Y: {1:D}", str1, str2);
            //textBox3.Text = str1;
            //Console.WriteLine("X: {0:D} Y: {1:D}", str1, str2);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
