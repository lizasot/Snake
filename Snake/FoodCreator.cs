using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int width;
        int height;
        char symb;

        Random rand = new Random();

        public FoodCreator(int width, int height, char symb)
        {
            this.width = width;
            this.height = height;
            this.symb = symb;
        }

        public Point Create()
        {
            return new Point(rand.Next(width - 2) + 1, rand.Next(height - 2) + 1, symb);
        }
    }
}
