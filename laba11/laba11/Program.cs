using System;
using System.Xml;

namespace laba11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (XmlWriter writer = XmlWriter.Create("books.xml"))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("title", "Graphics Programming using GDI+");
                writer.WriteElementString("author", "Mahesh Chand");
                writer.WriteElementString("publisher", "Addison-Wesley");
                writer.WriteElementString("price", "64.95");
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}
