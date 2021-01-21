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
using System.Data.SqlTypes;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVienControl : UserControl
    {
       
        public QuanLySinhVienControl()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn = @"Server=DESKTOP-JRFV3IL\SQLEXPRESS; Database=QLSV; Integrated Security= True";
        private void ClearTextBox()
        {
            string x = "";
            txbMSSV.Text = x;
            txbTenSinhVien.Text = x;
            txbDiemToan.Text = x;
            txbDiemLy.Text = x;
            txbDiemHoa.Text = x;
            cbxMalop.Text = x;

        }
        private void HienThiSinhVIen()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoSinhVien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongTinSV.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                liv.SubItems.Add(reader.GetValue(3) + "");
                liv.SubItems.Add(reader.GetValue(2) + "");
                liv.SubItems.Add(reader.GetValue(4) + "");
                liv.SubItems.Add(reader.GetValue(5) + "");
                liv.SubItems.Add(reader.GetValue(6) + "");
                liv.SubItems.Add(reader.GetValue(7) + "");
                liv.SubItems.Add(reader.GetValue(8) + "");
                lvThongTinSV.Items.Add(liv);
            }
            reader.Close();
        }

        
         
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSinhVien";
            command.Connection = conn;
           
            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txbMSSV.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txbTenSinhVien.Text;
            string gender = "";
            if (radNam.Checked == true)
            {
                gender = "Nam";
                

            }
            if (radNu.Checked == true)
            {
                gender = "Nu";
                
            }

            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@namsinh", SqlDbType.Date).Value =dateTimePicker1.Value.ToString() ;
            command.Parameters.Add("@diemtoan", SqlDbType.Float).Value = txbDiemToan.Text;
            command.Parameters.Add("@diemly", SqlDbType.Float).Value = txbDiemLy.Text;
            command.Parameters.Add("@diemhoa", SqlDbType.Float).Value = txbDiemHoa.Text;
            command.Parameters.Add("@diemtb", SqlDbType.Float).Value = ((float.Parse(txbDiemToan.Text) + float.Parse(txbDiemLy.Text) + float.Parse(txbDiemHoa.Text) )/ 3);
            command.Parameters.Add("@malop", SqlDbType.NChar).Value = cbxMalop.Text;
            
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {  
                HienThiSinhVIen();
                MessageBox.Show("thim da them thanh cong ");

                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da them that bai");
            }
        }

       

        private void lvThongTinSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTinSV.SelectedItems.Count == 0) return;

            ListViewItem liv = lvThongTinSV.SelectedItems[0];
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
            command.CommandText = "ChiTietSinhVienTheoMa";
            command.Connection = conn;
            SqlParameter para = new SqlParameter("@ma", SqlDbType.NChar);
            para.Value = ma;
            command.Parameters.Add(para);
            //command.Parameters.Add("@ma", SqlDbType.NChar).Value = ma;



            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txbMSSV.Text = reader.GetValue(0) + "";
                txbTenSinhVien.Text = reader.GetValue(1) + "";
                txbDiemToan.Text = reader.GetValue(4) + "";
                txbDiemLy.Text = reader.GetValue(5) + "";
                txbDiemHoa.Text = reader.GetValue(6) + "";
               
            }
            reader.Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatSinhVien";
            command.Connection = conn;
            string gender = "";
            if (radNam.Checked == true)
            {
                gender = "Nam";
                // =1 thì char hay cái gì thì tùy thí chủ
            }
            if (radNu.Checked == true)
            {
                gender = "Nu";
                // hay radioButton2.Text.. tùy bác làm gì thì làm
            }
            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txbMSSV.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txbTenSinhVien.Text;
            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@namsinh", SqlDbType.Date).Value = dateTimePicker1.Value.ToString();
            command.Parameters.Add("@diemtoan", SqlDbType.Float).Value = txbDiemToan.Text;
            command.Parameters.Add("@diemly", SqlDbType.Float).Value = txbDiemLy.Text;
            command.Parameters.Add("@diemhoa", SqlDbType.Float).Value = txbDiemHoa.Text;
            command.Parameters.Add("@diemtb", SqlDbType.Float).Value = ((float.Parse(txbDiemToan.Text) + float.Parse(txbDiemLy.Text) + float.Parse(txbDiemHoa.Text)) / 3);
            command.Parameters.Add("@malop", SqlDbType.NChar).Value = cbxMalop.Text;


            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiSinhVIen();
                MessageBox.Show("thim da cap nhat thanh cong ");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da cap nhat that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaSinhVienTheoMa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txbMSSV.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSinhVIen();
                MessageBox.Show("thim da xoa thanh cong");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("xoa that bai ");
            }
        }

        private void QuanLySinhVienControl_Load(object sender, EventArgs e)
        {
            HienThiSinhVIen();
            try
            {


                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LayToanBoMaLop";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                cbxMalop.Items.Clear();

                while (reader.Read())
                {
                    string malop = reader.GetValue(0) + "";

                    cbxMalop.Items.Add(malop);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi roi !!!" + ex.Message);
            }
        }

        
    }
}
