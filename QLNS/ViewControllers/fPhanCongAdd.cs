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
    public partial class fPhanCongAdd : Form
    {
        // khai báo biến để giao tiếp form danh sách và thêm mới, sửa
        private string _PhanCongID = null;

        public string PhanCongID { get => _PhanCongID; set => _PhanCongID = value; }
        public fPhanCongAdd()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool isInsert = true;
                PhanCong objPhanCong = null;
                if (!string.IsNullOrEmpty(_PhanCongID))
                {
                    objPhanCong = Common.Instance.PhanCongs.Find(_PhanCongID);
                }

                if (objPhanCong != null)
                {
                    isInsert = false;
                }
                else
                {
                    objPhanCong = new PhanCong();
                }
                objPhanCong.Id = txtMaPC.Text;
                objPhanCong.IdNhanVien = "" + cboMaNV.SelectedValue;
                objPhanCong.IdDuAn = "" + cboMaDA.SelectedValue;

                if (isInsert)
                {
                    Common.Instance.PhanCongs.Add(objPhanCong);
                }

                //Luu su thay doi
                Common.Instance.SaveChanges();
                MessageBox.Show("Lưu thông tin thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fPhanCongAdd_Load(object sender, EventArgs e)
        {
            DanhSachNhanVien();
            DanhSachDuAn();
            if (!string.IsNullOrEmpty(_PhanCongID))
            {
                this.Text = "Sửa phân công công việc";
                HienThiChiTietPhanCong();
            }
            else
            {
                this.Text = "Thêm mới phân công công việc";
            }
        }

        private void HienThiChiTietPhanCong()
        {
            PhanCong objPhanCong = Common.Instance.PhanCongs.Find(_PhanCongID);
            if (objPhanCong != null)
            {
                // hiện thị thông tin lên giao diện
                txtMaPC.Text = objPhanCong.Id;
                txtMaPC.ReadOnly = true;
                cboMaNV.SelectedValue = "" + objPhanCong.IdNhanVien;
                cboMaDA.SelectedValue = "" + objPhanCong.IdDuAn;
            }

        }

        private void DanhSachNhanVien()
        {
            List<NhanVien> lstNhanVien = Common.Instance.NhanViens.ToList();
            lstNhanVien.Insert(0, new NhanVien() { MaNV = "", HoTen = "--TÊN NHÂN VIÊN--" });
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.DataSource = lstNhanVien;

        }
        private void DanhSachDuAn()
        {
            List<DuAn> lstDuAn = Common.Instance.DuAns.ToList();
            lstDuAn.Insert(0, new DuAn() { MaDA = "", TenDA = "--TÊN DỰ ÁN--" });
            cboMaDA.DisplayMember = "TenDA";
            cboMaDA.ValueMember = "MaDA";
            cboMaDA.DataSource = lstDuAn;

        }
    }
}
