using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void CreateField(int width, int height, out HorizLine lineTop, out HorizLine lineBottom, out VertLine lineLeft, out VertLine lineRight)
        {
            lineTop = new HorizLine(0, 0, width, '#');
            lineBottom = new HorizLine(0, height, width, '#');
            lineLeft = new VertLine(0, 0, height, '#');
            lineRight = new VertLine(width, 0, height, '#');
        }
        static void DrawField(HorizLine lineTop, HorizLine lineBottom, VertLine lineLeft, VertLine lineRight)
        {
            lineTop.Draw();
            lineBottom.Draw();
            lineLeft.Draw();
            lineRight.Draw();
        }
        static void Main(string[] args)
        {
            int width = 100;
            int height = 20;
            Console.CursorVisible = false;
            CreateField(width, height, out HorizLine lineTop, out HorizLine lineBottom, out VertLine lineLeft, out VertLine lineRight);
            DrawField(lineTop, lineBottom, lineLeft, lineRight);

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 8, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(width, 20, '$');
            Point food = foodCreator.Create();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.Create();
                    food.Draw();
                }
                snake.Move();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
            }
        }
    }
}
