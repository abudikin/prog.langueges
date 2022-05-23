using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(textBox1.Text + ".xml");
            if (textBox1.Text.Length != 0) 
            {
                richTextBox1.Clear();
                while (reader.Read())
            {
                if (reader.NodeType==XmlNodeType.Element)
                {
                    if (reader.HasAttributes)
                    {
                        richTextBox1.Text += "Элемент: " + reader.Name + "\n";
                        while (reader.MoveToNextAttribute())
                        {
                            richTextBox1.Text += "Атрибут: " + reader.Name + ": " + reader.Value + "\n";

                            }
                        richTextBox1.Text += "\n";
                    }
                }
            }
            textBox1.Clear();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                XmlTextWriter writer = new XmlTextWriter(textBox1.Text + ".xml", Encoding.GetEncoding(1251));
                writer.WriteStartDocument();
                writer.WriteStartElement("Продукты");
                writer.WriteStartElement("Продукт");
                writer.WriteAttributeString("Цена", "250");
                writer.WriteAttributeString("Название", "Coca-Cola");

                writer.WriteStartElement("Продукт");
                writer.WriteAttributeString("Цена", "50");
                writer.WriteAttributeString("Название", "Dirol");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show(textBox1.Text + ".xml успешно добавлен");
                textBox1.Clear();
            }
            else MessageBox.Show("Заполните поле");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("as.xml");

            XmlNode root = document.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name== "Продукт")
                {
                    XmlElement elem = document.CreateElement("Продукт");
                    node.AppendChild(elem);

                   

                    XmlAttribute attribute2 = document.CreateAttribute("Цена");
                    attribute2.Value = "40";
                    elem.Attributes.Append(attribute2);

                    XmlAttribute attribute1 = document.CreateAttribute("Название");
                    attribute1.Value = "as";
                    elem.Attributes.Append(attribute1);
                }
            }
            document.Save("test.xml");
        }
    }
}
