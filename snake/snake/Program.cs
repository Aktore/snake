using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine vl = new VerticalLine(0, 28, 0, '*');
            Draw(vl);

            Point p = new Point(10, 10, '*');

            Figure fSnake = new Snake(p, 10, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            snake.Move();

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }
            Console.ReadKey();
        }


        static void Draw(Figure figure)
        {
            figure.Draw();
        }
        
    }
}
