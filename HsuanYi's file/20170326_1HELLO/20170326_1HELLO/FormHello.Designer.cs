namespace _20170326_1HELLO
{
    partial class Form_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SHOW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.txtSpeedOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(104, 60);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 50);
            this.button.TabIndex = 0;
            this.button.Text = "Press me@@";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.QQButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(298, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 120);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";

            // 
            // SHOW
            // 
            this.SHOW.Location = new System.Drawing.Point(350, 87);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(103, 22);
            this.SHOW.TabIndex = 3;
            this.SHOW.TextChanged += new System.EventHandler(this.SHOW_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "SHOWNumber";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(89, 151);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(120, 22);
            this.txtTemp.TabIndex = 5;
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(89, 191);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(120, 22);
            this.txtPressure.TabIndex = 6;
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(88, 231);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(120, 22);
            this.txtVelocity.TabIndex = 7;
            // 
            // txtSpeedOut
            // 
            this.txtSpeedOut.Location = new System.Drawing.Point(87, 271);
            this.txtSpeedOut.Name = "txtSpeedOut";
            this.txtSpeedOut.Size = new System.Drawing.Size(120, 22);
            this.txtSpeedOut.TabIndex = 8;
            // 
            // Form_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 475);
            this.Controls.Add(this.txtSpeedOut);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button);
            this.Name = "Form_Hello";
            this.Text = "FormHello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox SHOW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.TextBox txtSpeedOut;
    }
}

