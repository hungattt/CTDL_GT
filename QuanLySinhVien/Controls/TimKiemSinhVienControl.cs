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
    public partial class TimKiemSinhVienControl : UserControl
    {
        public static LinkedListSV<SinhVien> CSDL_SV = new LinkedListSV<SinhVien>();
        public TimKiemSinhVienControl()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlconn = @"Server=DESKTOP-JRFV3IL\SQLEXPRESS; Database=QLSV; Integrated Security= True";
        

        private void HienThiThongTinSV()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "TimSinhVienTheoMa";
            //command.Connection = conn;
            //SqlParameter para = new SqlParameter("@ma", SqlDbType.NChar);
            //para.Value = txtSearchMSSV.Text;
            //command.Parameters.Add(para);

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SINHVIEN where TenSV LIKE N'%"+txtSearchMSSV.Text+"%' ";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            lvThongTinTimKiem.Items.Clear();
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
                lvThongTinTimKiem.Items.Add(liv);
            }
            reader.Close();
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void NapDaTaSVGioi()
        {
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SINHVIEN where DiemTB >= 8.5 and DiemTB<= 10";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            


            while (reader.Read())
            {
                SinhVien x = new SinhVien();

                x.MaSV = reader.GetValue(0) + "";
                x.TenSV = reader.GetValue(1) + "";
                x.NamSinh = DateTime.Parse(reader.GetValue(2) + "");
                x.GioiTinh =reader.GetValue(3) + "";
                x.DiemToan = float.Parse(reader.GetValue(4) + "");
                x.DiemLy = float.Parse(reader.GetValue(5) + "");
                x.DiemHoa = float.Parse(reader.GetValue(6) + "");
                x.DiemTB = float.Parse(reader.GetValue(7) + "");
                x.MaLop = reader.GetValue(8) + "";
                CSDL_SV.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }

        public void NapDaTaSVKha()
        {
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SINHVIEN where DiemTB >= 7.0 and DiemTB <= 8.4";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                SinhVien x = new SinhVien();

                x.MaSV = reader.GetValue(0) + "";
                x.TenSV = reader.GetValue(1) + "";
                x.NamSinh = DateTime.Parse(reader.GetValue(2) + "");
                x.GioiTinh = reader.GetValue(3) + "";
                x.DiemToan = float.Parse(reader.GetValue(4) + "");
                x.DiemLy = float.Parse(reader.GetValue(5) + "");
                x.DiemHoa = float.Parse(reader.GetValue(6) + "");
                x.DiemTB = float.Parse(reader.GetValue(7) + "");
                x.MaLop = reader.GetValue(8) + "";
                CSDL_SV.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }


        public void NapDaTaSVTrungBinh()
        {
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SINHVIEN where DiemTB >= 5.5 and DiemTB<= 6.9";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                SinhVien x = new SinhVien();

                x.MaSV = reader.GetValue(0) + "";
                x.TenSV = reader.GetValue(1) + "";
                x.NamSinh = DateTime.Parse(reader.GetValue(2) + "");
                x.GioiTinh = reader.GetValue(3) + "";
                x.DiemToan = float.Parse(reader.GetValue(4) + "");
                x.DiemLy = float.Parse(reader.GetValue(5) + "");
                x.DiemHoa = float.Parse(reader.GetValue(6) + "");
                x.DiemTB = float.Parse(reader.GetValue(7) + "");
                x.MaLop = reader.GetValue(8) + "";
                CSDL_SV.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }


        public void NapDaTaSVTBYeu()
        {
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SINHVIEN where DiemTB >= 4.0 and DiemTB<= 5.4";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                SinhVien x = new SinhVien();

                x.MaSV = reader.GetValue(0) + "";
                x.TenSV = reader.GetValue(1) + "";
                x.NamSinh = DateTime.Parse(reader.GetValue(2) + "");
                x.GioiTinh = reader.GetValue(3) + "";
                x.DiemToan = float.Parse(reader.GetValue(4) + "");
                x.DiemLy = float.Parse(reader.GetValue(5) + "");
                x.DiemHoa = float.Parse(reader.GetValue(6) + "");
                x.DiemTB = float.Parse(reader.GetValue(7) + "");
                x.MaLop = reader.GetValue(8) + "";
                CSDL_SV.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }

        public void NapDaTaSVKem()
        {
            // SanPham x = new SanPham();

            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SINHVIEN where DiemTB >= 0.0 and DiemTB<= 3.9";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                SinhVien x = new SinhVien();

                x.MaSV = reader.GetValue(0) + "";
                x.TenSV = reader.GetValue(1) + "";
                x.NamSinh = DateTime.Parse(reader.GetValue(2) + "");
                x.GioiTinh = reader.GetValue(3) + "";
                x.DiemToan = float.Parse(reader.GetValue(4) + "");
                x.DiemLy = float.Parse(reader.GetValue(5) + "");
                x.DiemHoa = float.Parse(reader.GetValue(6) + "");
                x.DiemTB = float.Parse(reader.GetValue(7) + "");
                x.MaLop = reader.GetValue(8) + "";
                CSDL_SV.AddHead(x);

            }
            //CSDL_SP01.AddHead(x);
            reader.Close();
        }
        //-------------------------------------------------------------------------------------------------------------

        public void QuickSort(LinkedListSV<SinhVien> l)
        {
            LinkedListSV<SinhVien> l1 = new LinkedListSV<SinhVien>();
            LinkedListSV<SinhVien> l2 = new LinkedListSV<SinhVien>();
            
            LinkedListSV<SinhVien>.Node tag, p;
            if (l.pHead == l.pTail) return;

            tag = l.pHead;
            l.pHead = l.pHead.pNext; // cap nhat lai l.head
            tag.pNext = null;// co lap tag
            while (l.pHead != null)
            {
                p = l.pHead;
                l.pHead = l.pHead.pNext;
                p.pNext = null;
                if (p.data.DiemTB >= tag.data.DiemTB)

                    l1.AddHead(p.data);
                else
                    l2.AddHead(p.data);
            }
            QuickSort(l1); // goi de qui sap xep l1, l2
            QuickSort(l2);
            if (l1.pHead != null)
            { // l1 k rong
                l.pHead = l1.pHead; // lay head cua l1 gan cho head cua l;
                l1.pTail.pNext = tag;
            } // l1 rong 
            else l.pHead = tag;
            tag.pNext = l2.pHead;
            if (l2.pHead != null) l.pTail = l2.pTail;
            else l.pTail = tag;
        }

        //--------------------------------------------------------------------------------------------------------------------
        private void HienthidanhsachSinhVienGioi()
        {
            NapDaTaSVGioi();
            QuickSort(CSDL_SV);
            lvThongTinTimKiem.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSP = CSDL_SV.pHead;

            while (NodeSP != null)
            {
                ListViewItem lviSV = new ListViewItem(NodeSP.data.MaSV);
                lviSV.SubItems.Add((NodeSP.data.TenSV));
                lviSV.SubItems.Add(NodeSP.data.GioiTinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.NamSinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemToan.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemLy.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemHoa.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemTB.ToString());
                lviSV.SubItems.Add(NodeSP.data.MaLop);
                lvThongTinTimKiem.Items.Add(lviSV);
                NodeSP = NodeSP.pNext;
            }
        }


        private void HienthidanhsachSinhVienKha()
        {
            NapDaTaSVKha();
            QuickSort(CSDL_SV);
            lvThongTinTimKiem.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSP = CSDL_SV.pHead;

            while (NodeSP != null)
            {
                ListViewItem lviSV = new ListViewItem(NodeSP.data.MaSV);
                lviSV.SubItems.Add((NodeSP.data.TenSV));
                lviSV.SubItems.Add(NodeSP.data.GioiTinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.NamSinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemToan.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemLy.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemHoa.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemTB.ToString());
                lviSV.SubItems.Add(NodeSP.data.MaLop);
                lvThongTinTimKiem.Items.Add(lviSV);
                NodeSP = NodeSP.pNext;
            }
        }


        private void HienthidanhsachSinhVienTB()
        {
            NapDaTaSVTrungBinh();
            QuickSort(CSDL_SV);
            lvThongTinTimKiem.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSP = CSDL_SV.pHead;

            while (NodeSP != null)
            {
                ListViewItem lviSV = new ListViewItem(NodeSP.data.MaSV);
                lviSV.SubItems.Add((NodeSP.data.TenSV));
                lviSV.SubItems.Add(NodeSP.data.GioiTinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.NamSinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemToan.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemLy.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemHoa.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemTB.ToString());
                lviSV.SubItems.Add(NodeSP.data.MaLop);
                lvThongTinTimKiem.Items.Add(lviSV);
                NodeSP = NodeSP.pNext;
            }
        }

        private void HienthidanhsachSinhVienTBYeu()
        {
            NapDaTaSVTBYeu();
            QuickSort(CSDL_SV);
            lvThongTinTimKiem.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSP = CSDL_SV.pHead;

            while (NodeSP != null)
            {
                ListViewItem lviSV = new ListViewItem(NodeSP.data.MaSV);
                lviSV.SubItems.Add((NodeSP.data.TenSV));
                lviSV.SubItems.Add(NodeSP.data.GioiTinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.NamSinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemToan.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemLy.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemHoa.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemTB.ToString());
                lviSV.SubItems.Add(NodeSP.data.MaLop);
                lvThongTinTimKiem.Items.Add(lviSV);
                NodeSP = NodeSP.pNext;
            }
        }


        private void HienthidanhsachSinhVienKem()
        {
            NapDaTaSVKem();
            QuickSort(CSDL_SV);
            lvThongTinTimKiem.Items.Clear();
            LinkedListSV<SinhVien>.Node NodeSP = CSDL_SV.pHead;

            while (NodeSP != null)
            {
                ListViewItem lviSV = new ListViewItem(NodeSP.data.MaSV);
                lviSV.SubItems.Add((NodeSP.data.TenSV));
                lviSV.SubItems.Add(NodeSP.data.GioiTinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.NamSinh.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemToan.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemLy.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemHoa.ToString());
                lviSV.SubItems.Add(NodeSP.data.DiemTB.ToString());
                lviSV.SubItems.Add(NodeSP.data.MaLop);
                
                lvThongTinTimKiem.Items.Add(lviSV);
                NodeSP = NodeSP.pNext;
            }
        }

       
        //----------------------------------------------------------------------KQ----------------------------------------------------------------------

           private void btTimKiem_Click(object sender, EventArgs e)
           {
               string x = "";
                if (txtSearchMSSV != null)
                {
                    HienThiThongTinSV();
                //if (lvThongTinTimKiem.Items.Count == 0)
                //{
                //    MessageBox.Show("Mã sinh viên không tồn tại !!!");
                //}
                    txtSearchMSSV.Text = x;
                    CSDL_SV.deleteAll();
                    
                }
             if(cbHocLuc.Text=="Gioi")
            {
                HienthidanhsachSinhVienGioi();
                cbHocLuc.Text = x;
                CSDL_SV.deleteAll();
            }
            else if (cbHocLuc.Text == "Kha")
            {
                HienthidanhsachSinhVienKha();
                cbHocLuc.Text = x;
                CSDL_SV.deleteAll();
            }
            else if (cbHocLuc.Text == "TrungBinh")
            {
                HienthidanhsachSinhVienTB();
                cbHocLuc.Text = x;
                CSDL_SV.deleteAll();
            }
            else if (cbHocLuc.Text == "TrungBinh-Yeu")
            {
                HienthidanhsachSinhVienTBYeu();
                cbHocLuc.Text = x;
                CSDL_SV.deleteAll();
            }

            else if (cbHocLuc.Text == "Kem")
            {
                HienthidanhsachSinhVienKem();
                cbHocLuc.Text = x;
                CSDL_SV.deleteAll();
            }



        }

        
    }
}
