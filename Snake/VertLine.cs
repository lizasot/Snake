using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine : Figure
    {
        public VertLine(int x, int y, int len, char symb)
        {
            pList = new List<Point>();
            for (int i = y; i < len + y; i++)
            {
                Point p = new Point(x, i, symb);
                pList.Add(p);
            }
        }
    }
}
