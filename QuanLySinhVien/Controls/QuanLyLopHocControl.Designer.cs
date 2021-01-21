using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace QuanLySinhVien
{
    partial class QuanLyLopHocControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDanhSachNganh = new System.Windows.Forms.GroupBox();
            this.tvNganh = new System.Windows.Forms.TreeView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.lvDanhSachLop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.grbDanhSachNganh.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbDanhSachLop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDanhSachNganh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 636);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhSachNganh
            // 
            this.grbDanhSachNganh.BackColor = System.Drawing.Color.White;
            this.grbDanhSachNganh.Controls.Add(this.tvNganh);
            this.grbDanhSachNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbDanhSachNganh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachNganh.ForeColor = System.Drawing.Color.Navy;
            this.grbDanhSachNganh.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachNganh.Margin = new System.Windows.Forms.Padding(4);
            this.grbDanhSachNganh.Name = "grbDanhSachNganh";
            this.grbDanhSachNganh.Padding = new System.Windows.Forms.Padding(4);
            this.grbDanhSachNganh.Size = new System.Drawing.Size(295, 636);
            this.grbDanhSachNganh.TabIndex = 0;
            this.grbDanhSachNganh.TabStop = false;
            this.grbDanhSachNganh.Text = "Danh sách ngành";
            // 
            // tvNganh
            // 
            this.tvNganh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tvNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNganh.ForeColor = System.Drawing.Color.Navy;
            this.tvNganh.Location = new System.Drawing.Point(4, 31);
            this.tvNganh.Margin = new System.Windows.Forms.Padding(4);
            this.tvNganh.Name = "tvNganh";
            this.tvNganh.Size = new System.Drawing.Size(287, 601);
            this.tvNganh.TabIndex = 0;
            this.tvNganh.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNganh_AfterSelect);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.btnXoaLop);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThemLop);
            this.panel4.Controls.Add(this.cbNganh);
            this.panel4.Controls.Add(this.txtTenLop);
            this.panel4.Controls.Add(this.txtMaLop);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 343);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 293);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ngành :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(123, 99);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(701, 27);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(123, 147);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(701, 27);
            this.txtTenLop.TabIndex = 2;
            // 
            // cbNganh
            // 
            this.cbNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(123, 51);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(701, 27);
            this.cbNganh.TabIndex = 0;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.Orange;
            this.btnThemLop.FlatAppearance.BorderSize = 0;
            this.btnThemLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(210, 0);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(77, 39);
            this.btnThemLop.TabIndex = 3;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(348, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 39);
            this.btnSua.TabIndex = 4;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.Orange;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(494, 0);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(84, 39);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 636);
            this.panel2.TabIndex = 1;
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grbDanhSachLop.Controls.Add(this.lvDanhSachLop);
            this.grbDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachLop.ForeColor = System.Drawing.Color.Navy;
            this.grbDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachLop.Margin = new System.Windows.Forms.Padding(4);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Padding = new System.Windows.Forms.Padding(4);
            this.grbDanhSachLop.Size = new System.Drawing.Size(880, 636);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "Danh sách lớp";
            // 
            // lvDanhSachLop
            // 
            this.lvDanhSachLop.BackColor = System.Drawing.Color.White;
            this.lvDanhSachLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachLop.FullRowSelect = true;
            this.lvDanhSachLop.GridLines = true;
            this.lvDanhSachLop.HideSelection = false;
            this.lvDanhSachLop.Location = new System.Drawing.Point(4, 31);
            this.lvDanhSachLop.Margin = new System.Windows.Forms.Padding(4);
            this.lvDanhSachLop.Name = "lvDanhSachLop";
            this.lvDanhSachLop.Size = new System.Drawing.Size(872, 601);
            this.lvDanhSachLop.TabIndex = 0;
            this.lvDanhSachLop.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachLop.View = System.Windows.Forms.View.Details;
            this.lvDanhSachLop.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachLop_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Lớp";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 329;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Ngành";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 218;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.grbDanhSachLop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 636);
            this.panel3.TabIndex = 0;
            // 
            // QuanLyLopHocControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyLopHocControl";
            this.Size = new System.Drawing.Size(1175, 636);
            this.Load += new System.EventHandler(this.QuanLyLopHocControl_Load);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachNganh.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbDanhSachLop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox grbDanhSachNganh;
        private DataGridViewCheckBoxColumn dgvCheckBox;
        private BackgroundWorker backgroundWorker1;
        private TreeView tvNganh;
        private Panel panel4;
        private Button btnXoaLop;
        private Button btnSua;
        private Button btnThemLop;
        private ComboBox cbNganh;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox grbDanhSachLop;
        private ListView lvDanhSachLop;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
