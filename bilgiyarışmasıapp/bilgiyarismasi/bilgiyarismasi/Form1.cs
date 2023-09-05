using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;


        private void btnSonraki_Click(object sender, EventArgs e)
        {
          

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;

            lblSoru.Text=soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "APPLE  ";
                btnA.Text = "PORTAKAL";
                btnB.Text = "MUZ";
                btnC.Text = "BULUT";
                btnD.Text = "ELMA";
                label2.Text = "ELMA";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "PEN";
                btnA.Text = "SARI";
                btnB.Text = "KALEM";
                btnC.Text = "KEDİ";
                btnD.Text = "ÇİÇEK";
                label2.Text = "KALEM";

            }


            if (soruno == 3)
            {
                richTextBox1.Text = " TROUSER";
                btnA.Text = "AYAKKABI";
                btnB.Text = "PEÇETE";
                btnC.Text = "PANTOLon";
                btnD.Text = "KAZAK";
                label2.Text = "PANTOLON";
                btnSonraki.Text = "SONUÇLAR";
            }
            if(soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru : " + dogru +" \n "+"Yanlış : "+yanlis);

            }

        }



        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

           


            label3.Text=btnA.Text;

            if(label2.Text==label3.Text)
            {
                dogru++;
                lblDogru.Text= dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text= yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

      
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label3.Text = btnB.Text;

            if (label2.Text == label3.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label3.Text = btnC.Text;

            if (label2.Text == label3.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label3.Text = btnD.Text;

            if (label2.Text == label3.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }


    }
}
