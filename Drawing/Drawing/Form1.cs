using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        FiguresContainer container = new FiguresContainer();
        Graphics gr;
        Point StartPoint;
        public Form1()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
            container.FromXml("Data.xml");
            foreach (Figure figure in container.objects)
            {
                figure.Draw(gr);
            }
        }

        

        private void B_clear_Click(object sender, EventArgs e)
        {    
            gr.Clear(Color.White);
            container.objects.Clear();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (rbRect.Checked)
                {
                    MyRectangle rect = new MyRectangle();

                    rect.x = e.X;
                    rect.y = e.Y;
                    rect.type = "Rect";
                    if(rect_w.Text == "" && rect_h.Text == "")
                    {
                        rect_w.Text = "70";
                        rect_h.Text = "70";                       
                    }
                    rect.width = Convert.ToInt32(rect_w.Text);
                    rect.height = Convert.ToInt32(rect_h.Text);
                    rect.Draw(gr);
                    container.objects.Add(rect);
                }
                else if (rbCircle.Checked)
                {
                    MyCircle circle = new MyCircle();

                    circle.x = e.X;
                    circle.y = e.Y;
                    circle.type = "Circ";
                    if (circ_r.Text == "")
                    {
                        circ_r.Text = "30";
                    }
                    circle.rad = Convert.ToInt32(circ_r.Text);

                    circle.Draw(gr);
                    container.objects.Add(circle);
                }
                else if (rbWagon.Checked)
                {
                    if (rbWagonE.Checked)
                    {
                        Wagon wagonE = new Wagon();

                        wagonE.x = e.X;
                        wagonE.y = e.Y;
                        wagonE.type = "WagE";
                        if (wag_s.Text == "")
                        {
                            wag_s.Text = "300";
                        }
                        wagonE.size = Convert.ToInt32(wag_s.Text);

                        wagonE.Draw(gr);
                        container.objects.Add(wagonE);
                    }
                    else if (rbWagonC.Checked)
                    {
                        WagonWithCoal wagonC = new WagonWithCoal();

                        wagonC.x = e.X;
                        wagonC.y = e.Y;
                        wagonC.type = "WagC";
                        if (wag_s.Text == "")
                        {
                            wag_s.Text = "300";
                        }
                        wagonC.size = Convert.ToInt32(wag_s.Text);

                        wagonC.Draw(gr);
                        container.objects.Add(wagonC);
                    }
                    else if (rbWagonS.Checked)
                    {
                        WagonWithSand wagonS = new WagonWithSand();

                        wagonS.x = e.X;
                        wagonS.y = e.Y;
                        wagonS.type = "WagS";
                        if (wag_s.Text == "")
                        {
                            wag_s.Text = "300";
                        }
                        wagonS.size = Convert.ToInt32(wag_s.Text);

                        wagonS.Draw(gr);
                        container.objects.Add(wagonS);
                    }
                    
                }
                else if (rbTrain.Checked)
                {
                    Train train = new Train();

                    train.x = e.X;
                    train.y = e.Y;
                    train.type = "Train";
                    if (wag_s.Text == "")
                    {
                        wag_s.Text = "150";
                    }
                    if (wgCnt.Text == "")
                    {
                        wgCnt.Text = "3";
                    }
                    train.size = Convert.ToInt32(wag_s.Text);
                    train.wagons = Convert.ToInt32(wgCnt.Text);
                    train.Draw(gr);
                    container.objects.Add(train);
                }

            }

            if(e.Button == MouseButtons.Middle)
            {
                foreach(Figure figure in container.objects)
                {
                    if (figure.isPointInside(e.X, e.Y))
                    {
                        container.objects.Remove(figure);
                        break;
                    }
                }
                panel1.Refresh();
                foreach (Figure figure in container.objects)
                {
                    figure.Draw(gr);
                }
            }

            if (e.Button == MouseButtons.Right)
            {                
                foreach (Figure figure in container.objects)
                {
                    if(figure.isPointInside(e.X, e.Y))
                    {
                        moveFigure = figure;
                        StartPoint = e.Location;
                        break;
                    }
                }                
            }
            Invalidate();            
        }
        Figure moveFigure = null;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && moveFigure != null)
            {
                Point end = new Point();
                end.X = e.X - StartPoint.X;
                end.Y = e.Y - StartPoint.Y;
                moveFigure.Move(StartPoint, e.Location);
                moveFigure.isInside = false;
                panel1.Refresh();
                foreach (Figure figure in container.objects)
                {
                    figure.Draw(gr);
                }
                moveFigure = null;
            }
        }

        private void bWD_Click(object sender, EventArgs e)
        {
            container.ToXml("Data.xml");
        }
    }
}
