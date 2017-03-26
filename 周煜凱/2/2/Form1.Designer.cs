namespace _2
{
    partial class Form1
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
            this.textTemplate = new System.Windows.Forms.TextBox();
            this.textPressure = new System.Windows.Forms.TextBox();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.textAccelation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textShow123 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richShowHi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTemplate
            // 
            this.textTemplate.Location = new System.Drawing.Point(61, 111);
            this.textTemplate.Name = "textTemplate";
            this.textTemplate.Size = new System.Drawing.Size(106, 22);
            this.textTemplate.TabIndex = 0;
            // 
            // textPressure
            // 
            this.textPressure.Location = new System.Drawing.Point(61, 164);
            this.textPressure.Name = "textPressure";
            this.textPressure.Size = new System.Drawing.Size(106, 22);
            this.textPressure.TabIndex = 1;
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(61, 223);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(106, 22);
            this.textSpeed.TabIndex = 2;
            // 
            // textAccelation
            // 
            this.textAccelation.Location = new System.Drawing.Point(61, 267);
            this.textAccelation.Name = "textAccelation";
            this.textAccelation.Size = new System.Drawing.Size(106, 22);
            this.textAccelation.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textShow123
            // 
            this.textShow123.Location = new System.Drawing.Point(290, 41);
            this.textShow123.Name = "textShow123";
            this.textShow123.Size = new System.Drawing.Size(100, 22);
            this.textShow123.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "測試結果";
            // 
            // richShowHi
            // 
            this.richShowHi.Location = new System.Drawing.Point(276, 128);
            this.richShowHi.Name = "richShowHi";
            this.richShowHi.Size = new System.Drawing.Size(100, 96);
            this.richShowHi.TabIndex = 7;
            this.richShowHi.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "mm";
   
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richShowHi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textShow123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAccelation);
            this.Controls.Add(this.textSpeed);
            this.Controls.Add(this.textPressure);
            this.Controls.Add(this.textTemplate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTemplate;
        private System.Windows.Forms.TextBox textPressure;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.TextBox textAccelation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textShow123;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richShowHi;
        private System.Windows.Forms.Label label2;
    }
}

