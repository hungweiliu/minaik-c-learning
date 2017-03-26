namespace HelloWorld
{
    partial class frmHelloWorld
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtShowHello = new System.Windows.Forms.TextBox();
            this.lbShowNumber = new System.Windows.Forms.Label();
            this.rtShowNumber = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtShowHello
            // 
            this.txtShowHello.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtShowHello.Location = new System.Drawing.Point(196, 48);
            this.txtShowHello.Name = "txtShowHello";
            this.txtShowHello.Size = new System.Drawing.Size(172, 41);
            this.txtShowHello.TabIndex = 1;
            // 
            // lbShowNumber
            // 
            this.lbShowNumber.AutoSize = true;
            this.lbShowNumber.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbShowNumber.Location = new System.Drawing.Point(198, 124);
            this.lbShowNumber.Name = "lbShowNumber";
            this.lbShowNumber.Size = new System.Drawing.Size(76, 28);
            this.lbShowNumber.TabIndex = 2;
            this.lbShowNumber.Text = "label1";
            // 
            // rtShowNumber
            // 
            this.rtShowNumber.Location = new System.Drawing.Point(198, 188);
            this.rtShowNumber.Name = "rtShowNumber";
            this.rtShowNumber.Size = new System.Drawing.Size(170, 92);
            this.rtShowNumber.TabIndex = 3;
            this.rtShowNumber.Text = "";
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 324);
            this.Controls.Add(this.rtShowNumber);
            this.Controls.Add(this.lbShowNumber);
            this.Controls.Add(this.txtShowHello);
            this.Controls.Add(this.button1);
            this.Name = "frmHelloWorld";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtShowHello;
        private System.Windows.Forms.Label lbShowNumber;
        private System.Windows.Forms.RichTextBox rtShowNumber;
    }
}

