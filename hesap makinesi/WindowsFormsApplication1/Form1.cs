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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,sonuc=0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = sonuc.ToString();
            if (sonuc < 0)
            {
                label4.BackColor = System.Drawing.Color.Red;
            }
            else
                label4.BackColor = System.Drawing.Color.Green;

        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = sonuc.ToString();
            if (sonuc < 0)
            {
                label4.BackColor = System.Drawing.Color.Red;
            }
            else
                label4.BackColor = System.Drawing.Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = sonuc.ToString();
            if (sonuc <= 0)
            {
                label4.BackColor = System.Drawing.Color.Red;
            }
            
            else
                label4.BackColor = System.Drawing.Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            if (sayi2 == 0)
            {
                label4.Text = "tanımsız";
            }
            else
            {
                sonuc = sayi1 / sayi2;
            label4.Text = sonuc.ToString();
            }
            if (sonuc < 0)
            {
                label4.BackColor = System.Drawing.Color.Red;
            }
            else
                label4.BackColor = System.Drawing.Color.Green;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }
    }
}


 
 
