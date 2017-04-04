using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顏色轉換2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChekColor_Click(object sender, EventArgs e)
        {
            /*
                int a = 4;         
                int b = 4;
                int c = a / b;        //商數
                int d = a % b;        //餘數
                MessageBox.Show("a="+c);
             */
            //HellWord.ForeColor = (Color.Yellow);

           /* 
            int i = 0;
            int j = 3;
            int k;
            while (i <= 10)
            {
                k = i % j;   //餘數                                                       
                int level = k;
                switch (level)
                {
                    case 0:                       
                        HellWord.ForeColor = (Color.Red);
                        break;
                    case 1:
                        HellWord.ForeColor = (Color.Yellow);
                        break;
                    case 2:
                        HellWord.ForeColor = (Color.Green);
                        break;
                    default:
                        break;                                   
                }
                i++;     
             */             
            }
        int number = 0;
        private void checknumber_Click(object sender, EventArgs e)
        {
            int Case= number;
            switch (Case)
            {
                    case 0:                       
                        HelloWord2.ForeColor = (Color.Red);
                        break;
                    case 1:
                        HelloWord2.ForeColor = (Color.Yellow);
                        break;
                    case 2:
                        HelloWord2.ForeColor = (Color.Green);
                        break;
                    default:
                        break;
        }
            number++;
            if (number > 2)
            {
                number = 0;
            }
        }
    }
    }

