using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
      
        public VerticalLine( int yTop, int ybottom, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= ybottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
