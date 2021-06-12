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
    public partial class fPhongBanAdd : Form
    {
        // khai báo biến để giao tiếp form danh sách và thêm mới, sửa
        private string _PhongBanID = null;

        public string PhongBanID { get => _PhongBanID; set => _PhongBanID = value; }
        public fPhongBanAdd()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text == "" || txtTenPB.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    bool isInsert = true;
                    PhongBan objPhongBan = null;
                    if (!string.IsNullOrEmpty(_PhongBanID))
                    {
                        objPhongBan = Common.Instance.PhongBans.Find(_PhongBanID);
                    }

                    if (objPhongBan != null)
                    {
                        isInsert = false;
                    }
                    else
                    {
                        objPhongBan = new PhongBan();
                    }
                    objPhongBan.MaPhong = txtMaPB.Text;
                    objPhongBan.TenPhong = txtTenPB.Text;


                    if (isInsert)
                    {
                        Common.Instance.PhongBans.Add(objPhongBan);
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

        private void fPhongBanAdd_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_PhongBanID))
            {
                this.Text = "Sửa thông tin phòng ban";
                HienThiChiTietPhongBan();
            }
            else
            {
                this.Text = "Thêm mới thông tin phòng ban";
            }
        }
        private void HienThiChiTietPhongBan()
        {
            PhongBan objPhongBan = Common.Instance.PhongBans.Find(_PhongBanID);
            if (objPhongBan != null)
            {
                // hiện thị thông tin lên giao diện
                txtMaPB.Text = objPhongBan.MaPhong;
                txtMaPB.ReadOnly = true;
                txtTenPB.Text = objPhongBan.TenPhong;
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
