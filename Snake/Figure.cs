using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var thisPoint in pList)
            {
                foreach (var point in figure.pList)
                {
                    if (thisPoint.IsHit(point))
                        return true;
                }
            }
            return false;
        }
    }
}
