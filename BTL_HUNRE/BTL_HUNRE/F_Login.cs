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
    public partial class F_Login : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_Login()
        {
            InitializeComponent();
        }

        private void linkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animate.HideSync(pLogin);
            animate.ShowSync(pCreate);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql = "select * from dangnhap where username = N'" + txtUser.Text + "' and password = N'"+ txtPassword.Text +"'";
            if(txtUser.Text == "")
            {
                errorProvider.SetError(txtUser, "Vui lòng không để trống !!!");
            } else if(txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Vui lòng không để trống!!!");
            } else
            {
                SqlCommand cmd = new SqlCommand(sql, myConn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(txtUser.Text == dr[0].ToString() && txtPassword.Text == dr[1].ToString())
                    {
                        F_Main main = new F_Main();
                        if(dr[2].ToString() == "Admin")
                        {
                            this.Hide();
                            main.Show();
                            main.Admin();
                        } else
                        {
                            this.Hide();
                            main.Show();
                            main.notAdmin();
                        }
                        F_DoiPass.username = txtUser.Text;
                    } else
                    {
                        MessageBox.Show("Sai Username hoặc Password!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            myConn.Close();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animate.HideSync(pCreate);
            animate.ShowSync(pLogin);
            Xoa();
        }

        private void ckDkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckDkShowPass.Checked == true)
            {
                txtDkCfPass.UseSystemPasswordChar = false;
                txtDkPass.UseSystemPasswordChar = false;
            } else
            {
                txtDkCfPass.UseSystemPasswordChar = true;
                txtDkPass.UseSystemPasswordChar = true;
            }
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            } else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            if(txtDkUser.Text == "" || txtDkPass.Text == "" || txtDkCfPass.Text == "" || cbAdmin.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(txtDkCfPass.Text != txtDkPass.Text)
            {
                errorProvider.SetError(txtDkCfPass, "Mật khẩu không trùng khớp!!!");
            } else
            {
                errorProvider.SetError(txtDkCfPass, "");
                string add_dk = "insert into dangky values (N'" + txtDkUser.Text + "', N'" + txtDkCfPass.Text + "',N'" + cbAdmin.Text + "')";
                string add_dn = "insert into dangnhap values (N'" + txtDkUser.Text + "', N'" + txtDkCfPass.Text + "',N'" + cbAdmin.Text + "')";
                SqlCommand cmd_dk = new SqlCommand(add_dk, myConn);
                SqlCommand cmd_dn = new SqlCommand(add_dn, myConn);
                if (KiemTra() && KiemTraDK())
                {
                    if(cbAdmin.Text == "Admin")
                    {
                        cmd_dk.ExecuteNonQuery();
                        Xoa();
                        MessageBox.Show("Tài khoản (Admin) chờ xét duyệt!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        cmd_dn.ExecuteNonQuery();
                        Xoa();
                        MessageBox.Show("Đăng ký thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
            myConn.Close();
        }
        private void Xoa()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtDkUser.Clear();
            txtDkPass.Clear();
            txtDkCfPass.Clear();
            cbAdmin.ResetText();
            errorProvider.Clear();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                errorProvider.SetError(txtUser, "Vui lòng không để trống!!!");
            } else
            {
                errorProvider.SetError(txtUser, "");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Vui lòng không để trống!!!");
            } else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }

        private void txtDkCfPass_TextChanged(object sender, EventArgs e)
        {
            if(txtDkCfPass.Text != txtDkPass.Text)
            {
                errorProvider.SetError(txtDkCfPass, "Mật khẩu không trùng khớp!!!");
            } else
            {
                errorProvider.SetError(txtDkCfPass, "");
            }
        }
        private Boolean KiemTra()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string username = txtDkUser.Text;
            string sql_ktdn = "select * from dangnhap where username = N'"+ username +"'";
            SqlCommand cmddn = new SqlCommand(sql_ktdn, myConn);
            SqlDataReader DRDN = cmddn.ExecuteReader();
            Boolean kt = true;
            while (DRDN.Read())
            {
                if(username == DRDN[0].ToString())
                {
                    kt = false;
                    errorProvider.SetError(txtDkUser, "Username đã tồn tại!!!");
                } else
                {
                    errorProvider.SetError(txtDkUser, "");
                }
            }
            myConn.Close();
            return kt;
        }
        private Boolean KiemTraDK()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string username = txtDkUser.Text;
            string sql_ktdk = "select * from dangky where username = N'" + username + "'";
            SqlCommand cmddk = new SqlCommand(sql_ktdk, myConn);
            SqlDataReader DRDK = cmddk.ExecuteReader();
            Boolean kt = true;
            while (DRDK.Read())
            {
                if (username == DRDK[0].ToString())
                {
                    kt = false;
                    errorProvider.SetError(txtDkUser, "Username chờ xét duyệt !!!");
                }
                else
                {
                    errorProvider.SetError(txtDkUser, "");
                }
            }
            myConn.Close();
            return kt;
        }

        private void txtDkUser_TextChanged(object sender, EventArgs e)
        {
            if(txtDkUser.Text == "")
            {
                errorProvider.SetError(txtDkUser, "Vui lòng không để trống !!!");
            } else
            {
                errorProvider.SetError(txtDkUser, "");
            }
            
        }

        private void txtDkPass_TextChanged(object sender, EventArgs e)
        {
            if(txtDkPass.Text == "")
            {
                errorProvider.SetError(txtDkPass, "Vui lòng không để trống!!!");
            } else
            {
                errorProvider.SetError(txtDkPass, "");
            }
        }
    }
}
