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
    public partial class fPhanCong : Form
    {
       
        public fPhanCong()
        {
            InitializeComponent();
        }

        private void fPhanCong_Load(object sender, EventArgs e)
        {
            if (fDangNhap.Quyen == "user")
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnThem.Visible = false;
            }
            DanhSachNhanVien();
            DanhSachDuAn();
            DanhSachPhanCong();
        }

        private void DanhSachPhanCong()
        {
            string maNV = "", maDA = "";
            //lay tt tren GUI
            maNV = "" + cbMaNV.SelectedValue;
            maDA = "" + cboDa.SelectedValue;
            IQueryable<PhanCong> lstPhanCong = Common.Instance.PhanCongs;

            if (!string.IsNullOrEmpty(maNV))
            {
                lstPhanCong = lstPhanCong.Where(p => p.IdNhanVien == maNV);
            }
            if (!string.IsNullOrEmpty(maDA))
            {
                lstPhanCong = lstPhanCong.Where(p => p.IdDuAn == maDA);

            }
            // chỉ hiện thị tt cần thiết
            dgvPhanCong.AutoGenerateColumns = false;
            dgvPhanCong.DataSource = lstPhanCong.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fPhanCongAdd f = new fPhanCongAdd();
            f.ShowDialog();

            //Hiện thị lại ds để xem lại sự thay đổi 
            DanhSachPhanCong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPC = "";
            // chọn hàng ngay click chuột
            maPC = "" + dgvPhanCong.CurrentRow.Cells[0].Value;
            fPhanCongAdd f = new fPhanCongAdd();
            f.PhanCongID = maPC;
            f.ShowDialog();
            //hiện thị lại ds nv
            DanhSachPhanCong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá phân công công việc này không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string maPC = "";
                // chọn hàng ngay click chuột
                maPC = "" + dgvPhanCong.CurrentRow.Cells[0].Value;
                PhanCong objPhanCong = Common.Instance.PhanCongs.Find(maPC);

                if (objPhanCong != null)
                {
                    Common.Instance.PhanCongs.Remove(objPhanCong);
                    Common.Instance.SaveChanges();
                    //HIỆN THỊ LẠI DSNV
                    DanhSachPhanCong();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachPhanCong();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DanhSachDuAn()
        {
            List<DuAn> lstDuAn = Common.Instance.DuAns.ToList();
            lstDuAn.Insert(0, new DuAn() { MaDA = "", TenDA = "--CHỌN DỰ ÁN--" });
            cboDa.DisplayMember = "TenDA";
            cboDa.ValueMember = "MaDA";
            cboDa.DataSource = lstDuAn;

        }

        private void DanhSachNhanVien()
        {
            List<NhanVien> lstNhanVien = Common.Instance.NhanViens.ToList();
            lstNhanVien.Insert(0, new NhanVien() { MaNV = "", HoTen = "--CHỌN NHÂN VIÊN--" });
            cbMaNV.DisplayMember = "HoTen";
            cbMaNV.ValueMember = "MaNV";
            cbMaNV.DataSource = lstNhanVien;

        }
    }
}
