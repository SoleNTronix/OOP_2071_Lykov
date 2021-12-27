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
            Point с_point1 = new Point();
            с_point1.X = base.x;
            с_point1.Y = base.y;
            Point с_point2 = new Point();
            с_point2.X = base.x;
            с_point2.Y = base.y - size / 5;
            Point с_point3 = new Point();
            с_point3.X = base.x + size;
            с_point3.Y = base.y - size / 5;
            Point с_point4 = new Point();
            с_point4.X = base.x + size;
            с_point4.Y = base.y;
            Point[] point_mas = new Point[4] {с_point1, с_point2, с_point3, с_point4};            
            coal.DrawCoal(gr, point_mas);      
        }

        public override bool isPointInside(int point_x, int point_y)
        {
            bool isInside = false;
            if (base.isPointInside(point_x, point_y) || coal.isPointInside(point_x, point_y))
            {
                isInside = true;
            }
            return isInside;
        }
        public override void Move(Point point1, Point point2)
        {
            int difX = point2.X - point1.X;
            int difY = point2.Y - point1.Y;
            x += difX;
            y += difY;
        }
    }
}
