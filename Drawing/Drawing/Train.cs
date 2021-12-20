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
        Wagon body = new Wagon();       
        public int wagons;
        public int GetRndWagon()
        {
            Random rnd = new Random();
            int wag_num = rnd.Next(1, 3);
            return wag_num;
        }
        public void DrawTrainHead(Graphics gr)
        {            
            MyRectangle pipe = new MyRectangle();
            MyRectangle pipeEnd = new MyRectangle();
            body.x = x;
            body.y = y;
            body.size = size;
            body.Draw(gr);
            pipe.height = size/3;
            pipe.width = size/5;
            pipe.x = body.x + body.size / 7;
            pipe.y = body.y-pipe.height;
            pipe.Draw(gr);
            pipeEnd.height = size/4;
            pipeEnd.width = size/4;
            pipeEnd.x = body.x;
            pipeEnd.y = body.y - pipe.height;
        }
        public override void Draw(Graphics gr)
        {
            Point prevLocation = new Point();
            prevLocation.X = x + size + 2;
            prevLocation.Y = body.y;
            DrawTrainHead(gr);
            for (int i = 0; i < wagons; i++)
            {                
                if (GetRndWagon() == 1)
                {
                    Wagon wagonE = new Wagon();
                    wagonE.x = prevLocation.X;
                    wagonE.y = y;
                    wagonE.size = size;
                    wagonE.Draw(gr);
                }
                if(GetRndWagon() == 2)
                {
                    Wagon wagonC = new Wagon();
                    wagonC.x = prevLocation.X;
                    wagonC.y = y;
                    wagonC.size = size;
                    wagonC.Draw(gr);
                }
                if(GetRndWagon() == 3)
                {
                    Wagon wagonS = new Wagon();
                    wagonS.x = prevLocation.X;
                    wagonS.y = y;
                    wagonS.size = size;
                    wagonS.Draw(gr);
                }
                prevLocation.X += size;
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

    }
}
