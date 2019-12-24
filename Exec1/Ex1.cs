using System;

namespace Exec1
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X и Y координаты:");

            decimal x = Convert.ToDecimal(Console.ReadLine());
            decimal y = Convert.ToDecimal(Console.ReadLine());

            string xy = (x + " " + y).ToString();
            xy = xy.Replace(',', '.');
            xy = xy.Replace(' ', ',');

            //Console.WriteLine(xy);
            Enter(xy);
        }

        static void Enter(string cord)
        {
            var split = cord.Split(',');

            var str1 = split[0].Replace('.', ',');
            var str2 = split[1].Replace('.', ',');

            Console.WriteLine("X: {0} Y: {1}", str1, str2);
        }
    }
}
