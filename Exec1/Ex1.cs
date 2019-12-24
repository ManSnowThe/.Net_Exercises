using System;

namespace Exec1
{
    class FormCoordinates
    {
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

        static void Enter(string cord)
        {
            var split = cord.Split(',');

            var str1 = split[0].Replace('.', ',');
            var str2 = split[1].Replace('.', ',');

            Console.WriteLine("X: {0:D} Y: {1:D}", str1, str2);
        }
    }
}
