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
        public FontStyle fs = System.Drawing.FontStyle.Regular;
        public FontFamily fm = new FontFamily("Consolas");

        Random rad_locationX = new Random(Convert.ToInt16(DateTime.Now.Millisecond));
        Random rad_locationY = new Random(Convert.ToInt16(DateTime.Now.Millisecond+1));
        Random rad_fontSize = new Random(Convert.ToInt16(DateTime.Now.Millisecond+2));
        Random rad_fontColorR = new Random(Convert.ToInt16(DateTime.Now.Millisecond+3));
        Random rad_fontColorG = new Random(Convert.ToInt16(DateTime.Now.Millisecond+4));
        Random rad_fontColorB = new Random(Convert.ToInt16(DateTime.Now.Millisecond+5));
        
        Label[] lbl_showHelloWorld = new Label[1000];
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_helloWorldShowTimes.Visible = false;
            tck_helloWorldShowTimes.Visible = false;
            txt_helloWorldShowTimes.Visible = false;
            for (int helloWorldShowTimes = 0; helloWorldShowTimes < tck_helloWorldShowTimes.Value; helloWorldShowTimes++)
            {
                lbl_showHelloWorld[a] = new Label();

                this.Controls.Add(lbl_showHelloWorld[a]);
                lbl_showHelloWorld[a].AutoSize = true;
                lbl_showHelloWorld[a].Location = new System.Drawing.Point(rad_locationX.Next(0, this.Width), rad_locationY.Next(0, this.Height));
                lbl_showHelloWorld[a].Name = "lbl_Show00" + a.ToString();
                lbl_showHelloWorld[a].Size = new System.Drawing.Size(80, 12);
                lbl_showHelloWorld[a].Text = "HelloWorld!";
                lbl_showHelloWorld[a].Font = new Font(fm, rad_fontSize.Next(3, 32), fs);
                lbl_showHelloWorld[a].ForeColor = Color.FromArgb(rad_fontColorR.Next(255), rad_fontColorR.Next(255), rad_fontColorR.Next(255));
                a++;
            }
        }


        private void tck_helloWorldShowTimes_Scroll(object sender, EventArgs e)
        {
            txt_helloWorldShowTimes.Text = tck_helloWorldShowTimes.Value.ToString();
            helloWorldShowTimesChange();
        }

        private void txt_helloWorldShowTimes_TextChanged(object sender, EventArgs e)
        {
            tck_helloWorldShowTimes.Value= Convert.ToInt32(txt_helloWorldShowTimes.Text);
            helloWorldShowTimesChange();
        }
        private void helloWorldShowTimesChange()
        {
            btn_ShowData.Visible = true;


        }

        private void Frm_FirstProgram_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }
    }
}
