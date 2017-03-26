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
            this.txt_Helloworld = new System.Windows.Forms.TextBox();
            this.rtf_Show001 = new System.Windows.Forms.RichTextBox();
            this.lbl_Show001 = new System.Windows.Forms.Label();
            this.tck_value = new System.Windows.Forms.TrackBar();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.tck_value2 = new System.Windows.Forms.TrackBar();
            this.txt_value2 = new System.Windows.Forms.TextBox();
            this.lbl_data1 = new System.Windows.Forms.Label();
            this.lbl_data2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tck_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_value2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Location = new System.Drawing.Point(71, 106);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowData.TabIndex = 0;
            this.btn_ShowData.Text = "Press me!!";
            this.btn_ShowData.UseVisualStyleBackColor = true;
            this.btn_ShowData.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Helloworld
            // 
            this.txt_Helloworld.Location = new System.Drawing.Point(343, 12);
            this.txt_Helloworld.Name = "txt_Helloworld";
            this.txt_Helloworld.Size = new System.Drawing.Size(100, 22);
            this.txt_Helloworld.TabIndex = 1;
            // 
            // rtf_Show001
            // 
            this.rtf_Show001.Location = new System.Drawing.Point(343, 108);
            this.rtf_Show001.Name = "rtf_Show001";
            this.rtf_Show001.Size = new System.Drawing.Size(100, 96);
            this.rtf_Show001.TabIndex = 2;
            this.rtf_Show001.Text = "";
            // 
            // lbl_Show001
            // 
            this.lbl_Show001.AutoSize = true;
            this.lbl_Show001.Location = new System.Drawing.Point(341, 60);
            this.lbl_Show001.Name = "lbl_Show001";
            this.lbl_Show001.Size = new System.Drawing.Size(33, 12);
            this.lbl_Show001.TabIndex = 3;
            this.lbl_Show001.Text = "label1";
            // 
            // tck_value
            // 
            this.tck_value.Location = new System.Drawing.Point(87, 242);
            this.tck_value.Name = "tck_value";
            this.tck_value.Size = new System.Drawing.Size(104, 45);
            this.tck_value.TabIndex = 4;
            this.tck_value.Scroll += new System.EventHandler(this.tck_value_Scroll);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(197, 242);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(71, 22);
            this.txt_value.TabIndex = 5;
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // tck_value2
            // 
            this.tck_value2.Location = new System.Drawing.Point(88, 293);
            this.tck_value2.Name = "tck_value2";
            this.tck_value2.Size = new System.Drawing.Size(104, 45);
            this.tck_value2.TabIndex = 4;
            this.tck_value2.Scroll += new System.EventHandler(this.tck_value2_Scroll);
            // 
            // txt_value2
            // 
            this.txt_value2.Location = new System.Drawing.Point(198, 293);
            this.txt_value2.Name = "txt_value2";
            this.txt_value2.Size = new System.Drawing.Size(71, 22);
            this.txt_value2.TabIndex = 5;
            this.txt_value2.TextChanged += new System.EventHandler(this.txt_value2_TextChanged);
            // 
            // lbl_data1
            // 
            this.lbl_data1.AutoSize = true;
            this.lbl_data1.Location = new System.Drawing.Point(29, 245);
            this.lbl_data1.Name = "lbl_data1";
            this.lbl_data1.Size = new System.Drawing.Size(35, 12);
            this.lbl_data1.TabIndex = 3;
            this.lbl_data1.Text = "資料1";
            // 
            // lbl_data2
            // 
            this.lbl_data2.AutoSize = true;
            this.lbl_data2.Location = new System.Drawing.Point(29, 296);
            this.lbl_data2.Name = "lbl_data2";
            this.lbl_data2.Size = new System.Drawing.Size(35, 12);
            this.lbl_data2.TabIndex = 3;
            this.lbl_data2.Text = "資料2";
            // 
            // Frm_FirstProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 440);
            this.Controls.Add(this.txt_value2);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.tck_value2);
            this.Controls.Add(this.tck_value);
            this.Controls.Add(this.txt_Helloworld);
            this.Controls.Add(this.lbl_data2);
            this.Controls.Add(this.lbl_data1);
            this.Controls.Add(this.lbl_Show001);
            this.Controls.Add(this.rtf_Show001);
            this.Controls.Add(this.btn_ShowData);
            this.Name = "Frm_FirstProgram";
            this.Text = "ShowHelloWorld!";
            ((System.ComponentModel.ISupportInitialize)(this.tck_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_value2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowData;
        private System.Windows.Forms.TextBox txt_Helloworld;
        private System.Windows.Forms.RichTextBox rtf_Show001;
        private System.Windows.Forms.Label lbl_Show001;
        private System.Windows.Forms.TrackBar tck_value;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.TrackBar tck_value2;
        private System.Windows.Forms.TextBox txt_value2;
        private System.Windows.Forms.Label lbl_data1;
        private System.Windows.Forms.Label lbl_data2;
    }
}

