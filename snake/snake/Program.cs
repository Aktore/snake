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

            Point p3 = new Point(5, 6, '@');
            p3.Draw();

            Point p4 = new Point(7, 8, '&');
            p4.Draw();

            List<int> numLilst = new List<int>();
            numLilst.Add(0);
            numLilst.Add(1);
            numLilst.Add(2);

            int x = numLilst[0];
            int y = numLilst[1];
            int z = numLilst[2];

            foreach(int i in numLilst)
            {
                Console.Write(i);
            }
            numLilst.RemoveAt(1);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> chList = new List<char>(); // создал список который хранит символы
            chList.Add('*');
            chList.Add('#');
            foreach(char c in chList)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
