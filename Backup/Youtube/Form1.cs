using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
namespace Youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser webBrowser1 = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        /*void agTest()
        {
            Ping ping = new Ping();
            string google = "www.google.com";
            PingReply DonenCevap = ping.Send(google);
            if (DonenCevap.Status == IPStatus.Success)
            {
                this.Text = " |||   Youtube Ýndir ||| - Ýnternet Baðlantýsý Algýlandý !";
            }
            else
            {
                this.Text = " |||   Youtube Ýndir ||| - Ýnternet Baðlantýsý Bulunamadý !";
            }
        }*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (item.GetAttribute("id") == "download")
                {
                    timer1.Stop();
                    item.InvokeMember("click");
                }
            }
        }
        WebBrowser web2 = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            web2.Navigate("https://www.onlinevideoconverter.com/tr/video-converter");
            web2.ScriptErrorsSuppressed = true;
            comboBox1.Items.Add("144p");
            comboBox1.Items.Add("240p");
            comboBox1.Items.Add("360p");
            comboBox1.Items.Add("480p");
            comboBox1.Items.Add("720p HD");
            comboBox1.Items.Add("1080p Full HD");
            toolTip1.SetToolTip(pictureBox2, "Emirhan Akman Facebook Sayfasýna Git.");
            webBrowser1.Navigate("https://www.youtube2mp3.cc/");
            webBrowser1.ScriptErrorsSuppressed = true;
     
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (item.GetAttribute("classname") == "button large orange track download")
                {
                    item.InvokeMember("click");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
         
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
           /* webBrowser1.Document.GetElementById("input").InnerText = textBox1.Text;
            webBrowser1.ScriptErrorsSuppressed = true;
            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (item.GetAttribute("id") == "button")
                {
                    item.InvokeMember("click");
                }
            }//button large orange track download
            timer2.Start();
            timer1.Start();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //timer4.Stop();
           /* if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                label3.Text = "Lütfen Bekleyiniz Sistem Yükleniyor..";
            }
            else
            {
                label3.Text = "Ýndirme Ýþlemini Baþlatabilirsiniz..";
            }*/
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = "";
            label5.Text = "Hazýr.. : ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/EmirHan209");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            indir();
        }
        void indir()
        {
            label5.Text = "Ýndiriliyor..: ";
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Youtube Link Adresini Yazýnýz..", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            webBrowser1.Document.GetElementById("input").InnerText = textBox1.Text;
            webBrowser1.ScriptErrorsSuppressed = true;
            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (item.GetAttribute("id") == "button")
                {
                    item.InvokeMember("click");
                    timer5.Start();
                }

            }
            timer2.Start();
            timer1.Start();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (item.GetAttribute("id") == "converter")
                {
                    label5.Text = "Ýndirilen Ýçeriðin Adý : "+webBrowser1.Document.GetElementById("title").InnerText;
                    timer5.Stop();
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NasilIndiririm indir = new NasilIndiririm();
            indir.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hakkinda hakkinda = new hakkinda();
            hakkinda.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/EmirHan209");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen URL Adres Seçimini ve Kalite Seçeneðini Gözden Geçirin.", "Bir Hata Oluþtu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                web2.Document.GetElementById("texturl").InnerText = textBox2.Text;
                web2.ScriptErrorsSuppressed = true;
                foreach (HtmlElement item in web2.Document.All)
                {
                    if (item.GetAttribute("class") == "video-format")
                    {
                        item.InvokeMember("convert1");
                        
                    }

                }
            }
        }
    }
}