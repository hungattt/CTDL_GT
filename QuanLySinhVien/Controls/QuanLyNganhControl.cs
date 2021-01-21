using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class QuanLyNganhControl : UserControl
    {
        public QuanLyNganhControl()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn = @"Server=DESKTOP-JRFV3IL\SQLEXPRESS; Database=QLSV; Integrated Security= True";
        
        private void ClearTextBox()
        {
            string x = "";
            txtMaNganh.Text = x;
            txtTenNganh.Text = x;
        }
        
        private void HienThiLenLvNganh()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoKhoa";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongTinNganh.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                lvThongTinNganh.Items.Add(liv);
            }
            reader.Close();
        }

        private void lvThongTinNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTinNganh.SelectedItems.Count == 0) return;

            ListViewItem liv = lvThongTinNganh.SelectedItems[0];
            string ma = liv.SubItems[0].Text;
            HienThiLenTextBox(ma);
        }

        private void HienThiLenTextBox(string ma)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChiTietKhoa";
            command.Connection = conn;
            SqlParameter para = new SqlParameter("@ma", SqlDbType.NChar);
            para.Value = ma;
            command.Parameters.Add(para);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMaNganh.Text = reader.GetValue(0) + "";
                txtTenNganh.Text = reader.GetValue(1) + "";
             
            }
            reader.Close();
        }

        private void btnAddNganh_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemKhoa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaNganh.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenNganh.Text;
          
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {   HienThiLenLvNganh();
                MessageBox.Show("thim da them thanh cong ");
                
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da them that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatKhoaTheoMa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaNganh.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenNganh.Text;
           

            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiLenLvNganh();
                MessageBox.Show("thim da cap nhat thanh cong ");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da cap nhat that bai");
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaKhoaTheoMa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaNganh.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiLenLvNganh();
                MessageBox.Show("thim da xoa thanh cong");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("xoa tha bai ");
            }
        }

        private void QuanLyNganhControl_Load(object sender, EventArgs e)
        {
            HienThiLenLvNganh();
        }
    }
}
