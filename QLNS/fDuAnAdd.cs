﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class fDuAnAdd : Form
    {
        // khai báo biến để giao tiếp form danh sách và thêm mới, sửa
        private string _DuAnID = null;
        public string DuAnID { get => _DuAnID; set => _DuAnID = value; }

        public fDuAnAdd()
        {
            InitializeComponent();
        }

        private void btnCapNhatDA_Click(object sender, EventArgs e)
        {
            try
            {
                bool isInsert = true;
                DuAn objDuan = null;
                if (!string.IsNullOrEmpty(_DuAnID))
                {
                    objDuan = Common.Instance.DuAns.Find(_DuAnID);
                }

                if (objDuan != null)
                {
                    isInsert = false;
                }
                else
                {
                    objDuan = new DuAn();
                }
                objDuan.MaDA = txtMaDA.Text;
                objDuan.TenDA = txtTenDA.Text;
                objDuan.DiaDiem = txtDiaDiem.Text;
                objDuan.PhongBanId = "" + cboPhong.SelectedValue;

                if (isInsert)
                {
                    Common.Instance.DuAns.Add(objDuan);
                }

                //Luu su thay doi
                Common.Instance.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDongDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDuAnAdd_Load(object sender, EventArgs e)
        {
            DanhSachPhongBan();
            if (!string.IsNullOrEmpty(_DuAnID))
            {
                this.Text = "Sửa thông tin dự án";
                HienThiChiTietDuAn();
            }
            else
            {
                this.Text = "Thêm mới thông tin dự án";
            }
        }

        private void HienThiChiTietDuAn()
        {
            DuAn objDuan = Common.Instance.DuAns.Find(_DuAnID);
            if (objDuan != null)
            {
                // hiện thị thông tin lên giao diện
                objDuan.MaDA = txtMaDA.Text;
                objDuan.TenDA = txtTenDA.Text;
                objDuan.DiaDiem = txtDiaDiem.Text;
                cboPhong.SelectedValue = "" + objDuan.PhongBanId;
            }

        }

        // hiện thị ds pb
        private void DanhSachPhongBan()
        {
            List<PhongBan> lstPhongBan = Common.Instance.PhongBans.ToList();
            lstPhongBan.Insert(0, new PhongBan() { MaPhong = "", TenPhong = "--CHỌN PHÒNG--" });
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.DataSource = lstPhongBan;

        }

    }
}