using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum Direction
    {
        Left,
        Up,
        Right,
        Down
    }
    class Snake : Figure
    {
        Direction direct;
        public Snake(Point tail, int len, Direction direct)
        {
            this.direct = direct;
            pList = new List<Point>();
            for (int i = 0; i < len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direct);
                pList.Add(p);
            }

        }

        public Point GetNextPoint()
        {
            Point p = new Point(1, 1, '*');
            return p;
        }

        internal void Move()
        {
            Point tail = pList.First();
            Point head = GetNextPoint();
        }
    }
}
