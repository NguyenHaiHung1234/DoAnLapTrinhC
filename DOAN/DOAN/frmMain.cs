using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN.Class;

namespace DOAN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu(); //Khởi tạo đối tượng
            frm.MdiParent = this;
            frm.Show(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.Show();
        }
    }
}
