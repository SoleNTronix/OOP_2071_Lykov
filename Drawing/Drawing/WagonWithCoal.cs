using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class WagonWithCoal: Wagon
    {
        MyRectangle coal = new MyRectangle();
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            Point point1 = new Point();
            point1.X = base.x;
            point1.Y = base.y;
            Point point2 = new Point();
            point2.X = base.x;
            point2.Y = base.y - size / 5;
            Point point3 = new Point();
            point3.X = base.x + size;
            point3.Y = base.y - size / 5;
            Point point4 = new Point();
            point4.X = base.x + size;
            point4.Y = base.y;
            Point[] point_mas = new Point[4] {point1, point2, point3, point4};            
            coal.DrawCoal(gr, point_mas);      
        }
        public override bool isPointInside(int point_x, int point_y)
        {
            bool isInside = false;
            if (base.isPointInside(point_x,point_y) || coal.isPointInside(point_x, point_y))
            {
                isInside = true;
            }
            return isInside;
        }
    }
}
