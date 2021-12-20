using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader("save.txt"))
                {
                    textBox1.Text = sr.ReadLine();
                    textBox2.Text = sr.ReadLine();
                    textBox3.Text = sr.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                if (e.Handled == true) { 
                    label4.Text = "Не все поля заполнены.";
                    return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') == 0))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                label4.Text = "Не все поля заполнены.";
                return;
            }
            label4.Text = Logic.MultiplicationOfMinimumValues(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("save.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox3.Text);

                }
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
