
namespace BTL_HUNRE
{
    partial class F_TinhLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGV_TinhLuong = new System.Windows.Forms.DataGridView();
            this.manhansu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghiphep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khongphep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThang = new System.Windows.Forms.NumericUpDown();
            this.txtNam = new System.Windows.Forms.NumericUpDown();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "/";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinhLuong.AutoRoundedCorners = true;
            this.btnTinhLuong.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnTinhLuong.BorderRadius = 21;
            this.btnTinhLuong.CheckedState.Parent = this.btnTinhLuong;
            this.btnTinhLuong.CustomImages.Parent = this.btnTinhLuong;
            this.btnTinhLuong.FillColor = System.Drawing.Color.Green;
            this.btnTinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.HoverState.Parent = this.btnTinhLuong;
            this.btnTinhLuong.Location = new System.Drawing.Point(736, 89);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ShadowDecoration.Parent = this.btnTinhLuong;
            this.btnTinhLuong.Size = new System.Drawing.Size(180, 45);
            this.btnTinhLuong.TabIndex = 5;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoRoundedCorners = true;
            this.btnTimKiem.BorderRadius = 20;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.FillColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 78);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(132, 43);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(149, 78);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập tên cần tìm ...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(321, 43);
            this.txtTimKiem.TabIndex = 8;
            // 
            // DGV_TinhLuong
            // 
            this.DGV_TinhLuong.AllowUserToAddRows = false;
            this.DGV_TinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TinhLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhansu,
            this.Column2,
            this.heso,
            this.ngaylam,
            this.nghiphep,
            this.khongphep,
            this.phucap,
            this.phucapcv,
            this.tongluong});
            this.DGV_TinhLuong.Location = new System.Drawing.Point(12, 140);
            this.DGV_TinhLuong.Name = "DGV_TinhLuong";
            this.DGV_TinhLuong.RowHeadersWidth = 62;
            this.DGV_TinhLuong.RowTemplate.Height = 28;
            this.DGV_TinhLuong.Size = new System.Drawing.Size(905, 392);
            this.DGV_TinhLuong.TabIndex = 10;
            // 
            // manhansu
            // 
            this.manhansu.DataPropertyName = "manhansu";
            this.manhansu.HeaderText = "Mã Nhân Sự";
            this.manhansu.MinimumWidth = 8;
            this.manhansu.Name = "manhansu";
            this.manhansu.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // heso
            // 
            this.heso.DataPropertyName = "heso";
            this.heso.HeaderText = "Hệ Số Lương";
            this.heso.MinimumWidth = 8;
            this.heso.Name = "heso";
            this.heso.Width = 75;
            // 
            // ngaylam
            // 
            this.ngaylam.HeaderText = "Số Ngày Làm";
            this.ngaylam.MinimumWidth = 8;
            this.ngaylam.Name = "ngaylam";
            this.ngaylam.Width = 75;
            // 
            // nghiphep
            // 
            this.nghiphep.HeaderText = "Nghỉ Có Phép";
            this.nghiphep.MinimumWidth = 8;
            this.nghiphep.Name = "nghiphep";
            this.nghiphep.Width = 75;
            // 
            // khongphep
            // 
            this.khongphep.HeaderText = "Nghỉ Không Phép";
            this.khongphep.MinimumWidth = 8;
            this.khongphep.Name = "khongphep";
            this.khongphep.Width = 150;
            // 
            // phucap
            // 
            this.phucap.DataPropertyName = "phucap";
            this.phucap.HeaderText = "Thưởng + Phụ Cấp";
            this.phucap.MinimumWidth = 8;
            this.phucap.Name = "phucap";
            this.phucap.Width = 150;
            // 
            // phucapcv
            // 
            this.phucapcv.DataPropertyName = "phucapcv";
            this.phucapcv.HeaderText = "Phụ Cấp Chức Vụ";
            this.phucapcv.MinimumWidth = 8;
            this.phucapcv.Name = "phucapcv";
            this.phucapcv.Width = 150;
            // 
            // tongluong
            // 
            this.tongluong.HeaderText = "Tổng Lương";
            this.tongluong.MinimumWidth = 8;
            this.tongluong.Name = "tongluong";
            this.tongluong.Width = 150;
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(87, 25);
            this.txtThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(56, 28);
            this.txtThang.TabIndex = 11;
            this.txtThang.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtThang.ValueChanged += new System.EventHandler(this.txtThang_ValueChanged);
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(170, 25);
            this.txtNam.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.txtNam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(73, 28);
            this.txtNam.TabIndex = 11;
            this.txtNam.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoRoundedCorners = true;
            this.btnThongKe.BorderRadius = 16;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.Green;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Location = new System.Drawing.Point(249, 23);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(210, 34);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống Kê Ngày Làm";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackgroundImage = global::BTL_HUNRE.Properties.Resources.export_127px;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(660, 86);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(57, 48);
            this.btnReport.TabIndex = 13;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // F_TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.DGV_TinhLuong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_TinhLuong";
            this.Text = "Tính lương";
            this.Load += new System.EventHandler(this.F_TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTinhLuong;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView DGV_TinhLuong;
        private System.Windows.Forms.NumericUpDown txtThang;
        private System.Windows.Forms.NumericUpDown txtNam;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhansu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghiphep;
        private System.Windows.Forms.DataGridViewTextBoxColumn khongphep;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
        private System.Windows.Forms.Button btnReport;
    }
}