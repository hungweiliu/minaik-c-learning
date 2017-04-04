namespace 顏色轉換2
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
            this.ChekColor = new System.Windows.Forms.Button();
            this.HellWord = new System.Windows.Forms.Label();
            this.checknumber = new System.Windows.Forms.Button();
            this.HelloWord2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChekColor
            // 
            this.ChekColor.Location = new System.Drawing.Point(59, 109);
            this.ChekColor.Name = "ChekColor";
            this.ChekColor.Size = new System.Drawing.Size(142, 61);
            this.ChekColor.TabIndex = 0;
            this.ChekColor.Text = "按我";
            this.ChekColor.UseVisualStyleBackColor = true;
            this.ChekColor.Click += new System.EventHandler(this.ChekColor_Click);
            // 
            // HellWord
            // 
            this.HellWord.AllowDrop = true;
            this.HellWord.AutoSize = true;
            this.HellWord.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HellWord.Location = new System.Drawing.Point(22, 32);
            this.HellWord.Name = "HellWord";
            this.HellWord.Size = new System.Drawing.Size(238, 48);
            this.HellWord.TabIndex = 1;
            this.HellWord.Text = "Hello Word";
            // 
            // checknumber
            // 
            this.checknumber.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.checknumber.Location = new System.Drawing.Point(318, 109);
            this.checknumber.Name = "checknumber";
            this.checknumber.Size = new System.Drawing.Size(158, 61);
            this.checknumber.TabIndex = 2;
            this.checknumber.Text = "按一下";
            this.checknumber.UseVisualStyleBackColor = true;
            this.checknumber.Click += new System.EventHandler(this.checknumber_Click);
            // 
            // HelloWord2
            // 
            this.HelloWord2.AllowDrop = true;
            this.HelloWord2.AutoSize = true;
            this.HelloWord2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HelloWord2.Location = new System.Drawing.Point(265, 32);
            this.HelloWord2.Name = "HelloWord2";
            this.HelloWord2.Size = new System.Drawing.Size(238, 48);
            this.HelloWord2.TabIndex = 1;
            this.HelloWord2.Text = "Hello Word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 304);
            this.Controls.Add(this.checknumber);
            this.Controls.Add(this.HelloWord2);
            this.Controls.Add(this.HellWord);
            this.Controls.Add(this.ChekColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChekColor;
        private System.Windows.Forms.Label HellWord;
        private System.Windows.Forms.Button checknumber;
        private System.Windows.Forms.Label HelloWord2;
    }
}

