using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizLine : Figure
    {
        public HorizLine(int x, int y, int len, char symb)
        {
            pList = new List<Point>();
            for (int i = x; i <= len + x; i++)
            {
                Point p = new Point(i, y, symb);
                pList.Add(p);
            }
        }
    }
}
