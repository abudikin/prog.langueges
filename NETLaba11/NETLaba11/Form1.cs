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

namespace NETLaba11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private XmlTextWriter writer;
		private void create_Click(object sender, EventArgs e)
		{
			writer = new XmlTextWriter(textBox1.Text + ".xml", Encoding.GetEncoding(1251));
			MessageBox.Show("Создано");
		}


		private void add_Click(object sender, EventArgs e)
		{
			if(writer != null)
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("Заказы");

				// coxpaHszem 3aKasH

				writer.WriteStartElement("Заказ");
					writer.WriteAttributeString("Адрес", "Пр. Ленина");
					writer.WriteAttributeString("Дата", "12.04.2013");

					writer.WriteStartElement("Товар");
						writer.WriteAttributeString("Цена", "150");
						writer.WriteAttributeString("Название", "Карандаши");
					writer.WriteEndElement();

				writer.WriteEndElement();

				writer.WriteEndElement();
				writer.WriteEndDocument();

				writer.Close();
				MessageBox.Show("Добавлено");
			} else MessageBox.Show("Файл не был создан");
		}


		private void read_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			XmlTextReader reader = new XmlTextReader(textBox1.Text + ".xml");
			
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element) //ecnu Hammex y3en
				{
					if (reader.HasAttributes) //ecnw y y3ma wmentca atpy6ytTH
					{
						//Uvexve snemexta yana
						richTextBox1.Text += "Элемент: " + reader.Name + "\n";
						
						while (reader.MoveToNextAttribute())
							richTextBox1.Text += " Атрибут: " + reader.Name + ": " + reader.Value + "\n";

						richTextBox1.Text += "\n";
					}
				}
			}
		}
	}
}