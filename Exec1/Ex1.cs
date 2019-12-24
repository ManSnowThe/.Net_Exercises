using System;

namespace Exec1
{
   /// <summary>
   /// Класс FormCoordinates
   /// Основной класс, в котором происходит форматирование
   /// в координаты.
   /// </summary>
    class FormCoordinates
    {
        /// <summary>
        /// Main - входная точка для работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Input X and Y coordinates:");

            decimal x = Convert.ToDecimal(Console.ReadLine());
            decimal y = Convert.ToDecimal(Console.ReadLine());

            string xy = (x + " " + y).ToString();
            xy = xy.Replace(',', '.');
            xy = xy.Replace(' ', ',');

            Enter(xy);

            Console.ReadLine();
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
        /// <param name="cord">Принимает строку с координатами</param>
        static void Enter(string cord)
        {
            var split = cord.Split(',');

            var str1 = split[0].Replace('.', ',');
            var str2 = split[1].Replace('.', ',');

            Console.WriteLine("X: {0:D} Y: {1:D}", str1, str2);
        }
    }
}
