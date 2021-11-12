using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        TextBox[,] txtBoxGrp1;
        TextBox[,] txtBoxGrp2;
        TextBox[,] txtBoxGrp3;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {

            prepareText();
            

            flag = true;
        }
        private void prepareText()
        {
            
            txtBoxGrp1 = new TextBox[10, 10];
            txtBoxGrp2 = new TextBox[10, 10];
            txtBoxGrp3 = new TextBox[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    txtBoxGrp1[i, y] = new TextBox();
                    txtBoxGrp1[i, y].Size = new Size(20, 20);
                    txtBoxGrp1[i, y].Location = new Point((y * 20) + 5, (i * 20) + 15);
                    //txtBoxGrp1[i, y].Text = Convert.ToString(i) + " " + Convert.ToString(y);
                    gbMatris1.Controls.Add(txtBoxGrp1[i, y]);

                    txtBoxGrp2[i, y] = new TextBox();
                    txtBoxGrp2[i, y].Size = new Size(20, 20);
                    txtBoxGrp2[i, y].Location = new Point((y * 20) + 5, (i * 20) + 15);
                    gbMatris2.Controls.Add(txtBoxGrp2[i, y]);

                    txtBoxGrp3[i, y] = new TextBox();
                    txtBoxGrp3[i, y].Size = new Size(20, 20);
                    txtBoxGrp3[i, y].Location = new Point((y * 20) + 5, (i * 20) + 15);
                    gbMatris3.Controls.Add(txtBoxGrp3[i, y]);
                }
            }
            //textclear(txtBoxGrp1);
        }
        private void textclear(TextBox [,] tb)
        {
            foreach (var item in tb)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                
            }
        }   
            private void textclear(Control c)
            {
                foreach (Control item in c.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                    if (item.Controls.Count > 0)
                    {
                        textclear(item);
                    }
                }
            
            /* 
            textclear(txtBoxGrp3);
            textclear(txtBoxGrp2);
            textclear(txtBoxGrp1); */
        }

        Matris m1;
        Matris m2;
        Matris m3;
        Matris gecici;

        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;
        int x3 = 0;
        int y3 = 0;

        private void btnTopla_Click(object sender, EventArgs e)
        {
            flag= boyut_kontrol("+");
            
            if (flag)
            {
                // Matris m1 = new Matris(10, 10);


                yazMatris(m1, txtBoxGrp1,x1,y1);
                m1 = m1 * Convert.ToInt32(tbKatsayiM1.Text);
                yazMatris(m2, txtBoxGrp2,x2,y2);
                m2 = m2 * Convert.ToInt32(tbKatsayiM2.Text);
                m3 = m1 + m2;

                okuMatris(txtBoxGrp3, m3);

                //m1[0, 0] = int.Parse(txtBoxGrp1[0, 0].Text);  // matris elemanlerına değer atama
                //txtBoxGrp2[9, 8].Text = m1[9, 8].ToString();   // matris elemanlarını okuma
            }
        }


        static bool sayi(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool boyut_kontrol(String islem)
        {
            for (int i = 9; i >-1; i--)
            {
                if (txtBoxGrp1[0, i].Text == "")  { y1 = i; }
                if (txtBoxGrp2[0, i].Text == "")  { y2 = i; }
                if (txtBoxGrp1[i, 0].Text == "")  { x1 = i; }
                if (txtBoxGrp2[i, 0].Text == "")  { x2 = i; }
            }
            //MessageBox.Show(string.Format("x1: {0} x2: {1} y1 {2} y2 {3} ",x1, x2, y1, y2));

            bool durum = false;
            switch (islem)
            {
                case "+":
                    if ((x1 == x2) & (y1 == y2)) { durum = true; x3 = x1; y3 = y1; }
                    else { MessageBox.Show("Toplama İşleminde Matrisler Aynı Boyutlarda Olmalıdır!!!!!!");return false; }
                    break;

                case "-":
                    if ((x1 == x2) & (y1 == y2)) { durum = true; x3 = x1; y3 = y1; }
                    else { MessageBox.Show("Çıkarma İşleminde Matrisler Aynı Boyutlarda Olmalıdır!!!!!!");  return false; }
                    break;

                case "*":
                    if ((y1 == x2)) { durum = true; x3 = x1; y3 = y2; }
                    else { MessageBox.Show("Çarpma işleminde 1. Matrisin Sütun Sayısı ile İkinci Matrisin Satır Sayısı Aynı Boyutlarda Olmalıdır!!!!!!"); durum = false; return false; }
                    break;



                case "d1":
                    gecici = new Matris(x1, y1);
                    yazMatris(gecici, txtBoxGrp1,x1,y1);
                    textclear(txtBoxGrp1);
                    //MessageBox.Show("Silindi");
                    for (int x = 0; x < x1; x++)
                    {
                        for (int y = 0; y < y1; y++)
                        {
                            if ((x >= x1) || (y >= y1)) txtBoxGrp1[x, y].Text = "";
                            else txtBoxGrp1[y, x].Text = Convert.ToString(gecici[x, y]);
                        }
                    }
                    durum = true;
                    break;

                case "d2":
                    gecici = new Matris(x2, y2);
                    yazMatris(gecici, txtBoxGrp2, x2, y2);
                    textclear(txtBoxGrp2);
                    //MessageBox.Show("Silindi");
                    for (int x = 0; x < x2; x++)
                    {
                        for (int y = 0; y < y2; y++)
                        {
                            if ((x >= x2) || (y >= y2)) txtBoxGrp1[x, y].Text = "";
                            else txtBoxGrp2[y, x].Text = Convert.ToString(gecici[x, y]);
                        }
                    }
                    durum = true;
                    break;

                default:
                    durum = false;
                    break;
                    
            }

            if (durum) 
            {
               
                    m1 = new Matris(x1, y1);
                    m2 = new Matris(x2, y2);
                    m3 = new Matris(x3, y3);
                    //MessageBox.Show(Convert.ToString(m3.getLength()[0]));
                
            }
          
            return durum;
        }

        private void okuMatris(TextBox[,] gt, Matris m)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    if ((x3 > x) & (y3 > y)) gt[x, y].Text = Convert.ToString(m[x, y]);
                    else gt[x, y].Text = "";
                }
            }
        }

        private void yazMatris(Matris m,  TextBox[,] gt,int xm,int ym)
        {
            for (int x = 0; x < xm; x++)
            {
                for (int y = 0; y < ym; y++)
                {
                    try
                    {
                        m[x, y] = Convert.ToInt32(gt[x, y].Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tüm İndisler Sayısal Olmalıdır.");
                    }
                    
                    
                }
            }
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            flag = boyut_kontrol("-");

            if (flag)
            {
                // Matris m1 = new Matris(10, 10);


                yazMatris(m1, txtBoxGrp1, x1, y1);
                m1 = m1 * Convert.ToInt32(tbKatsayiM1.Text);
                yazMatris(m2, txtBoxGrp2, x2, y2);
                m2 = m2 * Convert.ToInt32(tbKatsayiM2.Text);

                m3 = m1 - m2;

                okuMatris(txtBoxGrp3, m3);
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            flag = boyut_kontrol("*");
            if (flag)
            {
                // Matris m1 = new Matris(10, 10);


                yazMatris(m1, txtBoxGrp1, x1, y1);
                m1 = m1 * Convert.ToInt32(tbKatsayiM1.Text);
                yazMatris(m2, txtBoxGrp2, x2, y2);
                m2 = m2 * Convert.ToInt32(tbKatsayiM2.Text);

                m3 = m1 * m2;

                okuMatris(txtBoxGrp3, m3);
            }
        }


        private void btnTers1_Click(object sender, EventArgs e)
        {
            boyut_kontrol("d1");

        }

        private void btnTers2_Click(object sender, EventArgs e)
        {
            boyut_kontrol("d2");
        }

        private void btnDegis_Click(object sender, EventArgs e)
        {
            string g;

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    g = txtBoxGrp1[x, y].Text;
                    txtBoxGrp1[x, y].Text = txtBoxGrp2[x, y].Text;
                    txtBoxGrp2[x, y].Text = g;

                }
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textclear(this);
            
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }

        private void btndegis1_Click(object sender, EventArgs e)
        {
            

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    txtBoxGrp1[x, y].Text = txtBoxGrp3[x, y].Text;

                }
            }
        }

        private void btnDegis2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    txtBoxGrp2[x, y].Text = txtBoxGrp3[x, y].Text;

                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            textclear(txtBoxGrp1);
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            textclear(txtBoxGrp2);
        }
    }
}