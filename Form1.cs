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
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxGrp1 = new TextBox[10,10];
            txtBoxGrp2 = new TextBox[10,10];
                        
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    txtBoxGrp1[i, y] = new TextBox();
                    txtBoxGrp1[i, y].Size = new Size(20, 20);
                    txtBoxGrp1[i, y].Location = new Point((y * 20) + 5, (i * 20) + 15);
                    groupBox1.Controls.Add(txtBoxGrp1[i, y]);
                }
            }

            foreach (TextBox  item in txtBoxGrp1 )
            {
                item.Text = "0";
            }

            flag = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Matris m1 = new Matris(10, 10);
                m1[0, 0] = int.Parse(txtBoxGrp1[0, 0].Text);  // matris elemanlerına değer atama
                txtBoxGrp1[9, 8].Text = m1[0, 0].ToString();   // matris elemanlarını okuma
            }
        }
    }
}