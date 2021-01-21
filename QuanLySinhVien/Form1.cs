using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            manHinhChinhControl1.BringToFront();
            lbTitle.Text = "Màn hình chính";
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            quanLySinhVienControl1.BringToFront();
            lbTitle.Text = "Quản lý sinh viên";
           
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            quanLyLopHocControl1.BringToFront();
            lbTitle.Text = "Quản lý lớp học";
         
        }

        private void btnQLN_Click(object sender, EventArgs e)
        {
            quanLyNganhControl1.BringToFront();
            lbTitle.Text = "Quản lý  ngành";

        }
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            timKiemSinhVienControl1.BringToFront();
            lbTitle.Text = "Tìm kiếm sinh viên";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manHinhChinhControl1.BringToFront();
            lbTitle.Text = "Màn hình chính";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            inAnControl11.BringToFront();
            lbTitle.Text = " In - Xuất File";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
