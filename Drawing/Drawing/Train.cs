using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Drawing
{   
    class Train: Wagon
    {
        private const int spaceBetween = 2;
        Wagon trainHead = new Wagon();
        MyRectangle pipe = new MyRectangle();
        public int wagons;
        enum RndWagon
        {
            Empty,
            Coal,
            Sand
        }
        public int GetRndWagon()
        {
            Random rnd = new Random();
            int wag_num = rnd.Next(1, 3);
            return wag_num;
        }
        public void DrawTrainHead(Graphics gr)
        {            
            trainHead.x = x;
            trainHead.y = y;
            trainHead.size = size;
            trainHead.Draw(gr);
            pipe.height = size / 3;
            pipe.width = size / 5;
            pipe.x = trainHead.x + trainHead.size / 7;
            pipe.y = trainHead.y - pipe.height;
            pipe.Draw(gr);
        }
        public override void Draw(Graphics gr)
        {
            Point prevLocation = new Point();
            prevLocation.X = x + size + spaceBetween;
            DrawTrainHead(gr);
            for (int i = 0; i < wagons; i++)
            {            
                if (GetRndWagon() == Convert.ToInt32(RndWagon.Empty))
                {
                    Wagon wagonE = new Wagon();
                    wagonE.x = prevLocation.X;
                    wagonE.y = y;
                    wagonE.size = size;
                    wagonE.Draw(gr);
                }
                else if(GetRndWagon() == Convert.ToInt32(RndWagon.Coal))
                {
                    WagonWithCoal wagonC = new WagonWithCoal();
                    wagonC.x = prevLocation.X;
                    wagonC.y = y;
                    wagonC.size = size;
                    wagonC.Draw(gr);
                }
                else if(GetRndWagon() == Convert.ToInt32(RndWagon.Sand))
                {
                    WagonWithSand wagonS = new WagonWithSand();
                    wagonS.x = prevLocation.X;
                    wagonS.y = y;
                    wagonS.size = size;
                    wagonS.Draw(gr);
                }
                prevLocation.X += size + spaceBetween;
            }
        }

        public override void Move(Point point1, Point point2)
        {
            base.Move(point1, point2);
            int difX = point2.X - point1.X;
            int difY = point2.Y - point1.Y;
            x += difX;
            y += difY;
        }
        public override bool isPointInside(int point_x, int point_y)
        {
            bool pointIsInside = false;
            if (trainHead.isPointInside(point_x, point_y) || pipe.isPointInside(point_x, point_y))
            {
                pointIsInside = true;
            }
            return pointIsInside;
        }

    }
}
