using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;     //延遲
namespace 作業1_問候語
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int look = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 12;   //設定 中間 次數
            int i = 0;  //初始值   最上及最下 兩條
            int ii = 0;  //初始值    中間 
            int wow = 0;
            string text = "";  //字串

            while (wow < 3)
            {
                if (wow == 1)                          //中間
                {
                    for (ii = 1; ii <= x; ii++)
                    {
                        text += "Hello World!!                                                                                      Hello World!!" + "\n";
                        richTextBox1.Text = text;
                    }
                }
                else                                   //最上及最下 兩條
                {
                    for (i = 1; i <= 5; i++)
                    {
                        text += "Hello World!!     ";
                        richTextBox1.Text = text;
                    }
                    text += "\r\n";
                }
                wow += 1;
            }
                richTextBox2.Text = "電控部"+"\r\n" + "  進棋";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
