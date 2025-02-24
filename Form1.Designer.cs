namespace Bai13_tinhcanchi_1
{
    partial class Form1
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
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lstkq = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(60, 54);
            this.txtnhap.Multiline = true;
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(100, 25);
            this.txtnhap.TabIndex = 0;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(60, 96);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 23);
            this.txtkq.TabIndex = 1;
            // 
            // lstkq
            // 
            this.lstkq.FormattingEnabled = true;
            this.lstkq.Location = new System.Drawing.Point(191, 54);
            this.lstkq.Name = "lstkq";
            this.lstkq.Size = new System.Drawing.Size(156, 173);
            this.lstkq.TabIndex = 2;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(73, 125);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(73, 190);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 37);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Exit";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lstkq);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtnhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ListBox lstkq;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

