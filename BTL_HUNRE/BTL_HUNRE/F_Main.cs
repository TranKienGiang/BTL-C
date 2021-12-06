using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HUNRE
{
    public partial class F_Main : Form
    {
        private Form activeForm = null;
        public F_Main()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnDonVi.Visible = false;
            pnNhanSu.Visible = false;
            pnChucNang.Visible = false;
            pnBaoCao.Visible = false;
            pnHeThong.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            showSubMenu(pnDonVi);
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnNhanSu);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            showSubMenu(pnChucNang);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(pnBaoCao);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(pnHeThong);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Login lg = new F_Login();
            lg.Show();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTab.Text = childForm.Text;
            btnTab.Visible = true;
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            openChildForm(new F_ChamCong());
            hideSubMenu();
        }

        private void btnDs_Click(object sender, EventArgs e)
        {
            openChildForm(new F_NhanSu());
            hideSubMenu();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            openChildForm(new Home());
            btnTab.Visible = false;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            openChildForm(new F_Khoa_BM());
            hideSubMenu();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new F_KhoiDV());
            hideSubMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new F_Phong());
            hideSubMenu();
        }

        private void btnVienTT_Click(object sender, EventArgs e)
        {
            openChildForm(new F_VienTT());
            hideSubMenu();
        }

        private void btnToChuc_Click(object sender, EventArgs e)
        {
            openChildForm(new F_Tochuc());
            hideSubMenu();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DoiPass());
            hideSubMenu();
        }

        private void btnDangVien_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DangVien());
            hideSubMenu();
        }

        private void btnDoanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DoanVien());
            hideSubMenu();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            openChildForm(new F_ChucVu());
            hideSubMenu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            openChildForm(new F_TimKiem());
            hideSubMenu();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            openChildForm(new F_TinhLuong());
            hideSubMenu();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            openChildForm(new F_QLuser());
            hideSubMenu();
        }
        public void Admin()
        {
            btnNguoiDung.Visible = true;
        }

        public void notAdmin()
        {
            btnNguoiDung.Visible = false;
            pnHeThong.Height = 41;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());
            hideSubMenu();
        }
    }
}
