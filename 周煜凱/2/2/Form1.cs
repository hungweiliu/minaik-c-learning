using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string hello = "";
            string str = "";
            number++;
            for (int i = 1; i <= number; i++)
            {
                str += "!";
                hello += "Hello World" + str + "\r\n";
            }
                richShowHi.Text = (hello);
            
        }

      
    }
}
