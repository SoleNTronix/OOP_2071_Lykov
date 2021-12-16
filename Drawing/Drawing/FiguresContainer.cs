using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Drawing
{
    class FiguresContainer
    {
        public List<Figure> objects = new List<Figure>();

        public void ToXml(string filename)
        {
            XmlWriter writer = XmlWriter.Create(filename);
            writer.WriteStartDocument();
            writer.WriteStartElement("Figures");
            foreach (Figure figure in objects)
            {
                writer.WriteStartElement("Figure");
                writer.WriteAttributeString("x", Convert.ToString(figure.x));
                writer.WriteAttributeString("y", Convert.ToString(figure.y));
                writer.WriteAttributeString("type", Convert.ToString(figure.type));
                if (figure.type == "Rect")
                {
                    //writer.WriteAttributeString("width", Convert.ToString((MyRectangle)figure.));
                }

                    
            }
             //Спросить по поводу задания записываемых значений
            
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
                        reader.GetAttribute("x");
                        reader.GetAttribute("y");
                        if (reader.GetAttribute("type") == "Rect")
                        {
                            reader.GetAttribute("width");
                            reader.GetAttribute("height");
                        }
                        if (reader.GetAttribute("type") == "Circ")
                        {
                            reader.GetAttribute("rad");
                        }
                        if (reader.GetAttribute("type") == "Wag")
                        {
                            reader.GetAttribute("size");
                        }
                        
                    }
                        

                }
            }
        }
    }
}
