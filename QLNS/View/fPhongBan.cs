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
    public partial class fPhongBan : Form
    {
        public fPhongBan()
        {
            InitializeComponent();
        }

        private void fPhongBan_Load(object sender, EventArgs e)
        {
            DanhSachPhongBan();
        }

        // hiện thị dspb
        private void DanhSachPhongBan()
        {
            string maphong = "";
            //lay tt tren GUI
            maphong = txtPhongBan.Text.Trim();
    
            IQueryable<PhongBan> lstPhongBan = Common.Instance.PhongBans;

            if (!string.IsNullOrEmpty(maphong))
            {
                lstPhongBan = lstPhongBan.Where(p => p.MaPhong.Contains(maphong));
            }
           
            // chỉ hiện thị tt cần thiết
            dgvPhongBan.AutoGenerateColumns = false;
            dgvPhongBan.DataSource = lstPhongBan.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fPhongBanAdd f = new fPhongBanAdd();
            f.ShowDialog();

            //Hiện thị lại ds để xem lại sự thay đổi 
            DanhSachPhongBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mapb = "";
            // chọn hàng ngay click chuột
            mapb = "" + dgvPhongBan.CurrentRow.Cells[0].Value;
            fPhongBanAdd f = new fPhongBanAdd();
            f.PhongBanID = mapb;
            f.ShowDialog();
            //hiện thị lại ds nv
            DanhSachPhongBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá phòng ban này không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string mapb = "";
                // chọn hàng ngay click chuột
                mapb = "" + dgvPhongBan.CurrentRow.Cells[0].Value;
                PhongBan objPhongBan = Common.Instance.PhongBans.Find(mapb);

                if (objPhongBan != null)
                {
                    Common.Instance.PhongBans.Remove(objPhongBan);
                    Common.Instance.SaveChanges();
                    //HIỆN THỊ LẠI DSNV
                    DanhSachPhongBan();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DanhSachPhongBan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
