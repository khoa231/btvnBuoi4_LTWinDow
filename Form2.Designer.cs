namespace btvnBuoi4_LTWinDow
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten nhan vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Luong";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(171, 39);
            this.txtMSNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(285, 22);
            this.txtMSNV.TabIndex = 3;
            this.txtMSNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(171, 83);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(285, 22);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(171, 129);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(285, 22);
            this.txtLuong.TabIndex = 5;
            this.txtLuong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(92, 211);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(92, 23);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "Dong y";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(288, 212);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(132, 23);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "Dong";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 300);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}