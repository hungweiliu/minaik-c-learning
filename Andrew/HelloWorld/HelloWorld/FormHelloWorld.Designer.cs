namespace HelloWorld
{
	partial class FormHelloWorld
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtShowHello = new System.Windows.Forms.TextBox();
			this.rtShow456 = new System.Windows.Forms.RichTextBox();
			this.btnShow = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTemperature = new System.Windows.Forms.TextBox();
			this.txtPressure = new System.Windows.Forms.TextBox();
			this.txtVelocity = new System.Windows.Forms.TextBox();
			this.txtSpeedOutput = new System.Windows.Forms.TextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// txtShowHello
			// 
			this.txtShowHello.Location = new System.Drawing.Point(321, 70);
			this.txtShowHello.Name = "txtShowHello";
			this.txtShowHello.Size = new System.Drawing.Size(100, 25);
			this.txtShowHello.TabIndex = 1;
			// 
			// rtShow456
			// 
			this.rtShow456.Location = new System.Drawing.Point(244, 228);
			this.rtShow456.Name = "rtShow456";
			this.rtShow456.Size = new System.Drawing.Size(177, 96);
			this.rtShow456.TabIndex = 3;
			this.rtShow456.Text = "";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(31, 44);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(146, 73);
			this.btnShow.TabIndex = 4;
			this.btnShow.Text = "Start";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(241, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "測試結果";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(437, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "mm";
			// 
			// txtTemperature
			// 
			this.txtTemperature.Location = new System.Drawing.Point(391, 101);
			this.txtTemperature.Name = "txtTemperature";
			this.txtTemperature.Size = new System.Drawing.Size(100, 25);
			this.txtTemperature.TabIndex = 7;
			// 
			// txtPressure
			// 
			this.txtPressure.Location = new System.Drawing.Point(391, 148);
			this.txtPressure.Name = "txtPressure";
			this.txtPressure.Size = new System.Drawing.Size(100, 25);
			this.txtPressure.TabIndex = 8;
			// 
			// txtVelocity
			// 
			this.txtVelocity.Location = new System.Drawing.Point(105, 228);
			this.txtVelocity.Name = "txtVelocity";
			this.txtVelocity.Size = new System.Drawing.Size(100, 25);
			this.txtVelocity.TabIndex = 9;
			// 
			// txtSpeedOutput
			// 
			this.txtSpeedOutput.Location = new System.Drawing.Point(105, 270);
			this.txtSpeedOutput.Name = "txtSpeedOutput";
			this.txtSpeedOutput.Size = new System.Drawing.Size(100, 25);
			this.txtSpeedOutput.TabIndex = 10;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(183, 101);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(172, 56);
			this.trackBar1.TabIndex = 11;
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(183, 148);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(172, 56);
			this.trackBar2.TabIndex = 12;
			// 
			// FormHelloWorld
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 365);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.txtSpeedOutput);
			this.Controls.Add(this.txtVelocity);
			this.Controls.Add(this.txtPressure);
			this.Controls.Add(this.txtTemperature);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.rtShow456);
			this.Controls.Add(this.txtShowHello);
			this.Name = "FormHelloWorld";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtShowHello;
		private System.Windows.Forms.RichTextBox rtShow456;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTemperature;
		private System.Windows.Forms.TextBox txtPressure;
		private System.Windows.Forms.TextBox txtVelocity;
		private System.Windows.Forms.TextBox txtSpeedOutput;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
	}
}

