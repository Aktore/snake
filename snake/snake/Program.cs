using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(2, 4, '#');
            p2.Draw();

            HorizontalLine HorLine = new HorizontalLine(5, 10, 8, '-');
            HorLine.xDraw();

            VerticalLine VerLine = new VerticalLine(12, 18, 12, '+');
            VerLine.yDraw();
            Console.ReadKey();
        }
    }
}
