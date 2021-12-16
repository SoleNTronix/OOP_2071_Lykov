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
            //gr.DrawRectangle(new Pen(Color.Black), x, y, size, size / 2);
            //gr.DrawEllipse(new Pen(Color.Black), x + size / 10, y + size / 2, size / 5, size / 5);
            //gr.DrawEllipse(new Pen(Color.Black), size + x / 3 - size / 10, y + size / 2, size / 5, size / 5);
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
    }
}
