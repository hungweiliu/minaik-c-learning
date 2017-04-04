namespace HelloWorld
{
    partial class Frm_FirstProgram
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
            this.btn_ShowData = new System.Windows.Forms.Button();
            this.tck_helloWorldShowTimes = new System.Windows.Forms.TrackBar();
            this.txt_helloWorldShowTimes = new System.Windows.Forms.TextBox();
            this.lbl_helloWorldShowTimes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tck_helloWorldShowTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Location = new System.Drawing.Point(7, 9);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowData.TabIndex = 0;
            this.btn_ShowData.Text = "Press me!!";
            this.btn_ShowData.UseVisualStyleBackColor = true;
            this.btn_ShowData.Visible = false;
            this.btn_ShowData.Click += new System.EventHandler(this.button1_Click);
            // 
            // tck_helloWorldShowTimes
            // 
            this.tck_helloWorldShowTimes.Location = new System.Drawing.Point(87, 242);
            this.tck_helloWorldShowTimes.Maximum = 200;
            this.tck_helloWorldShowTimes.Minimum = 1;
            this.tck_helloWorldShowTimes.Name = "tck_helloWorldShowTimes";
            this.tck_helloWorldShowTimes.Size = new System.Drawing.Size(104, 45);
            this.tck_helloWorldShowTimes.TabIndex = 4;
            this.tck_helloWorldShowTimes.Value = 1;
            this.tck_helloWorldShowTimes.Scroll += new System.EventHandler(this.tck_helloWorldShowTimes_Scroll);
            // 
            // txt_helloWorldShowTimes
            // 
            this.txt_helloWorldShowTimes.Location = new System.Drawing.Point(197, 242);
            this.txt_helloWorldShowTimes.Name = "txt_helloWorldShowTimes";
            this.txt_helloWorldShowTimes.Size = new System.Drawing.Size(71, 22);
            this.txt_helloWorldShowTimes.TabIndex = 5;
            this.txt_helloWorldShowTimes.Text = "1";
            this.txt_helloWorldShowTimes.TextChanged += new System.EventHandler(this.txt_helloWorldShowTimes_TextChanged);
            // 
            // lbl_helloWorldShowTimes
            // 
            this.lbl_helloWorldShowTimes.AutoSize = true;
            this.lbl_helloWorldShowTimes.Location = new System.Drawing.Point(29, 245);
            this.lbl_helloWorldShowTimes.Name = "lbl_helloWorldShowTimes";
            this.lbl_helloWorldShowTimes.Size = new System.Drawing.Size(53, 12);
            this.lbl_helloWorldShowTimes.TabIndex = 3;
            this.lbl_helloWorldShowTimes.Text = "出現次數";
            // 
            // Frm_FirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 440);
            this.Controls.Add(this.txt_helloWorldShowTimes);
            this.Controls.Add(this.tck_helloWorldShowTimes);
            this.Controls.Add(this.lbl_helloWorldShowTimes);
            this.Controls.Add(this.btn_ShowData);
            this.Name = "Frm_FirstProgram";
            this.Text = "ShowHelloWorld!";
            this.Load += new System.EventHandler(this.Frm_FirstProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tck_helloWorldShowTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowData;
        private System.Windows.Forms.TrackBar tck_helloWorldShowTimes;
        private System.Windows.Forms.TextBox txt_helloWorldShowTimes;
        private System.Windows.Forms.Label lbl_helloWorldShowTimes;
    }
}

