using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            textBox1.Text += bt.Text;
            label1.Text += bt.Text;
        }

        string op = "nothing";
        double total = 0;
        private void op_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (op=="nothing")
                total = double.Parse(textBox1.Text);

            else
            {

                if (op == "+")
                    total += double.Parse(textBox1.Text);
                else if (op == "-")
                    total -= double.Parse(textBox1.Text);
                else if (op == "*")
                    total *= double.Parse(textBox1.Text);
                else if (op == "/")
                    total /= double.Parse(textBox1.Text);
                else if (op == "^")
                    Math.Pow(total,double.Parse(textBox1.Text));
            }

            op = bt.Text;
            label1.Text += bt.Text;
            textBox1.Clear();
        }
        private void eq_Click(object sender, EventArgs e)
        {
            if (op == "+")
                total += double.Parse(textBox1.Text);
            else if (op == "-")
                total -= double.Parse(textBox1.Text);
            else if (op == "*")
                total *= double.Parse(textBox1.Text);
            else if (op == "/")
                total /= double.Parse(textBox1.Text);
            else if (op == "^")
                Math.Pow(total, double.Parse(textBox1.Text));
            textBox1.Text = total + "";
            label1.Text += " = ";
            label1.Text += total;

        }

        private void button19_Click(object sender, EventArgs e)
        {//dot button
            string[] s = (textBox1.Text).Split(".");
            if(s.Length==1)
            textBox1.Text+= ".";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
            groupBox1.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "scintific")
                groupBox1.Show();
            else
                groupBox1.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               textBox1.Text = textBox1.Text.Remove((textBox1.Text.Length) - 1);
               label1.Text = label1.Text.Remove((label1.Text.Length) - 1);
            }
            
        }

        private void cl_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            op = "nothing";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                op = " ";
                label1.Text=label1.Text.Remove((label1.Text.Length) - 1);
            }
                
            else
            {
                for (int i=0;i<textBox1.Text.Length;i++)
                    label1.Text= label1.Text.Remove((label1.Text.Length) - 1);
                textBox1.Clear();
                
            }
                

        }
        double memory = 0;
        private void ms_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);
        }

        private void mc_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void mr_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory + "";
        }

        private void mm_Click(object sender, EventArgs e)
        {
            memory -= int.Parse(textBox1.Text);
        }

        private void mp_Click(object sender, EventArgs e)
        {
            memory += int.Parse(textBox1.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(int.Parse(textBox1.Text)) + "";
        }

        private void power2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow((double.Parse(textBox1.Text)),2)+" ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            double t = 1;
            for (int i = 1; i <= n; i++)
                t *= i;
            textBox1.Text = t + "";
        }
    }
}
