namespace GUI_QLKS
{
    partial class frmQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCSVC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDV = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTrangThai = new System.Windows.Forms.Panel();
            this.btReload = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoomFrom = new System.Windows.Forms.ComboBox();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.cbRoomTo = new System.Windows.Forms.ComboBox();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.flpnPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlTrangThai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCSVC,
            this.menuDV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(155, 570);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCSVC
            // 
            this.menuCSVC.AutoSize = false;
            this.menuCSVC.BackColor = System.Drawing.SystemColors.Control;
            this.menuCSVC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCSVC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuCSVC.Margin = new System.Windows.Forms.Padding(10);
            this.menuCSVC.Name = "menuCSVC";
            this.menuCSVC.Padding = new System.Windows.Forms.Padding(50);
            this.menuCSVC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuCSVC.Size = new System.Drawing.Size(129, 70);
            this.menuCSVC.Text = "Quản lý cơ sở vật chất";
            this.menuCSVC.ToolTipText = "Chỉ dành cho admin";
            this.menuCSVC.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // menuDV
            // 
            this.menuDV.AutoSize = false;
            this.menuDV.BackColor = System.Drawing.SystemColors.Control;
            this.menuDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuDV.Name = "menuDV";
            this.menuDV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuDV.Size = new System.Drawing.Size(129, 70);
            this.menuDV.Text = "Quản lý các dịch vụ";
            this.menuDV.Click += new System.EventHandler(this.menuDV_Click);
            // 
            // pnlTrangThai
            // 
            this.pnlTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTrangThai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTrangThai.Controls.Add(this.btnDangXuat);
            this.pnlTrangThai.Controls.Add(this.groupBox1);
            this.pnlTrangThai.Controls.Add(this.lbTenDangNhap);
            this.pnlTrangThai.Location = new System.Drawing.Point(158, 465);
            this.pnlTrangThai.Name = "pnlTrangThai";
            this.pnlTrangThai.Size = new System.Drawing.Size(881, 101);
            this.pnlTrangThai.TabIndex = 2;
            // 
            // btReload
            // 
            this.btReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.Location = new System.Drawing.Point(74, 128);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(53, 44);
            this.btReload.TabIndex = 14;
            this.btReload.Text = "Trở lại";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btFilter
            // 
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Location = new System.Drawing.Point(6, 128);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(52, 44);
            this.btFilter.TabIndex = 13;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(6, 92);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 21);
            this.cbRoomType.TabIndex = 12;
            this.cbRoomType.SelectedValueChanged += new System.EventHandler(this.cbRoomType_SelectedValueChanged);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackgroundImage = global::GUI_QLKS.Properties.Resources.LogOut;
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangXuat.Location = new System.Drawing.Point(830, 35);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(48, 43);
            this.btnDangXuat.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnDangXuat, "Đăng xuất");
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbRoomFrom);
            this.groupBox1.Controls.Add(this.btnChuyenPhong);
            this.groupBox1.Controls.Add(this.cbRoomTo);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phòng chuyển tới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phòng muốn chuyển";
            // 
            // cbRoomFrom
            // 
            this.cbRoomFrom.FormattingEnabled = true;
            this.cbRoomFrom.Location = new System.Drawing.Point(121, 19);
            this.cbRoomFrom.Name = "cbRoomFrom";
            this.cbRoomFrom.Size = new System.Drawing.Size(121, 21);
            this.cbRoomFrom.TabIndex = 8;
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhong.Location = new System.Drawing.Point(261, 27);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(104, 48);
            this.btnChuyenPhong.TabIndex = 7;
            this.btnChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyenPhong.UseVisualStyleBackColor = true;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // cbRoomTo
            // 
            this.cbRoomTo.FormattingEnabled = true;
            this.cbRoomTo.Location = new System.Drawing.Point(121, 58);
            this.cbRoomTo.Name = "cbRoomTo";
            this.cbRoomTo.Size = new System.Drawing.Size(121, 21);
            this.cbRoomTo.TabIndex = 9;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(703, 38);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(121, 30);
            this.lbTenDangNhap.TabIndex = 3;
            this.lbTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpnPhong
            // 
            this.flpnPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnPhong.AutoScroll = true;
            this.flpnPhong.Location = new System.Drawing.Point(3, 3);
            this.flpnPhong.Name = "flpnPhong";
            this.flpnPhong.Size = new System.Drawing.Size(875, 453);
            this.flpnPhong.TabIndex = 0;
            this.flpnPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnPhong_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpnPhong);
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 459);
            this.panel1.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(6, 40);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.btFilter);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Location = new System.Drawing.Point(3, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 185);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1051, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrangThai);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLy_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTrangThai.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCSVC;
        private System.Windows.Forms.Panel pnlTrangThai;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuDV;
        private System.Windows.Forms.Button btnChuyenPhong;
        private System.Windows.Forms.FlowLayoutPanel flpnPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRoomFrom;
        private System.Windows.Forms.ComboBox cbRoomTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Button btFilter;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}