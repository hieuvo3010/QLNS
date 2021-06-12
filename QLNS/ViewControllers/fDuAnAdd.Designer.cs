
namespace QLNS
{
    partial class fDuAnAdd
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
            this.btnDongDA = new System.Windows.Forms.Button();
            this.btnCapNhatDA = new System.Windows.Forms.Button();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDongDA
            // 
            this.btnDongDA.Location = new System.Drawing.Point(308, 171);
            this.btnDongDA.Name = "btnDongDA";
            this.btnDongDA.Size = new System.Drawing.Size(75, 30);
            this.btnDongDA.TabIndex = 21;
            this.btnDongDA.Text = "Đóng";
            this.btnDongDA.UseVisualStyleBackColor = true;
            this.btnDongDA.Click += new System.EventHandler(this.btnDongDA_Click);
            // 
            // btnCapNhatDA
            // 
            this.btnCapNhatDA.Location = new System.Drawing.Point(208, 171);
            this.btnCapNhatDA.Name = "btnCapNhatDA";
            this.btnCapNhatDA.Size = new System.Drawing.Size(80, 30);
            this.btnCapNhatDA.TabIndex = 20;
            this.btnCapNhatDA.Text = "Lưu";
            this.btnCapNhatDA.UseVisualStyleBackColor = true;
            this.btnCapNhatDA.Click += new System.EventHandler(this.btnCapNhatDA_Click);
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(144, 83);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(239, 22);
            this.txtTenDA.TabIndex = 18;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(144, 41);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(239, 22);
            this.txtMaDA.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa điểm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên dự án:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã dự án:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(144, 125);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(239, 22);
            this.txtDiaDiem.TabIndex = 22;
            // 
            // fDuAnAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 223);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.btnDongDA);
            this.Controls.Add(this.btnCapNhatDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "fDuAnAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDuAnAdd";
            this.Load += new System.EventHandler(this.fDuAnAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongDA;
        private System.Windows.Forms.Button btnCapNhatDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaDiem;
    }
}