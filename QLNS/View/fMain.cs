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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            AddForm(f);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhongBan f = new fPhongBan();
            AddForm(f);
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDuAn f = new fDuAn();
            AddForm(f);
        }
    }
}
