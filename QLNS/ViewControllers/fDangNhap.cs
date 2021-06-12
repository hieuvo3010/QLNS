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
    public partial class fDangNhap : Form
    {
        public static string Quyen;
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
          
            //if(tk != "" || mk != "")
            //{

            using (QLNSContext db = new QLNSContext())
            {
                var check = Common.Instance.TaiKhoans.Where(p => p.TenDangNhap == tk && p.MatKhau == mk).FirstOrDefault();

                

                if (check != null)
                {
                    Quyen = check.Quyen;
                    fMain f = new fMain();           
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại","Thông báo");
                }

            }




        }
    }
}
