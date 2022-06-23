using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls : Figure
    {
        List<Figure> wallList;

        public Walls(int width, int height)
        {
            wallList = new List<Figure>();
            HorizLine lineTop = new HorizLine(0, 0, width, '#');
            HorizLine lineBottom = new HorizLine(0, height, width, '#');
            VertLine lineLeft = new VertLine(0, 0, height, '#');
            VertLine lineRight = new VertLine(width, 0, height, '#');

            wallList.Add(lineTop);
            wallList.Add(lineBottom);
            wallList.Add(lineLeft);
            wallList.Add(lineRight);
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
    }
}
