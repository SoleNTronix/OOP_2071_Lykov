using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    public class MyRectangle: Figure
    {
        public int width;
        public int height;

        public override void Draw(Graphics gr) 
        {
            gr.DrawRectangle(new Pen(Color.Black), x, y, width, height);
        }
        public void DrawCoal(Graphics gr, Point[] points)
        {
            SolidBrush br = new SolidBrush(Color.Black);
            gr.FillPolygon(br, points);
        }
        public override bool isPointInside(int point_x, int point_y)
        {
            
            if (point_x > x && point_x < x + width && point_y > y && point_y < y+height)
            {
                isInside = true;
            }
            return isInside;
        }
        public override Point GetStartPos(Point start)
        {
            return base.GetStartPos(start);
        }
        public override void Move(Point point1, Point point2)
        {
            int difX = point2.X - point1.X;
            int difY = point2.Y- point1.Y;
            x += difX;
            y += difY;
        }
    }
}
