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
    /// Частичный класс MainWindow, наследует от Window.
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Метод MainWindow вызывает WPF окно.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод Button_Click добавляющий событие Click.
        /// После того как в textBox1 и textBox2 введены числа,
        /// нажатие этой кнопка форматирует их в координаты в textBox3.
        /// </summary>
        /// <param name="sender">Объект, который вызывает событие</param>
        /// <param name="e">Передает информацию обработчика</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal x = Convert.ToDecimal(textBox1.Text);
            decimal y = Convert.ToDecimal(textBox2.Text);

            string xy = (x + " " + y).ToString();
            xy = xy.Replace(',', '.');
            xy = xy.Replace(' ', ',');

            Enter(xy);
        }

        /// <summary>
        /// Метод Enter используется для вывода значений,
        /// форматируя их в нужный вид.
        /// <exampe>
        /// <code>
        /// string str = "6.1245,7.341";
        /// Enter(str);
        /// </code>
        /// Результат будет X:6,1245 Y=7,341
        /// </exampe>
        /// </summary>
        /// <param name="cord"></param>
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
