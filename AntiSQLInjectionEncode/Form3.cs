using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiSQLInjection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SQL s = new SQL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""|| textBox2.Text ==""||textBox3.Text == "")
            {
                MessageBox.Show("Empty!");
            }
            else
            {
                if (textBox2.Text != textBox3.Text) MessageBox.Show("New Password Not Equals With Confirm");
                else s.Add(textBox1.Text, textBox2.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
