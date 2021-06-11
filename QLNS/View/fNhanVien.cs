using System;
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
    
    public partial class fNhanVien : Form
    {
       

        public fNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            if(fDangNhap.Quyen == "user")
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnThem.Visible = false;
            }
            DanhSachPhongBan();
            DanhSachNhanVien();
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien();
        }

            // hiện thị ds pb
            private void DanhSachPhongBan()
            {
                List<PhongBan> lstPhongBan = Common.Instance.PhongBans.ToList();
                lstPhongBan.Insert(0, new PhongBan() { MaPhong = "", TenPhong = "--CHỌN PHÒNG--" });
                cboPb.DisplayMember = "TenPhong";
                cboPb.ValueMember = "MaPhong";
                cboPb.DataSource = lstPhongBan;
            
            }

        // hiện thị dsnv
        private void DanhSachNhanVien()
        {
            string hoten = "", maphong = "",manv= "";
            //lay tt tren GUI
            manv = txtHoTen.Text.Trim();
            maphong = "" + cboPb.SelectedValue;
            IQueryable<NhanVien> lstNhanVien = Common.Instance.NhanViens;

            if (!string.IsNullOrEmpty(manv))
            {
                lstNhanVien = lstNhanVien.Where(p => p.MaNV.Contains(manv));

            }

            if (!string.IsNullOrEmpty(maphong))
            {
                lstNhanVien = lstNhanVien.Where(p => p.PhongBanId == maphong);
            }
            // chỉ hiện thị tt cần thiết
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = lstNhanVien.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fNhanVienAdd f = new fNhanVienAdd();
            f.ShowDialog();

            //Hiện thị lại ds để xem lại sự thay đổi 
            DanhSachNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = "";
            // chọn hàng ngay click chuột
            manv = "" + dgvNhanVien.CurrentRow.Cells[0].Value;
            fNhanVienAdd f = new fNhanVienAdd();
            f.NhanvienID = manv;
            f.ShowDialog();
            //hiện thị lại ds nv
            DanhSachNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá nhân viên này không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                string manv = "";
                // chọn hàng ngay click chuột
                manv = "" + dgvNhanVien.CurrentRow.Cells[0].Value;
                NhanVien objNhanVien = Common.Instance.NhanViens.Find(manv);

                if(objNhanVien != null)
                {
                    Common.Instance.NhanViens.Remove(objNhanVien);
                    Common.Instance.SaveChanges();
                    //HIỆN THỊ LẠI DSNV
                    DanhSachNhanVien();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangNhap f = new fDangNhap();
            f.Show();
        }
    }
}
