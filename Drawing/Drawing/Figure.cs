using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    public abstract class Figure
    {
        public int x;
        public int y;
        public string type;
        public bool isInside = false;
        public abstract void Draw(Graphics gr);

        public virtual bool isPointInside(int point_x, int point_y)
        {
            return isInside = true;
        }

        public virtual void Move(Point point1, Point point2)
        {

        }

    }
}
