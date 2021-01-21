using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLySinhVien
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string con_str = @"Data source = DESKTOP-JRFV3IL\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            conn.Open();
            string username = txbName.Text;
            string password = txbPass.Text;
            string query = "Select Count(*) from DangNhap Where TaiKhoan='" + username + "' and  MatKhau='" + password + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            int soluong = int.Parse(cmd.ExecuteScalar().ToString());
           
            conn.Close();
            if (soluong == 0)
            {
                if (MessageBox.Show("đăng nhập thất bại , bạn có muốn đăng nhập lại không  !!", "Đăng Nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    txbName.Focus();
                }
                else
                {
                    Close();
                    //System.Windows.Forms.Application.Exit();
                }
                }
            else
            {
               
                Form1 frm1= new Form1();
                frm1.Show();
                this.Hide();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc muốn thoát không  !!", "Thoát ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                System.Windows.Forms.Application.Exit();
            }
        }

        
    }
}
