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
    public partial class fDuAn : Form
    {
        public fDuAn()
        {
            InitializeComponent();
        }

        // hiện thị dspb
        private void DanhSachDuAn()
        {
            string duan = "", mp = "";
            //lay tt tren GUI
            duan = txtTimKiemDA.Text.Trim();
            mp = "" + cboPbDa.SelectedValue;
            IQueryable<DuAn> lstDuAn = Common.Instance.DuAns;

            if (!string.IsNullOrEmpty(duan))
            {
                lstDuAn = lstDuAn.Where(p => p.MaDA.Contains(duan));
            }
            if (!string.IsNullOrEmpty(mp))
            {
                lstDuAn = lstDuAn.Where(p => p.PhongBanId == mp);

            }
            // chỉ hiện thị tt cần thiết
            dvgDuAn.AutoGenerateColumns = false;
            dvgDuAn.DataSource = lstDuAn.ToList();
        }

        private void btnThemDA_Click(object sender, EventArgs e)
        {
            fDuAnAdd f = new fDuAnAdd();
            f.ShowDialog();

            //Hiện thị lại ds để xem lại sự thay đổi 
            DanhSachDuAn();
        }

        private void btnSuaDA_Click(object sender, EventArgs e)
        {
            string mada = "";
            // chọn hàng ngay click chuột
            mada = "" + dvgDuAn.CurrentRow.Cells[0].Value;
            fDuAnAdd f = new fDuAnAdd();
            f.DuAnID = mada;
            f.ShowDialog();
            //hiện thị lại ds nv
            DanhSachDuAn();
        }

        private void btnXoaDA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá dự án này không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string mada = "";
                // chọn hàng ngay click chuột
                mada = "" + dvgDuAn.CurrentRow.Cells[0].Value;
                DuAn objDuAn = Common.Instance.DuAns.Find(mada);

                if (objDuAn != null)
                {
                    Common.Instance.DuAns.Remove(objDuAn);
                    Common.Instance.SaveChanges();
                    //HIỆN THỊ LẠI DSNV
                    DanhSachDuAn();
                }
            }
        }

        private void btnDongDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemDA_Click(object sender, EventArgs e)
        {
            DanhSachDuAn();
        }

        private void fDuAn_Load(object sender, EventArgs e)
        {
            DanhSachDuAn();
            DanhSachPhongBan();
        }

        // hiện thị ds pb
        private void DanhSachPhongBan()
        {
            List<PhongBan> lstPhongBan = Common.Instance.PhongBans.ToList();
            lstPhongBan.Insert(0, new PhongBan() { MaPhong = "", TenPhong = "--CHỌN PHÒNG--" });
            cboPbDa.DisplayMember = "TenPhong";
            cboPbDa.ValueMember = "MaPhong";
            cboPbDa.DataSource = lstPhongBan;

        }
    }
}
