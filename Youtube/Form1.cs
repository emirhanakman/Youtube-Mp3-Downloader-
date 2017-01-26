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
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Emirhan Akman Facebook Sayfasýna Git.");
            webBrowser1.Navigate("https://www.youtube2mp3.cc/");
            webBrowser1.ScriptErrorsSuppressed = true;
            toolTip2.SetToolTip(monoFlat_TextBox1,"Youtube URL Adresini Buraya Giriniz..");
            toolTip3.SetToolTip(pictureBox3,"Emirhan Akman Github Adresine Git.");
     
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
         
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/EmirHan209");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        void indir()
        {
            label5.Text = "Ýndiriliyor..: ";
            if (monoFlat_TextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Youtube Link Adresini Yazýnýz..", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            webBrowser1.Document.GetElementById("input").InnerText = monoFlat_TextBox1.Text;
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
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/EmirHan209");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
     
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            indir();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            monoFlat_TextBox1.Text = "";
            label5.Text = "Dosya Adý :";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emirhanakman");
        }
    }
}