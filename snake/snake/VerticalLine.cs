using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine // класс который будет рисовать горизотальную линию
    {
        List<Point> pList;
        public VerticalLine( int yTop, int ybottom, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= ybottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void yDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
