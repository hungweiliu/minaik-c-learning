namespace HelloWorld
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
            this.btnShowTaiwan = new System.Windows.Forms.Button();
            this.btnShowAustralia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowTaiwan
            // 
            this.btnShowTaiwan.Location = new System.Drawing.Point(12, 12);
            this.btnShowTaiwan.Name = "btnShowTaiwan";
            this.btnShowTaiwan.Size = new System.Drawing.Size(75, 23);
            this.btnShowTaiwan.TabIndex = 0;
            this.btnShowTaiwan.Text = "Taiwan";
            this.btnShowTaiwan.UseVisualStyleBackColor = true;
            // 
            // btnShowAustralia
            // 
            this.btnShowAustralia.Location = new System.Drawing.Point(12, 50);
            this.btnShowAustralia.Name = "btnShowAustralia";
            this.btnShowAustralia.Size = new System.Drawing.Size(75, 23);
            this.btnShowAustralia.TabIndex = 1;
            this.btnShowAustralia.Text = "Australia";
            this.btnShowAustralia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 343);
            this.Controls.Add(this.btnShowAustralia);
            this.Controls.Add(this.btnShowTaiwan);
            this.Name = "Form1";
            this.Text = "What a wonderful world.....";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowTaiwan;
        private System.Windows.Forms.Button btnShowAustralia;
    }
}

