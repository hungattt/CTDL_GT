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
    public partial class QuanLyLopHocControl : UserControl
    {


        SqlConnection conn = null;
        string sqlconn = @"Server=DESKTOP-JRFV3IL\SQLEXPRESS; Database=QLSV; Integrated Security= True";
        public QuanLyLopHocControl()
        {           
            InitializeComponent();
            ViewCombox();
        }

        private void QuanLyLopHocControl_Load(object sender, EventArgs e)
        {
            HienThiThongTinLopHoc();
            HienThiTV();
        }

        private void HienThiThongTinLopHoc()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoLop";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvDanhSachLop.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                liv.SubItems.Add(reader.GetValue(2) + "");
                lvDanhSachLop.Items.Add(liv);
            }
            reader.Close();
        }

        private void  ClearTextBox()
        {
            string x = "";
            cbNganh.Text = x;
            txtMaLop.Text = x;
            txtTenLop.Text = x;

        }
        private void ViewCombox()
        {
            try
            {


                if (conn == null)
                    conn = new SqlConnection(sqlconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LayToanBoMaKhoa";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                cbNganh.Items.Clear();

                while (reader.Read())
                {
                    string makhoa = reader.GetValue(0) + "";

                    cbNganh.Items.Add(makhoa);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi roi !!!" + ex.Message);
            }
        }
        private void  HienThiLenTreeView()
        {

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select TenKhoa From Khoa";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            tvNganh.Nodes.Clear();
            
            
            //    Khoa kh = itemkhoa.Value;
            //    TreeNode nodekhoa = new TreeNode(kh.TenKhoa);
            //    nodekhoa.Tag = kh;// dung tag de luu khoa 
            //    tvkhoa.Nodes.Add(nodekhoa);

            //    foreach (KeyValuePair<string, LopHoc> itemlop in kh.Lops)
            //    {
            //        LopHoc lp = itemlop.Value;
            //        TreeNode nodelop = new TreeNode(lp.TenLop);
            //        nodelop.Tag = lp;// dung tag de luu lop
            //        nodekhoa.Nodes.Add(nodelop);

            //    }
            
            //tvkhoa.ExpandAll();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemLop";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaLop.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenLop.Text;
            command.Parameters.Add("@makhoa", SqlDbType.NChar).Value = cbNganh.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("thim da them thanh cong ");
                HienThiThongTinLopHoc();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da them that bai");
            }
        }


       

        private void HienThiLenTextBox(string ma)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChiTietLop";
            command.Connection = conn;
            SqlParameter para = new SqlParameter("@ma", SqlDbType.NChar);
            para.Value = ma;
            command.Parameters.Add(para);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMaLop.Text = reader.GetValue(0) + "";
                txtTenLop.Text = reader.GetValue(1) + "";
                cbNganh.Text = reader.GetValue(2) + "";


            }
            reader.Close();
        }

        private void lvDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachLop.SelectedItems.Count == 0) return;

            ListViewItem liv = lvDanhSachLop.SelectedItems[0];
            string ma = liv.SubItems[0].Text;
            HienThiLenTextBox(ma);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatLopTheoMa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaLop.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTenLop.Text;
            command.Parameters.Add("@makhoa", SqlDbType.NChar).Value = cbNganh.Text;


            int ret = command.ExecuteNonQuery();//tra ve so dong bi thay doi 
            if (ret > 0)
            {
                HienThiThongTinLopHoc();
                MessageBox.Show("thim da cap nhat thanh cong ");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("thim da cap nhat that bai");
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaLopTheoMa";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.NChar).Value = txtMaLop.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiThongTinLopHoc();
                MessageBox.Show("thim da xoa thanh cong");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("xoa tha bai ");
            }
        }


        private DataTable TruyVan(string sql , SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            return dt;
        }

        public void HienThiTV()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            DataTable NodeCha = new DataTable();
            DataTable NodeCon = new DataTable();

            NodeCha = TruyVan("Select MaKhoa from Khoa", conn);

            for(int i=0;i<NodeCha.Rows.Count;i++)
            {
                tvNganh.Nodes.Add(NodeCha.Rows[i][0].ToString());
                tvNganh.Nodes[i].Tag = "1";

                NodeCon = TruyVan("Select MaLop from LOP where MaKhoa= N'" + NodeCha.Rows[i][0].ToString() + " '  ", conn);
                for(int j=0;j<NodeCon.Rows.Count;j++)
                {
                    tvNganh.Nodes[i].Nodes.Add(NodeCon.Rows[j][0].ToString());
                    tvNganh.Nodes[i].Nodes[j].Tag = "2";
                }

            }
        }

        private void HienThiThongTinLopHoc1(string sql)
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvDanhSachLop.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetValue(0) + "");
                liv.SubItems.Add(reader.GetValue(1) + "");
                liv.SubItems.Add(reader.GetValue(2) + "");
                lvDanhSachLop.Items.Add(liv);
            }
            reader.Close();
        }



        private void tvNganh_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode trNode = this.tvNganh.SelectedNode;

            //if (trNode.Tag =="1")// level==1 nghia la chon lop (khoa =0,lop=1,sinhvien=2)=> hien thi ds sinh vien ra 
          // {
                string sql = "select * from LOP where MaKhoa=N' " + trNode.Text + " ' ";
            //HienThiThongTinLopHoc1(sql);
            //}
            //else if (trNode.Tag == "1")
            //{
            //    string sql = "select * from LOP where MaKhoa=N' " + trNode.ToString() + " ' ";
            //    HienThiThongTinLopHoc1(sql);
            //}   N' " + trNode.Text+ " '
        }





    }
}
