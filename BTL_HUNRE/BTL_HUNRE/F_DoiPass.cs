using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_HUNRE
{
    public partial class F_DoiPass : Form
    {
        public static string username = null;
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_DoiPass()
        {
            InitializeComponent();
        }

        private void F_DoiPass_Load(object sender, EventArgs e)
        {
            lbUserName.Text = username;
            txtPassCu.Focus();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            if(txtPassCu.Text != "")
            {
                if(txtPassMoi.Text != "")
                {
                    if(txtXacNhan.Text != "")
                    {
                        if(txtPassMoi.Text == txtXacNhan.Text)
                        {
                            errorProvider.SetError(txtXacNhan, "");
                            myConn = new SqlConnection(chuoi);
                            myConn.Open();
                            string sql = "update dangnhap set password = N'"+ txtXacNhan.Text +"' where username = N'"+ lbUserName.Text +"'";
                            SqlCommand cmd = new SqlCommand(sql, myConn);
                            if(MessageBox.Show("Bạn có chắc chắn đổi mật khẩu? Hệ thống sẽ khởi động lại!!!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (KiemTra())
                                {
                                    cmd.ExecuteNonQuery();
                                    Xoa();
                                    Application.Restart();
                                } else
                                {
                                    errorProvider.SetError(txtPassCu, "Mật khẩu hiện tại không đúng !!!");
                                    txtPassCu.Clear();
                                    txtPassCu.Focus();
                                }
                            }
                            myConn.Close();
                        }
                        else
                        {
                            errorProvider.SetError(txtXacNhan, "Mật khẩu không trùng khớp!!!");
                            txtXacNhan.Focus();
                        }
                    }else
                    {
                        errorProvider.SetError(txtXacNhan, "Vui lòng không để trống !!!");
                        txtXacNhan.Focus();
                    }
                }
                else
                {
                    errorProvider.SetError(txtPassMoi, "Vui lòng không để trống !!!");
                    txtPassMoi.Focus();
                }
            } else
            {
                errorProvider.SetError(txtPassCu, "Vui lòng không để trống!!!");
                txtPassCu.Focus();
            }
        }
        private Boolean KiemTra()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            Boolean kt = false;
            string sql = "select * from dangnhap where username = N'"+ lbUserName.Text +"'";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (lbUserName.Text == DR[0].ToString() && txtPassCu.Text == DR[1].ToString())
                {
                    kt = true;
                }
            }
            myConn.Close();
            return kt;
        }
        private void txtXacNhan_TextChanged(object sender, EventArgs e)
        {
            if(txtXacNhan.Text != txtPassMoi.Text)
            {
                errorProvider.SetError(txtXacNhan, "Mật khẩu không trùng khớp!!!");
            } else
            {
                errorProvider.SetError(txtXacNhan, "");
            }
        }
        private void Xoa()
        {
            txtPassCu.Clear();
            txtPassMoi.Clear();
            txtXacNhan.Clear();
        }

        private void txtPassCu_TextChanged(object sender, EventArgs e)
        {
            if(txtPassCu.Text != "")
            {
                errorProvider.Clear();
            }
        }
    }
}
