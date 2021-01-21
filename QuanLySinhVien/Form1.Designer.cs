namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManHinhChinh = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQLLH = new System.Windows.Forms.Button();
            this.btnQLN = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnShow = new System.Windows.Forms.Panel();
            this.inAnControl11 = new QuanLySinhVien.Controls.InAnControl1();
            this.manHinhChinhControl1 = new QuanLySinhVien.ManHinhChinhControl();
            this.timKiemSinhVienControl1 = new QuanLySinhVien.TimKiemSinhVienControl();
            this.quanLyNganhControl1 = new QuanLySinhVien.QuanLyNganhControl();
            this.quanLyLopHocControl1 = new QuanLySinhVien.QuanLyLopHocControl();
            this.quanLySinhVienControl1 = new QuanLySinhVien.QuanLySinhVienControl();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnShow.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnManHinhChinh);
            this.panel1.Controls.Add(this.btnQLSV);
            this.panel1.Controls.Add(this.btnQLLH);
            this.panel1.Controls.Add(this.btnQLN);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnSearchSV);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 862);
            this.panel1.TabIndex = 0;
            // 
            // btnManHinhChinh
            // 
            this.btnManHinhChinh.BackColor = System.Drawing.Color.Navy;
            this.btnManHinhChinh.FlatAppearance.BorderSize = 0;
            this.btnManHinhChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManHinhChinh.ForeColor = System.Drawing.Color.White;
            this.btnManHinhChinh.Location = new System.Drawing.Point(57, 193);
            this.btnManHinhChinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnManHinhChinh.Name = "btnManHinhChinh";
            this.btnManHinhChinh.Size = new System.Drawing.Size(240, 46);
            this.btnManHinhChinh.TabIndex = 0;
            this.btnManHinhChinh.Text = "     Màn hình chính";
            this.btnManHinhChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManHinhChinh.UseVisualStyleBackColor = false;
            this.btnManHinhChinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.Color.Navy;
            this.btnQLSV.FlatAppearance.BorderSize = 0;
            this.btnQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.ForeColor = System.Drawing.Color.White;
            this.btnQLSV.Location = new System.Drawing.Point(57, 311);
            this.btnQLSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(240, 46);
            this.btnQLSV.TabIndex = 1;
            this.btnQLSV.Text = "     Quản lý sinh viên";
            this.btnQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLLH
            // 
            this.btnQLLH.BackColor = System.Drawing.Color.Navy;
            this.btnQLLH.FlatAppearance.BorderSize = 0;
            this.btnQLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLH.ForeColor = System.Drawing.Color.White;
            this.btnQLLH.Location = new System.Drawing.Point(57, 427);
            this.btnQLLH.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Size = new System.Drawing.Size(240, 46);
            this.btnQLLH.TabIndex = 2;
            this.btnQLLH.Text = "     Quản lý lớp học";
            this.btnQLLH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLH.UseVisualStyleBackColor = false;
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnQLN
            // 
            this.btnQLN.BackColor = System.Drawing.Color.Navy;
            this.btnQLN.FlatAppearance.BorderSize = 0;
            this.btnQLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLN.ForeColor = System.Drawing.Color.White;
            this.btnQLN.Location = new System.Drawing.Point(63, 531);
            this.btnQLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLN.Name = "btnQLN";
            this.btnQLN.Size = new System.Drawing.Size(234, 46);
            this.btnQLN.TabIndex = 3;
            this.btnQLN.Text = "     Quản lý ngành";
            this.btnQLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLN.UseVisualStyleBackColor = false;
            this.btnQLN.Click += new System.EventHandler(this.btnQLN_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Navy;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(57, 754);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(240, 46);
            this.btnIn.TabIndex = 5;
            this.btnIn.TabStop = false;
            this.btnIn.Text = "In - Xuất File ";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.BackColor = System.Drawing.Color.Navy;
            this.btnSearchSV.FlatAppearance.BorderSize = 0;
            this.btnSearchSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSV.ForeColor = System.Drawing.Color.White;
            this.btnSearchSV.Location = new System.Drawing.Point(60, 636);
            this.btnSearchSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(237, 46);
            this.btnSearchSV.TabIndex = 4;
            this.btnSearchSV.Text = "     Tìm kiếm sinh viên";
            this.btnSearchSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSV.UseVisualStyleBackColor = false;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.pnShow);
            this.panel5.Controls.Add(this.pnTop);
            this.panel5.Location = new System.Drawing.Point(303, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1476, 858);
            this.panel5.TabIndex = 2;
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.SystemColors.Control;
            this.pnShow.BackgroundImage = global::QuanLySinhVien.Properties.Resources.laptop_sinh_vien_ok_800x450;
            this.pnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShow.Controls.Add(this.inAnControl11);
            this.pnShow.Controls.Add(this.manHinhChinhControl1);
            this.pnShow.Controls.Add(this.timKiemSinhVienControl1);
            this.pnShow.Controls.Add(this.quanLyNganhControl1);
            this.pnShow.Controls.Add(this.quanLyLopHocControl1);
            this.pnShow.Controls.Add(this.quanLySinhVienControl1);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShow.Location = new System.Drawing.Point(0, 124);
            this.pnShow.Margin = new System.Windows.Forms.Padding(4);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1476, 734);
            this.pnShow.TabIndex = 1;
            // 
            // inAnControl11
            // 
            this.inAnControl11.BackColor = System.Drawing.Color.Chartreuse;
            this.inAnControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inAnControl11.Location = new System.Drawing.Point(0, 0);
            this.inAnControl11.Name = "inAnControl11";
            this.inAnControl11.Size = new System.Drawing.Size(1476, 734);
            this.inAnControl11.TabIndex = 5;
            // 
            // manHinhChinhControl1
            // 
            this.manHinhChinhControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manHinhChinhControl1.Location = new System.Drawing.Point(0, 0);
            this.manHinhChinhControl1.Margin = new System.Windows.Forms.Padding(5);
            this.manHinhChinhControl1.Name = "manHinhChinhControl1";
            this.manHinhChinhControl1.Size = new System.Drawing.Size(1476, 734);
            this.manHinhChinhControl1.TabIndex = 4;
            // 
            // timKiemSinhVienControl1
            // 
            this.timKiemSinhVienControl1.BackColor = System.Drawing.Color.White;
            this.timKiemSinhVienControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timKiemSinhVienControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemSinhVienControl1.Location = new System.Drawing.Point(0, 0);
            this.timKiemSinhVienControl1.Margin = new System.Windows.Forms.Padding(5);
            this.timKiemSinhVienControl1.Name = "timKiemSinhVienControl1";
            this.timKiemSinhVienControl1.Size = new System.Drawing.Size(1476, 734);
            this.timKiemSinhVienControl1.TabIndex = 3;
            // 
            // quanLyNganhControl1
            // 
            this.quanLyNganhControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNganhControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNganhControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLyNganhControl1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLyNganhControl1.Name = "quanLyNganhControl1";
            this.quanLyNganhControl1.Size = new System.Drawing.Size(1476, 734);
            this.quanLyNganhControl1.TabIndex = 2;
            // 
            // quanLyLopHocControl1
            // 
            this.quanLyLopHocControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyLopHocControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLyLopHocControl1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLyLopHocControl1.Name = "quanLyLopHocControl1";
            this.quanLyLopHocControl1.Size = new System.Drawing.Size(1476, 734);
            this.quanLyLopHocControl1.TabIndex = 1;
            // 
            // quanLySinhVienControl1
            // 
            this.quanLySinhVienControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLySinhVienControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLySinhVienControl1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLySinhVienControl1.Name = "quanLySinhVienControl1";
            this.quanLySinhVienControl1.Size = new System.Drawing.Size(1476, 734);
            this.quanLySinhVienControl1.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1476, 124);
            this.pnTop.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbTitle.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(606, 44);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(273, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Màn hình chính";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1779, 862);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnShow.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQLLH;
        private System.Windows.Forms.Button btnQLN;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.Button btnManHinhChinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private QuanLySinhVienControl quanLySinhVienControl1;
        private QuanLyLopHocControl quanLyLopHocControl1;
        private QuanLyNganhControl quanLyNganhControl1;
        private TimKiemSinhVienControl timKiemSinhVienControl1;
        private ManHinhChinhControl manHinhChinhControl1;
        private Controls.InAnControl1 inAnControl11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
       
   }

