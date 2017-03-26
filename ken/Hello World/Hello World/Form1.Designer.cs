namespace Hello_World
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
            this.buttonpush = new System.Windows.Forms.Button();
            this.Labelshow = new System.Windows.Forms.Label();
            this.TXTSHOW = new System.Windows.Forms.TextBox();
            this.mathshow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonpush
            // 
            this.buttonpush.Location = new System.Drawing.Point(25, 56);
            this.buttonpush.Name = "buttonpush";
            this.buttonpush.Size = new System.Drawing.Size(75, 23);
            this.buttonpush.TabIndex = 0;
            this.buttonpush.Text = "顯示按鈕";
            this.buttonpush.UseVisualStyleBackColor = true;
            this.buttonpush.Click += new System.EventHandler(this.button1_Click);
            // 
            // Labelshow
            // 
            this.Labelshow.AutoSize = true;
            this.Labelshow.Location = new System.Drawing.Point(129, 104);
            this.Labelshow.Name = "Labelshow";
            this.Labelshow.Size = new System.Drawing.Size(33, 12);
            this.Labelshow.TabIndex = 1;
            this.Labelshow.Text = "label1";
            // 
            // TXTSHOW
            // 
            this.TXTSHOW.Location = new System.Drawing.Point(131, 58);
            this.TXTSHOW.Name = "TXTSHOW";
            this.TXTSHOW.Size = new System.Drawing.Size(100, 22);
            this.TXTSHOW.TabIndex = 2;
            // 
            // mathshow
            // 
            this.mathshow.Location = new System.Drawing.Point(131, 145);
            this.mathshow.Name = "mathshow";
            this.mathshow.Size = new System.Drawing.Size(100, 96);
            this.mathshow.TabIndex = 3;
            this.mathshow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mathshow);
            this.Controls.Add(this.TXTSHOW);
            this.Controls.Add(this.Labelshow);
            this.Controls.Add(this.buttonpush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonpush;
        private System.Windows.Forms.Label Labelshow;
        private System.Windows.Forms.TextBox TXTSHOW;
        private System.Windows.Forms.RichTextBox mathshow;
    }
}

