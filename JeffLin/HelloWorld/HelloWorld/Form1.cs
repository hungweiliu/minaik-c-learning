using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Frm_FirstProgram : Form
    {
        public Frm_FirstProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Helloworld.Text = ("HelloWorld!");
            lbl_Show001.Text = "HelloWorld!";

        }
        private void button2_Click(object sender, EventArgs e)
        {

            rtf_Show001.Text = "HelloWorld!2";
        }

        private void tck_value_Scroll(object sender, EventArgs e)
        {
            txt_value.Text = tck_value.Value.ToString();
            txt_value2.Text = (tck_value.Value*5).ToString();
            tck_value2.Value = Convert.ToInt32( txt_value2.Text);
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            tck_value.Value= Convert.ToInt32(txt_value.Text);
            txt_value2.Text = (tck_value.Value * 5).ToString();
            tck_value2.Value = Convert.ToInt32(txt_value2.Text);
        }

        private void tck_value2_Scroll(object sender, EventArgs e)
        {
            txt_value2.Text = tck_value2.Value.ToString();
            txt_value.Text = (tck_value2.Value / 5).ToString();
            tck_value.Value = Convert.ToInt32(txt_value.Text);
        }

        private void txt_value2_TextChanged(object sender, EventArgs e)
        {
            tck_value2.Value= Convert.ToInt32(txt_value2.Text );
            txt_value.Text = (tck_value2.Value / 5).ToString();
            tck_value.Value = Convert.ToInt32(txt_value.Text);
        }



    }
}
