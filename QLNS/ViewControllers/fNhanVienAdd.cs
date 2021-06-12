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
    
    public partial class fNhanVienAdd : Form
    {
        // khai báo biến để giao tiếp form danh sách và thêm mới, sửa
        private string _NhanvienID = null;

        public string NhanvienID { get => _NhanvienID; set => _NhanvienID = value; }

        public fNhanVienAdd()
        {
            InitializeComponent();
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
        private void fNhanVienAdd_Load(object sender, EventArgs e)
        {
            DanhSachPhongBan();
            if (!string.IsNullOrEmpty(_NhanvienID))
            {
                this.Text = "Sửa thông tin nhân viên";
                HienThiChiTietNhanVien();
            }
            else
            {
                this.Text = "Thêm mới thông tin nhân viên";
            }
        }

        private void HienThiChiTietNhanVien()
        {
            NhanVien objNhanVien = Common.Instance.NhanViens.Find(_NhanvienID);
            if(objNhanVien != null)
            {
                // hiện thị thông tin lên giao diện
                txtManv.Text = objNhanVien.MaNV;
                txtManv.ReadOnly = true;

                txtHoten.Text = objNhanVien.HoTen;

                dtpNgaysinh.Value = objNhanVien.NgaySinh;

                txtEmail.Text = objNhanVien.Email;

                txtDiachi.Text = objNhanVien.DiaChi;

                cboPhong.SelectedValue = "" + objNhanVien.PhongBanId;
            }

        }

        
        //Cập nhật thêm mới, xoá,sửa tt nhân viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
   
            if(txtManv.Text == "" || txtHoten.Text == "" || txtEmail.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }
            else
            {
                try
                {
                    bool isInsert = true;
                    NhanVien objNhanVien = null;
                    if (!string.IsNullOrEmpty(_NhanvienID))
                    {
                        objNhanVien = Common.Instance.NhanViens.Find(_NhanvienID);
                    }

                    if (objNhanVien != null)
                    {
                        isInsert = false;
                    }
                    else
                    {
                        objNhanVien = new NhanVien();
                    }
                    objNhanVien.MaNV = txtManv.Text;
                    objNhanVien.HoTen = txtHoten.Text;
                    objNhanVien.NgaySinh = dtpNgaysinh.Value;
                    objNhanVien.Email = txtEmail.Text;
                    objNhanVien.DiaChi = txtDiachi.Text;
                    objNhanVien.PhongBanId = "" + cboPhong.SelectedValue;

                    if (isInsert)
                    {
                        Common.Instance.NhanViens.Add(objNhanVien);
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
           

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
