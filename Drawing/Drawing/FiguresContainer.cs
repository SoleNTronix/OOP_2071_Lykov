using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

namespace Drawing
{
    class FiguresContainer
    {
        public List<Figure> objects = new List<Figure>();
        public void ToXml(string filename) //Ошибка
        {
            XmlWriter writer = XmlWriter.Create(filename);
            writer.WriteStartDocument();
            writer.WriteStartElement("Figures");
            foreach (Figure figure in objects)
            {
                writer.WriteStartElement("Figure");
                writer.WriteAttributeString("type", Convert.ToString(figure.type));
                if (figure.type == "Rect")
                {
                    MyRectangle rect = (MyRectangle)figure;
                    writer.WriteAttributeString("width", Convert.ToString(rect.width));
                    writer.WriteAttributeString("height", Convert.ToString(rect.height));
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }
                else if (figure.type == "Circ")
                {
                    MyCircle circ = (MyCircle)figure;
                    writer.WriteAttributeString("rad", Convert.ToString(circ.rad));
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }
                else if (figure.type == "WagE")
                {
                    Wagon wagon = (Wagon)figure;
                    writer.WriteAttributeString("size", Convert.ToString(wagon.size));
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }
                else if (figure.type == "WagC")
                {
                    WagonWithCoal wagon = (WagonWithCoal)figure;
                    writer.WriteAttributeString("size", Convert.ToString(wagon.size));
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }
                else if (figure.type == "WagS")
                {
                    WagonWithSand wagon = (WagonWithSand)figure;
                    writer.WriteAttributeString("size", Convert.ToString(wagon.size));
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }
                else if (figure.type == "Train")
                {
                    Train train = (Train)figure;
                    writer.WriteAttributeString("size", Convert.ToString(train.size));                    
                    writer.WriteAttributeString("wgCnt", Convert.ToString(train.wagons));                    
                    writer.WriteAttributeString("x", Convert.ToString(figure.x));
                    writer.WriteAttributeString("y", Convert.ToString(figure.y));
                }                
            }            
        }
        public void FromXml(string filename)
        {
            XmlReader reader = XmlReader.Create(filename);
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Figure"))
                {
                    if (reader.HasAttributes)
                    {
                        if (reader.GetAttribute("type") == "Rect")
                        {
                            MyRectangle rect = new MyRectangle();
                            rect.type = "Rect";
                            rect.width = Convert.ToInt32(reader.GetAttribute("width"));
                            rect.height = Convert.ToInt32(reader.GetAttribute("height"));
                            rect.x = Convert.ToInt32(reader.GetAttribute("x"));
                            rect.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(rect);
                        }
                        if (reader.GetAttribute("type") == "Circ")
                        {
                            MyCircle circ = new MyCircle();
                            circ.type = "Circ";
                            circ.rad = Convert.ToInt32(reader.GetAttribute("rad"));
                            circ.x = Convert.ToInt32(reader.GetAttribute("x"));
                            circ.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(circ);
                        }
                        if (reader.GetAttribute("type") == "WagE")
                        {
                            Wagon wagon = new Wagon();
                            wagon.type = "WagE";
                            wagon.size = Convert.ToInt32(reader.GetAttribute("size"));
                            wagon.x = Convert.ToInt32(reader.GetAttribute("x"));
                            wagon.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(wagon);
                        }
                        if (reader.GetAttribute("type") == "WagC")
                        {
                            WagonWithCoal wagon = new WagonWithCoal();
                            wagon.type = "WagC";
                            wagon.size = Convert.ToInt32(reader.GetAttribute("size"));
                            wagon.x = Convert.ToInt32(reader.GetAttribute("x"));
                            wagon.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(wagon);
                        }
                        if (reader.GetAttribute("type") == "WagS")
                        {
                            WagonWithSand wagon = new WagonWithSand();
                            wagon.size = Convert.ToInt32(reader.GetAttribute("size"));
                            wagon.x = Convert.ToInt32(reader.GetAttribute("x"));
                            wagon.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(wagon);
                        }
                        if (reader.GetAttribute("type") == "Train")
                        {
                            Train train = new Train();
                            train.size = Convert.ToInt32(reader.GetAttribute("size"));
                            train.wagons = Convert.ToInt32(reader.GetAttribute("wgCnt"));
                            train.x = Convert.ToInt32(reader.GetAttribute("x"));
                            train.y = Convert.ToInt32(reader.GetAttribute("y"));
                            objects.Add(train);
                        }                        
                    }
                }
            }
        }
    }
}
