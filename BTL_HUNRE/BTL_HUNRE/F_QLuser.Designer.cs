
namespace BTL_HUNRE
{
    partial class F_QLuser
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
            this.DGV_DangKy = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DangNhap = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQuyen = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_DangKy
            // 
            this.DGV_DangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column4,
            this.Column6});
            this.DGV_DangKy.Location = new System.Drawing.Point(12, 382);
            this.DGV_DangKy.Name = "DGV_DangKy";
            this.DGV_DangKy.RowHeadersWidth = 62;
            this.DGV_DangKy.RowTemplate.Height = 28;
            this.DGV_DangKy.Size = new System.Drawing.Size(904, 144);
            this.DGV_DangKy.TabIndex = 0;
            this.DGV_DangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DangKy_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "username";
            this.Column5.HeaderText = "Username";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "password";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "admin";
            this.Column6.HeaderText = "Quyền";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // DGV_DangNhap
            // 
            this.DGV_DangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.DGV_DangNhap.Location = new System.Drawing.Point(12, 167);
            this.DGV_DangNhap.Name = "DGV_DangNhap";
            this.DGV_DangNhap.RowHeadersWidth = 62;
            this.DGV_DangNhap.RowTemplate.Height = 28;
            this.DGV_DangNhap.Size = new System.Drawing.Size(904, 159);
            this.DGV_DangNhap.TabIndex = 0;
            this.DGV_DangNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DangNhap_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "username";
            this.Column2.HeaderText = "UserName";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "password";
            this.Column1.HeaderText = "Password";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "admin";
            this.Column3.HeaderText = "Quyền";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(272, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản (Admin) đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(311, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(115, 37);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 26);
            this.lbUserName.TabIndex = 2;
            // 
            // btnDuyet
            // 
            this.btnDuyet.AutoRoundedCorners = true;
            this.btnDuyet.BorderRadius = 20;
            this.btnDuyet.CheckedState.Parent = this.btnDuyet;
            this.btnDuyet.CustomImages.Parent = this.btnDuyet;
            this.btnDuyet.FillColor = System.Drawing.Color.Green;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.HoverState.Parent = this.btnDuyet;
            this.btnDuyet.Location = new System.Drawing.Point(479, 37);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.ShadowDecoration.Parent = this.btnDuyet;
            this.btnDuyet.Size = new System.Drawing.Size(180, 42);
            this.btnDuyet.TabIndex = 3;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(665, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(180, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quyền:";
            // 
            // lbQuyen
            // 
            this.lbQuyen.AutoSize = true;
            this.lbQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuyen.Location = new System.Drawing.Point(115, 77);
            this.lbQuyen.Name = "lbQuyen";
            this.lbQuyen.Size = new System.Drawing.Size(0, 26);
            this.lbQuyen.TabIndex = 2;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(690, 111);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(0, 26);
            this.lbPass.TabIndex = 2;
            this.lbPass.Visible = false;
            // 
            // F_QLuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 538);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbQuyen);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_DangNhap);
            this.Controls.Add(this.DGV_DangKy);
            this.Name = "F_QLuser";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.F_QLuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DangKy;
        private System.Windows.Forms.DataGridView DGV_DangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserName;
        private Guna.UI2.WinForms.Guna2Button btnDuyet;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQuyen;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}