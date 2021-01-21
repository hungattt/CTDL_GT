namespace QuanLySinhVien
{
    partial class QuanLyNganhControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongTinNganh = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAddNganh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvThongTinNganh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbThongTinNganh.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 746);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinNganh
            // 
            this.grbThongTinNganh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbThongTinNganh.Controls.Add(this.lvThongTinNganh);
            this.grbThongTinNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNganh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNganh.ForeColor = System.Drawing.Color.Navy;
            this.grbThongTinNganh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbThongTinNganh.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNganh.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinNganh.Name = "grbThongTinNganh";
            this.grbThongTinNganh.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinNganh.Size = new System.Drawing.Size(1514, 746);
            this.grbThongTinNganh.TabIndex = 0;
            this.grbThongTinNganh.TabStop = false;
            this.grbThongTinNganh.Text = "Thông tin ngành";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(586, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAddNganh
            // 
            this.btnAddNganh.BackColor = System.Drawing.Color.Orange;
            this.btnAddNganh.FlatAppearance.BorderSize = 0;
            this.btnAddNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNganh.ForeColor = System.Drawing.Color.White;
            this.btnAddNganh.Location = new System.Drawing.Point(399, 180);
            this.btnAddNganh.Name = "btnAddNganh";
            this.btnAddNganh.Size = new System.Drawing.Size(80, 36);
            this.btnAddNganh.TabIndex = 2;
            this.btnAddNganh.Text = "Thêm ";
            this.btnAddNganh.UseVisualStyleBackColor = false;
            this.btnAddNganh.Click += new System.EventHandler(this.btnAddNganh_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.grbThongTinNganh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1514, 746);
            this.panel3.TabIndex = 5;
            // 
            // lvThongTinNganh
            // 
            this.lvThongTinNganh.BackColor = System.Drawing.Color.White;
            this.lvThongTinNganh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvThongTinNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThongTinNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThongTinNganh.FullRowSelect = true;
            this.lvThongTinNganh.GridLines = true;
            this.lvThongTinNganh.HideSelection = false;
            this.lvThongTinNganh.Location = new System.Drawing.Point(4, 31);
            this.lvThongTinNganh.Name = "lvThongTinNganh";
            this.lvThongTinNganh.Size = new System.Drawing.Size(1506, 711);
            this.lvThongTinNganh.TabIndex = 0;
            this.lvThongTinNganh.UseCompatibleStateImageBehavior = false;
            this.lvThongTinNganh.View = System.Windows.Forms.View.Details;
            this.lvThongTinNganh.SelectedIndexChanged += new System.EventHandler(this.lvThongTinNganh_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Ngành";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Ngành";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 1122;
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.BackColor = System.Drawing.Color.Orange;
            this.btnXoaNganh.FlatAppearance.BorderSize = 0;
            this.btnXoaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.ForeColor = System.Drawing.Color.White;
            this.btnXoaNganh.Location = new System.Drawing.Point(772, 180);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(74, 36);
            this.btnXoaNganh.TabIndex = 6;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = false;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txtTenNganh);
            this.panel2.Controls.Add(this.btnXoaNganh);
            this.panel2.Controls.Add(this.txtMaNganh);
            this.panel2.Controls.Add(this.btnAddNganh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1514, 306);
            this.panel2.TabIndex = 1;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganh.Location = new System.Drawing.Point(303, 108);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(689, 27);
            this.txtTenNganh.TabIndex = 1;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(303, 48);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(689, 27);
            this.txtMaNganh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(194, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ngành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(191, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ngành:";
            // 
            // QuanLyNganhControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNganhControl";
            this.Size = new System.Drawing.Size(1514, 746);
            this.Load += new System.EventHandler(this.QuanLyNganhControl_Load);
            this.panel1.ResumeLayout(false);
            this.grbThongTinNganh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongTinNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvThongTinNganh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSua;
    }
}
