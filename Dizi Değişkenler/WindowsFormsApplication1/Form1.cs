using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] sayilar = new int[10];
        int[] isimler = new int[0];

        private void Form1_Load(object sender, EventArgs e)
        {
            sayilar[0] = 3;
            sayilar[1] = 7;
            sayilar[2] = 34;
            sayilar[3] = 43;
            sayilar[4] = 8;
            sayilar[5] = -2;
            sayilar[6] = 9;
            sayilar[7] = 4;
            sayilar[8] = 24;
            sayilar[9] = 67;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           label1.Text = sayilar [Convert.ToInt32(textBox1.Text) ] .ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
