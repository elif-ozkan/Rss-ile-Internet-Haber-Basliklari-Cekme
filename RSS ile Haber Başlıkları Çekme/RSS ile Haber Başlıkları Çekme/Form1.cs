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

namespace RSS_ile_Haber_Başlıkları_Çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/gundem");
            while (xmloku.Read())
            {
                
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku2 = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml");
            while (xmloku2.Read())
            {
                if(xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku3 = new XmlTextReader("http://www.haberturk.com/rss");
            while (xmloku3.Read())
            {
                if (xmloku3.Name == "title")
                {
                    listBox1.Items.Add(xmloku3.ReadString());
                }
            }
        }
    }
}
