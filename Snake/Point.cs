using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        public void Move(int dist, Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    x += -dist;
                    break;

                case Direction.Up:
                    y += -dist;
                    break;

                case Direction.Right:
                    x += dist;
                    break;

                case Direction.Down:
                    y += dist;
                    break;
            }
        }
        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }

        public bool IsHit(Point point)
        {
            return x == point.x && y == point.y;
        }
    }
}
