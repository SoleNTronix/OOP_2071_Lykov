using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Wagon: Figure
    {
        public int size;
        MyRectangle body = new MyRectangle();
        MyCircle leftWheel = new MyCircle();
        MyCircle rightWheel = new MyCircle();
        public override void Draw(Graphics gr)
        {
            body.x = this.x;
            body.y = this.y;
            body.width = this.size;
            body.height = this.size / 2;
            body.Draw(gr);
            
            leftWheel.rad = size / 15;
            leftWheel.x = this.x + leftWheel.rad / 3;
            leftWheel.y = this.y + size / 2;
            leftWheel.Draw(gr);

            rightWheel.rad = size / 15;
            rightWheel.x = this.x + size - 2*rightWheel.rad;
            rightWheel.y = this.y + size / 2;
            rightWheel.Draw(gr);
        }

        public override bool isPointInside(int point_x, int point_y)
        {
            bool isInside = false;
            if (body.isPointInside(point_x, point_y) || leftWheel.isPointInside(point_x, point_y) || rightWheel.isPointInside(point_x, point_y))
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
