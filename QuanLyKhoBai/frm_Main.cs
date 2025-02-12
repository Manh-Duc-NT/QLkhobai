using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoBai
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void NguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NguoiDung nForm = new frm_NguoiDung();
             //nForm.MdiParent = this;
             nForm.Show();
        }

        private void QuanLyTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tram nForm = new frm_Tram();
            //nForm.MdiParent = this;
            nForm.Show();
        }
        private void QuanLyDangKyTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangKyTram nForm = new frm_DangKyTram();
            //nForm.MdiParent = this;
            nForm.Show();
        }

        private void QuanLyLuanChuyenTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LuanChuyenTram nForm = new frm_LuanChuyenTram();
            //nForm.MdiParent = this;
            nForm.Show();
        }

    }
}
