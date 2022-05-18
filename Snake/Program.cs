using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            int width = 100;
            int height = 20;

            HorizLine lineTop = new HorizLine(1, 1, width, '#');
            HorizLine lineBottom = new HorizLine(1, height, width, '#');
            VertLine lineLeft = new VertLine(1, 1, height, '#');
            VertLine lineRight = new VertLine(width, 1, height, '#');
            lineTop.Draw();
            lineBottom.Draw();
            lineLeft.Draw();
            lineRight.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 8, Direction.Right);
            snake.Draw();
            snake.Move();

            Console.ReadKey();
        }
    }
}
