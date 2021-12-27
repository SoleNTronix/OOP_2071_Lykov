using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class WagonWithSand: Wagon
    {
        Point point1;
        Point point2;
        Point point3;
        Point[] point_mas;
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            point1 = new Point();
            point1.X = base.x;
            point1.Y = base.y;
            point2 = new Point();
            point2.X = base.x + size / 2;
            point2.Y = base.y - size / 5;
            point3 = new Point();
            point3.X = base.x + size;
            point3.Y = base.y;
            point_mas = new Point[] { point1, point2, point3 };

            SolidBrush br = new SolidBrush(Color.SandyBrown);
            gr.FillPolygon(br, point_mas);
        }

        public override bool isPointInside(int point_x, int point_y)
        {
            point1 = new Point();
            point1.X = base.x;
            point1.Y = base.y;
            point2 = new Point();
            point2.X = base.x + size / 2;
            point2.Y = base.y - size / 5;
            point3 = new Point();
            point3.X = base.x + size;
            point3.Y = base.y;

            bool isInside = false;
            int a = (point1.X - point_x) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - point_y);
            int b = (point2.X - point_x) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - point_y);
            int c = (point3.X - point_x) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - point_y);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0) || base.isPointInside(point_x, point_y))
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
