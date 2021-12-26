using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button2.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button2.Text;
            }
        }
        bool erza = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button1.Text;
                erza = false;
            }
            else
            {
           
                textBox1.Text += button1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button3.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button4.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button5.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button6.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button7.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button8.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button9.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button10.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button10.Text;
            }
        }
        float total = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            
            if (eve == 1 || eve==0)
            {
                IEEE l = new IEEE();
                total = l.jam(total, float.Parse(textBox1.Text));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 2)
            {
                IEEE l = new IEEE();
                total = Math.Abs(l.taf(total, float.Parse(textBox1.Text)));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 3)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.zar(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            else if (eve == 4)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.taq(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            eve = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (eve == 1)
            {
                IEEE l = new IEEE();
                total = l.jam(total, float.Parse(textBox1.Text));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 2 || eve==0)
            {
                IEEE l = new IEEE();
                total = Math.Abs(l.taf(total, float.Parse(textBox1.Text)));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 3)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.zar(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            else if (eve == 4)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.taq(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            eve = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (eve == 1)
            {
                IEEE l = new IEEE();
                total = l.jam(total, float.Parse(textBox1.Text));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 2)
            {
                IEEE l = new IEEE();
                total = Math.Abs(l.taf(total, float.Parse(textBox1.Text)));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 3 || eve==0)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.zar(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            else if (eve == 4)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.taq(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            eve = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (eve == 1)
            {
                IEEE l = new IEEE();
                total = l.jam(total, float.Parse(textBox1.Text));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 2)
            {
                IEEE l = new IEEE();
                total = Math.Abs(l.taf(total, float.Parse(textBox1.Text)));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 3)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.zar(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            else if (eve == 4 || eve==0)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.taq(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            eve = 4;
        }
        int eve = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            if (erza == true)
            {
                textBox1.Clear();
                textBox1.Text += button11.Text;
                erza = false;
            }
            else
            {
                textBox1.Text += button11.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (eve == 0)
            {
                textBox1.Text = total.ToString();
                erza = true;
            }
            if (eve == 1)
            {
                IEEE l = new IEEE();
                total = l.jam(total, float.Parse(textBox1.Text));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 2)
            {
                IEEE l = new IEEE();
                total = Math.Abs(l.taf(total, float.Parse(textBox1.Text)));
                erza = true;
                textBox1.Text = total.ToString();
            }
            else if (eve == 3)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.zar(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
            else if (eve == 4)
            {
                if (total == 0)
                {
                    total = float.Parse(textBox1.Text);
                    erza = true;
                    textBox1.Text = total.ToString();
                }
                else
                {
                    IEEE l = new IEEE();
                    total = l.taq(total, float.Parse(textBox1.Text));
                    erza = true;
                    textBox1.Text = total.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char l = (char)(1633);
            button1.Text = l.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode))
                e.SuppressKeyPress = true;
        }
    }
}
