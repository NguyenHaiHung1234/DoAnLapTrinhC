using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DOAN
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NguyenHaiHung_2121110142\DOAN\DOAN\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM  Login1 WHERE Username = '" + txtDangNhap.Text.Trim() +
                        "' AND Password = '" + txtMatKhau.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        frmMain form1 = new frmMain();
                        this.Hide();
                        form1.Show();
                    }
                }
            }
        }
        private bool isValid()
        {
            if (txtDangNhap.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ!", "Error");
              return false;
            }  else if (txtMatKhau.Text.TrimStart() == string.Empty)
            {

                MessageBox.Show("Vui lòng nhập mật khẩu hợp lệ!", "Error");
                return false;
            }
          
            return true;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
