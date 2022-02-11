using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmltext = 
            new XmlTextWriter("C:\\XML\\musteriler.xml",System.Text.UTF8Encoding.UTF8);
            xmltext.WriteComment("Yorum Satırı");
            xmltext.WriteStartElement("Müşteriler");
            xmltext.WriteStartElement("Müşteri");
            xmltext.WriteAttributeString("ID", "1");
            xmltext.WriteElementString("Ad", "hatice");
            xmltext.WriteElementString("Soyad", "deniz");
            xmltext.WriteEndElement();
            xmltext.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlReader dosya = XmlReader.Create(@"C:\XML\musteriler.xml");

            while(dosya.Read())
            {
                //MessageBox.Show(dosya.Name.ToString()+dosya.Value.ToString());
                listBox1.Items.Add(dosya.Name.ToString() +
                    dosya.Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument dosya=new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Ogrenciler",
                new XElement("Ogrenci", 
                new XAttribute("ID","1"),
                new XComment("Yorum satırı"),
                new XElement("ad","hatice"),
                new XElement("soyad", "deniz")))
                );

            dosya.Save("C:\\XML\\ogrenci.xml");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            for (int i = 1; i < 11; i++)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.id = i;
                ogr.ad = FakeData.NameData.GetFirstName();
                ogr.soyad = FakeData.NameData.GetSurname();
                ogrenciler.Add(ogr);

            }

            XDocument dosya = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Ogrenciler", ogrenciler.Select(x => new XElement("Ogrenci",
                new XElement("ID", x.id),
                new XElement("ad", x.ad),
                new XElement("soyad", x.soyad)))));

               dosya.Save("C:\\XML\\ogrenci.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument dosya = XDocument.Load(@"C:\XML\ogrenci.xml");
            List<XElement> liste;
            liste = dosya.Descendants("Ogrenci").ToList();

            foreach (var item in liste)
            {
                listBox1.Items.Add(item.Element("ID").Value
                 + " " + item.Element("ad").Value
                 + " " + item.Element("soyad").Value);

            }
        }
    }
}
