using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DOAN
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
            Application.Run(new frmMain());
            Application.Run(new frmDMChatLieu());
            Application.Run(new frmDMHangHoa());
            Application.Run(new frmDMKhachHang());
            Application.Run(new frmDMNhanVien());
            Application.Run(new frmHoaDonBan());
           
        }
    }
}
