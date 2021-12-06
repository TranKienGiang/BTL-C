
namespace BTL_HUNRE
{
    partial class CR_DSLuong
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
            this.CRVLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVLuong
            // 
            this.CRVLuong.ActiveViewIndex = -1;
            this.CRVLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVLuong.Location = new System.Drawing.Point(0, 0);
            this.CRVLuong.Name = "CRVLuong";
            this.CRVLuong.Size = new System.Drawing.Size(1128, 552);
            this.CRVLuong.TabIndex = 0;
            // 
            // CR_DSLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 552);
            this.Controls.Add(this.CRVLuong);
            this.Name = "CR_DSLuong";
            this.Text = "Báo Cáo Lương";
            this.Load += new System.EventHandler(this.CR_DSLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRVLuong;
    }
}