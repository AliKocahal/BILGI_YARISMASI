using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLGİ_YARIŞMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, doğru = 0, yanlış = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            BtnSonraki.Enabled = true;
            ptbDoğru.Enabled = false;
            ptbYanlış.Enabled = false;

            soruno++; // soru no yu 1 arttırır
            label4.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet kaç yılında kurulmuştur";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label1.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "hangisi ege bölgemizde bulunmaz";
                BtnA.Text = "izmir";
                BtnB.Text = "balıkesir";
                BtnC.Text = "aydın";
                BtnD.Text = "manisa";
                label1.Text = "balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "sonkuşlar hangi yazarımıza aittir ";
                BtnA.Text = "sait faik";
                BtnB.Text = "cemal süreya";
                BtnC.Text = "atilla ilhan";
                BtnD.Text = "reşat nuri";
                label1.Text = "sait faik";
                BtnSonraki.Text = "sonuçlar";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("doğru: "+ doğru + "\n" + "yanlış :" + yanlış  );
            }


        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label2.Text = BtnA.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                ptbDoğru.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                ptbYanlış.Visible = true;
            }
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label2.Text = BtnB.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                ptbDoğru.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                ptbYanlış.Visible = true;
            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label2.Text = BtnC.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                ptbDoğru.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                ptbYanlış.Visible = true;
            }
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label2.Text = BtnD.Text;
            if (label1.Text == label2.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                ptbDoğru.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                ptbYanlış.Visible = true;
            }
        }
    }
}
