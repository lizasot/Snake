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
        public Direction direction;
        public Snake(Point tail, int len, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direction);
                pList.Add(p);
            }
        }

        public Point GetNextPoint()
        {
            Point p = new Point(pList.Last());
            p.Move(1, direction);
            return p;
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Down;
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                pList.Add(food);
                food.Draw();
                return true;
            }
            return false;
        }
    }
}
