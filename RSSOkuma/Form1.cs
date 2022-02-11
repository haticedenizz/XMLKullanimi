using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            XMLOku();
        }

        private void XMLOku()
        {
          XDocument kaynak= XDocument.Load(txturl.Text);
          List<XElement> liste = kaynak.Descendants("item").ToList();
            List<Haber> haberlistesi = new List<Haber>();
            foreach (var item in liste)
            {
                Haber h = new Haber();
                h.baslik = item.Element("title").Value;
                h.link = item.Element("link").Value;
                h.aciklama = item.Element("description").Value;
                haberlistesi.Add(h);
            }

            lsthaberler.DataSource = haberlistesi;
        }

        private void lsthaberler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Haber secilenhaber = (Haber)lsthaberler.SelectedItem;
            webBrowser1.DocumentText = secilenhaber.aciklama;
        }
    }
}
