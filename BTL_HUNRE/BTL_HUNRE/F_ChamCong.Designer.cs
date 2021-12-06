
namespace BTL_HUNRE
{
    partial class F_ChamCong
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
            this.DGVChamCong = new System.Windows.Forms.DataGridView();
            this.manhansu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtChamCong = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ckkAll = new System.Windows.Forms.CheckBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.lbTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVChamCong
            // 
            this.DGVChamCong.AllowUserToAddRows = false;
            this.DGVChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhansu,
            this.Column2,
            this.TinhTrang});
            this.DGVChamCong.Location = new System.Drawing.Point(12, 173);
            this.DGVChamCong.Name = "DGVChamCong";
            this.DGVChamCong.RowHeadersWidth = 62;
            this.DGVChamCong.RowTemplate.Height = 28;
            this.DGVChamCong.Size = new System.Drawing.Size(904, 359);
            this.DGVChamCong.TabIndex = 0;
            // 
            // manhansu
            // 
            this.manhansu.DataPropertyName = "manhansu";
            this.manhansu.HeaderText = "Mã NV";
            this.manhansu.MinimumWidth = 8;
            this.manhansu.Name = "manhansu";
            this.manhansu.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "trinhtrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Items.AddRange(new object[] {
            "Đi Làm",
            "Nghỉ Có Phép",
            "Nghỉ Không Phép"});
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 250;
            // 
            // dtChamCong
            // 
            this.dtChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChamCong.Location = new System.Drawing.Point(71, 124);
            this.dtChamCong.Name = "dtChamCong";
            this.dtChamCong.Size = new System.Drawing.Size(173, 26);
            this.dtChamCong.TabIndex = 1;
            this.dtChamCong.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày: ";
            // 
            // ckkAll
            // 
            this.ckkAll.AutoSize = true;
            this.ckkAll.Location = new System.Drawing.Point(302, 128);
            this.ckkAll.Name = "ckkAll";
            this.ckkAll.Size = new System.Drawing.Size(160, 24);
            this.ckkAll.TabIndex = 3;
            this.ckkAll.Text = "Chấm công tất cả";
            this.ckkAll.UseVisualStyleBackColor = true;
            this.ckkAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.AutoRoundedCorners = true;
            this.btnCapNhat.BorderRadius = 21;
            this.btnCapNhat.CheckedState.Parent = this.btnCapNhat;
            this.btnCapNhat.CustomImages.Parent = this.btnCapNhat;
            this.btnCapNhat.FillColor = System.Drawing.Color.Green;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.HoverState.Parent = this.btnCapNhat;
            this.btnCapNhat.Location = new System.Drawing.Point(736, 107);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(180, 45);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTittle.Location = new System.Drawing.Point(330, 9);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(291, 55);
            this.lbTittle.TabIndex = 5;
            this.lbTittle.Text = "Chấm Công";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTittle.SizeChanged += new System.EventHandler(this.lbTittle_SizeChanged);
            // 
            // F_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.ckkAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtChamCong);
            this.Controls.Add(this.DGVChamCong);
            this.Name = "F_ChamCong";
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.F_ChamCong_Load);
            this.SizeChanged += new System.EventHandler(this.F_ChamCong_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGVChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVChamCong;
        private System.Windows.Forms.DateTimePicker dtChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckkAll;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhansu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn TinhTrang;
    }
}