
namespace QLNS
{
    partial class fDuAn
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
            this.btnTimKiemDA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemDA = new System.Windows.Forms.TextBox();
            this.btnDongDA = new System.Windows.Forms.Button();
            this.btnXoaDA = new System.Windows.Forms.Button();
            this.btnSuaDA = new System.Windows.Forms.Button();
            this.btnThemDA = new System.Windows.Forms.Button();
            this.dvgDuAn = new System.Windows.Forms.DataGridView();
            this.cboPb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongBanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemDA
            // 
            this.btnTimKiemDA.Location = new System.Drawing.Point(624, 16);
            this.btnTimKiemDA.Name = "btnTimKiemDA";
            this.btnTimKiemDA.Size = new System.Drawing.Size(88, 38);
            this.btnTimKiemDA.TabIndex = 15;
            this.btnTimKiemDA.Text = "Tìm kiếm";
            this.btnTimKiemDA.UseVisualStyleBackColor = true;
            this.btnTimKiemDA.Click += new System.EventHandler(this.btnTimKiemDA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTimKiemDA
            // 
            this.txtTimKiemDA.Location = new System.Drawing.Point(166, 24);
            this.txtTimKiemDA.Name = "txtTimKiemDA";
            this.txtTimKiemDA.Size = new System.Drawing.Size(100, 22);
            this.txtTimKiemDA.TabIndex = 13;
            // 
            // btnDongDA
            // 
            this.btnDongDA.Location = new System.Drawing.Point(706, 397);
            this.btnDongDA.Name = "btnDongDA";
            this.btnDongDA.Size = new System.Drawing.Size(88, 38);
            this.btnDongDA.TabIndex = 12;
            this.btnDongDA.Text = "Đóng";
            this.btnDongDA.UseVisualStyleBackColor = true;
            this.btnDongDA.Click += new System.EventHandler(this.btnDongDA_Click);
            // 
            // btnXoaDA
            // 
            this.btnXoaDA.Location = new System.Drawing.Point(601, 397);
            this.btnXoaDA.Name = "btnXoaDA";
            this.btnXoaDA.Size = new System.Drawing.Size(88, 38);
            this.btnXoaDA.TabIndex = 11;
            this.btnXoaDA.Text = "Xoá";
            this.btnXoaDA.UseVisualStyleBackColor = true;
            this.btnXoaDA.Click += new System.EventHandler(this.btnXoaDA_Click);
            // 
            // btnSuaDA
            // 
            this.btnSuaDA.Location = new System.Drawing.Point(493, 397);
            this.btnSuaDA.Name = "btnSuaDA";
            this.btnSuaDA.Size = new System.Drawing.Size(88, 38);
            this.btnSuaDA.TabIndex = 10;
            this.btnSuaDA.Text = "Sửa";
            this.btnSuaDA.UseVisualStyleBackColor = true;
            this.btnSuaDA.Click += new System.EventHandler(this.btnSuaDA_Click);
            // 
            // btnThemDA
            // 
            this.btnThemDA.Location = new System.Drawing.Point(385, 397);
            this.btnThemDA.Name = "btnThemDA";
            this.btnThemDA.Size = new System.Drawing.Size(88, 38);
            this.btnThemDA.TabIndex = 9;
            this.btnThemDA.Text = "Thêm";
            this.btnThemDA.UseVisualStyleBackColor = true;
            this.btnThemDA.Click += new System.EventHandler(this.btnThemDA_Click);
            // 
            // dvgDuAn
            // 
            this.dvgDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDA,
            this.TenDA,
            this.DiaDiem,
            this.PhongBanId});
            this.dvgDuAn.Location = new System.Drawing.Point(6, 65);
            this.dvgDuAn.Name = "dvgDuAn";
            this.dvgDuAn.RowHeadersWidth = 51;
            this.dvgDuAn.RowTemplate.Height = 24;
            this.dvgDuAn.Size = new System.Drawing.Size(788, 315);
            this.dvgDuAn.TabIndex = 8;
            // 
            // cboPb
            // 
            this.cboPb.FormattingEnabled = true;
            this.cboPb.Location = new System.Drawing.Point(430, 21);
            this.cboPb.Name = "cboPb";
            this.cboPb.Size = new System.Drawing.Size(165, 24);
            this.cboPb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phòng ban:";
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.HeaderText = "Mã dự án";
            this.MaDA.MinimumWidth = 6;
            this.MaDA.Name = "MaDA";
            this.MaDA.Width = 125;
            // 
            // TenDA
            // 
            this.TenDA.DataPropertyName = "TenDA";
            this.TenDA.HeaderText = "Tên dự án";
            this.TenDA.MinimumWidth = 6;
            this.TenDA.Name = "TenDA";
            this.TenDA.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 125;
            // 
            // PhongBanId
            // 
            this.PhongBanId.DataPropertyName = "PhongBanId";
            this.PhongBanId.HeaderText = "Phòng ban";
            this.PhongBanId.MinimumWidth = 6;
            this.PhongBanId.Name = "PhongBanId";
            this.PhongBanId.Width = 125;
            // 
            // fDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiemDA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiemDA);
            this.Controls.Add(this.btnDongDA);
            this.Controls.Add(this.btnXoaDA);
            this.Controls.Add(this.btnSuaDA);
            this.Controls.Add(this.btnThemDA);
            this.Controls.Add(this.dvgDuAn);
            this.Name = "fDuAn";
            this.Text = "fDuAn";
            this.Load += new System.EventHandler(this.fDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemDA;
        private System.Windows.Forms.Button btnDongDA;
        private System.Windows.Forms.Button btnXoaDA;
        private System.Windows.Forms.Button btnSuaDA;
        private System.Windows.Forms.Button btnThemDA;
        private System.Windows.Forms.DataGridView dvgDuAn;
        private System.Windows.Forms.ComboBox cboPb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBanId;
    }
}