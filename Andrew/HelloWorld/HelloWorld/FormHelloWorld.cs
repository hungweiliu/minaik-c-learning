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
	public partial class FormHelloWorld : Form
	{
		public FormHelloWorld()
		{
			InitializeComponent();
		}



		private void btnShow_Click(object sender, EventArgs e)
		{
			rtShow456.Text = "456";
			txtShowHello.Text = "hello world!";


		}


	}
}
