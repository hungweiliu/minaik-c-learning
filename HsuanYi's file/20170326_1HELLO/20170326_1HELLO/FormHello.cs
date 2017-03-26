using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170326_1HELLO
{
    public partial class Form_Hello : Form
    {
        public Form_Hello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHOW_TextChanged(object sender, EventArgs e)
        {

        }

        private void QQButton_Click(object sender, EventArgs e)
        {
            SHOW.Text = "Hello world";
            richTextBox1.Text = "456";
            label1.Text = "777";
        }


    }
}
