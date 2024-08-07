namespace _Final_Project_Cinema_Theater
{
    partial class BanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanVe));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CboDsPhim = new System.Windows.Forms.ComboBox();
            this.PanelLichChieu = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelNgay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panelshow = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtMota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelGoiY = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicPoster = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Panelshow.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelGoiY.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "green-icon.png");
            this.imageList1.Images.SetKeyName(1, "yellow_icon.png");
            this.imageList1.Images.SetKeyName(2, "red-icon.png");
            // 
            // CboDsPhim
            // 
            this.CboDsPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDsPhim.FormattingEnabled = true;
            this.CboDsPhim.Location = new System.Drawing.Point(44, 21);
            this.CboDsPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboDsPhim.Name = "CboDsPhim";
            this.CboDsPhim.Size = new System.Drawing.Size(269, 24);
            this.CboDsPhim.TabIndex = 0;
            // 
            // PanelLichChieu
            // 
            this.PanelLichChieu.Location = new System.Drawing.Point(357, 233);
            this.PanelLichChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLichChieu.Name = "PanelLichChieu";
            this.PanelLichChieu.Size = new System.Drawing.Size(848, 399);
            this.PanelLichChieu.TabIndex = 3;
            // 
            // PanelNgay
            // 
            this.PanelNgay.AutoScroll = true;
            this.PanelNgay.BackColor = System.Drawing.Color.Cyan;
            this.PanelNgay.Location = new System.Drawing.Point(357, 77);
            this.PanelNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelNgay.Name = "PanelNgay";
            this.PanelNgay.Size = new System.Drawing.Size(845, 66);
            this.PanelNgay.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.CboDsPhim);
            this.panel1.Location = new System.Drawing.Point(8, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 66);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Xuất Chiếu Trong Ngày";
            // 
            // Panelshow
            // 
            this.Panelshow.BackColor = System.Drawing.Color.Aquamarine;
            this.Panelshow.Controls.Add(this.label1);
            this.Panelshow.Location = new System.Drawing.Point(357, 148);
            this.Panelshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panelshow.Name = "Panelshow";
            this.Panelshow.Size = new System.Drawing.Size(848, 78);
            this.Panelshow.TabIndex = 4;
            this.Panelshow.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 640);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.PanelGoiY);
            this.panel5.Controls.Add(this.Panelshow);
            this.panel5.Controls.Add(this.PanelLichChieu);
            this.panel5.Controls.Add(this.PanelNgay);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1070, 640);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.TxtMota);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(8, 404);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 228);
            this.panel6.TabIndex = 7;
            // 
            // TxtMota
            // 
            this.TxtMota.Location = new System.Drawing.Point(16, 43);
            this.TxtMota.Multiline = true;
            this.TxtMota.Name = "TxtMota";
            this.TxtMota.ReadOnly = true;
            this.TxtMota.Size = new System.Drawing.Size(297, 172);
            this.TxtMota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.PicPoster);
            this.panel3.Location = new System.Drawing.Point(8, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 250);
            this.panel3.TabIndex = 6;
            // 
            // PanelGoiY
            // 
            this.PanelGoiY.BackColor = System.Drawing.Color.Cyan;
            this.PanelGoiY.Controls.Add(this.label2);
            this.PanelGoiY.Location = new System.Drawing.Point(357, 77);
            this.PanelGoiY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelGoiY.Name = "PanelGoiY";
            this.PanelGoiY.Size = new System.Drawing.Size(848, 67);
            this.PanelGoiY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "⭠ Chọn Phim ở Đây ";
            // 
            // labelX
            // 
            this.labelX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Blue;
            this.labelX.Location = new System.Drawing.Point(0, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(1070, 71);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Lịch Chiếu Phim";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 71);
            this.panel2.TabIndex = 22;
            // 
            // PicPoster
            // 
            this.PicPoster.BackColor = System.Drawing.SystemColors.Control;
            this.PicPoster.Location = new System.Drawing.Point(79, 25);
            this.PicPoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicPoster.Name = "PicPoster";
            this.PicPoster.Size = new System.Drawing.Size(164, 199);
            this.PicPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPoster.TabIndex = 5;
            this.PicPoster.TabStop = false;
            // 
            // BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "BanVe";
            this.Text = "BanVe";
            this.Load += new System.EventHandler(this.BanVe_Load);
            this.panel1.ResumeLayout(false);
            this.Panelshow.ResumeLayout(false);
            this.Panelshow.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.PanelGoiY.ResumeLayout(false);
            this.PanelGoiY.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox CboDsPhim;
        private System.Windows.Forms.FlowLayoutPanel PanelLichChieu;
        private System.Windows.Forms.FlowLayoutPanel PanelNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panelshow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TxtMota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PicPoster;
        private System.Windows.Forms.Panel PanelGoiY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panel2;
    }
}