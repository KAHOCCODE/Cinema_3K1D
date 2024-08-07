namespace _Final_Project_Cinema_Theater
{
    partial class FrmInfoKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DsKhachHang = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MTxtSDTKH = new System.Windows.Forms.TextBox();
            this.TxtIdKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDiemTichLuy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbThem = new System.Windows.Forms.ToolStripButton();
            this.TsbSua = new System.Windows.Forms.ToolStripButton();
            this.TsbXoa = new System.Windows.Forms.ToolStripButton();
            this.TsbTim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtTim = new System.Windows.Forms.ToolStripTextBox();
            this.TxtCCCDKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.TxtDiaChiKH = new System.Windows.Forms.TextBox();
            this.TxtHoTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.DsKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(472, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // DsKhachHang
            // 
            this.DsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DsKhachHang.Location = new System.Drawing.Point(2, 15);
            this.DsKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DsKhachHang.Name = "DsKhachHang";
            this.DsKhachHang.RowHeadersWidth = 51;
            this.DsKhachHang.RowTemplate.Height = 24;
            this.DsKhachHang.Size = new System.Drawing.Size(468, 203);
            this.DsKhachHang.TabIndex = 0;
            this.DsKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DsKhachHang_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Cyan;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(472, 478);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.MTxtSDTKH);
            this.groupBox2.Controls.Add(this.TxtIdKH);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblDiemTichLuy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.TxtCCCDKH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DtpNgaySinhKH);
            this.groupBox2.Controls.Add(this.TxtDiaChiKH);
            this.groupBox2.Controls.Add(this.TxtHoTenKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(472, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Khách Hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MTxtSDTKH
            // 
            this.MTxtSDTKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtSDTKH.Location = new System.Drawing.Point(112, 141);
            this.MTxtSDTKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MTxtSDTKH.Name = "MTxtSDTKH";
            this.MTxtSDTKH.Size = new System.Drawing.Size(154, 22);
            this.MTxtSDTKH.TabIndex = 152;
            // 
            // TxtIdKH
            // 
            this.TxtIdKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdKH.Location = new System.Drawing.Point(356, 65);
            this.TxtIdKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdKH.Name = "TxtIdKH";
            this.TxtIdKH.Size = new System.Drawing.Size(98, 22);
            this.TxtIdKH.TabIndex = 151;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 150;
            this.label8.Text = "ID Khách";
            // 
            // LblDiemTichLuy
            // 
            this.LblDiemTichLuy.AutoSize = true;
            this.LblDiemTichLuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiemTichLuy.Location = new System.Drawing.Point(170, 220);
            this.LblDiemTichLuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDiemTichLuy.Name = "LblDiemTichLuy";
            this.LblDiemTichLuy.Size = new System.Drawing.Size(34, 14);
            this.LblDiemTichLuy.TabIndex = 149;
            this.LblDiemTichLuy.Text = "Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 148;
            this.label1.Text = "Điểm Tích Luỹ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbThem,
            this.TsbSua,
            this.TsbXoa,
            this.TsbTim,
            this.toolStripSeparator1,
            this.TxtTim});
            this.toolStrip1.Location = new System.Drawing.Point(2, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 25);
            this.toolStrip1.TabIndex = 147;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbThem
            // 
            this.TsbThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbThem.Image = ((System.Drawing.Image)(resources.GetObject("TsbThem.Image")));
            this.TsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbThem.Name = "TsbThem";
            this.TsbThem.Size = new System.Drawing.Size(41, 22);
            this.TsbThem.Text = "Thêm";
            this.TsbThem.Click += new System.EventHandler(this.TsbThem_Click);
            // 
            // TsbSua
            // 
            this.TsbSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbSua.Image = ((System.Drawing.Image)(resources.GetObject("TsbSua.Image")));
            this.TsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSua.Name = "TsbSua";
            this.TsbSua.Size = new System.Drawing.Size(30, 22);
            this.TsbSua.Text = "Sửa";
            this.TsbSua.Click += new System.EventHandler(this.TsbSua_Click);
            // 
            // TsbXoa
            // 
            this.TsbXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("TsbXoa.Image")));
            this.TsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbXoa.Name = "TsbXoa";
            this.TsbXoa.Size = new System.Drawing.Size(31, 22);
            this.TsbXoa.Text = "Xoá";
            this.TsbXoa.Click += new System.EventHandler(this.TsbXoa_Click);
            // 
            // TsbTim
            // 
            this.TsbTim.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbTim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbTim.Image = ((System.Drawing.Image)(resources.GetObject("TsbTim.Image")));
            this.TsbTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTim.Name = "TsbTim";
            this.TsbTim.Size = new System.Drawing.Size(31, 22);
            this.TsbTim.Text = "Tìm";
            this.TsbTim.Click += new System.EventHandler(this.TsbTim_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtTim
            // 
            this.TxtTim.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TxtTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTim.Name = "TxtTim";
            this.TxtTim.Size = new System.Drawing.Size(150, 25);
            this.TxtTim.Tag = "Nhập nội dung cần tìm";
            this.TxtTim.TextChanged += new System.EventHandler(this.TxtTim_TextChanged);
            // 
            // TxtCCCDKH
            // 
            this.TxtCCCDKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCCCDKH.Location = new System.Drawing.Point(112, 180);
            this.TxtCCCDKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCCCDKH.Name = "TxtCCCDKH";
            this.TxtCCCDKH.Size = new System.Drawing.Size(154, 22);
            this.TxtCCCDKH.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 104;
            this.label7.Text = "CCCD";
            // 
            // DtpNgaySinhKH
            // 
            this.DtpNgaySinhKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNgaySinhKH.Location = new System.Drawing.Point(122, 101);
            this.DtpNgaySinhKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpNgaySinhKH.Name = "DtpNgaySinhKH";
            this.DtpNgaySinhKH.Size = new System.Drawing.Size(144, 22);
            this.DtpNgaySinhKH.TabIndex = 101;
            // 
            // TxtDiaChiKH
            // 
            this.TxtDiaChiKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaChiKH.Location = new System.Drawing.Point(293, 141);
            this.TxtDiaChiKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDiaChiKH.Multiline = true;
            this.TxtDiaChiKH.Name = "TxtDiaChiKH";
            this.TxtDiaChiKH.Size = new System.Drawing.Size(158, 58);
            this.TxtDiaChiKH.TabIndex = 100;
            // 
            // TxtHoTenKH
            // 
            this.TxtHoTenKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoTenKH.Location = new System.Drawing.Point(112, 65);
            this.TxtHoTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHoTenKH.Name = "TxtHoTenKH";
            this.TxtHoTenKH.Size = new System.Drawing.Size(154, 22);
            this.TxtHoTenKH.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 98;
            this.label4.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 97;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 96;
            this.label5.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tên";
            // 
            // FrmInfoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(472, 478);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInfoKhachHang";
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.FrmInfoKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DsKhachHang)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DsKhachHang;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCCCDKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpNgaySinhKH;
        private System.Windows.Forms.TextBox TxtDiaChiKH;
        private System.Windows.Forms.TextBox TxtHoTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbThem;
        private System.Windows.Forms.ToolStripButton TsbSua;
        private System.Windows.Forms.ToolStripButton TsbXoa;
        private System.Windows.Forms.ToolStripButton TsbTim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TxtTim;
        private System.Windows.Forms.Label LblDiemTichLuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MTxtSDTKH;
    }
}