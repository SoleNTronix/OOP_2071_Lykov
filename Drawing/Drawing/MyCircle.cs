﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    public class MyCircle: Figure
    {
        public int rad;
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color.Black), x, y, 2 * rad, 2 * rad);
        }
        public override bool isPointInside(int point_x, int point_y)
        {
            if ((Math.Pow(point_x-x - rad,2) + Math.Pow(point_y - y - rad, 2)) <= Math.Pow(rad,2))
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
