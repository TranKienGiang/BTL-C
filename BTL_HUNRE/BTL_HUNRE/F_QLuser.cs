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
    public partial class F_QLuser : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_QLuser()
        {
            InitializeComponent();
        }
        private void HienThiDK()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            String sql_dk = "select * from dangky";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql_dk, myConn);
            DataTable DT = new DataTable();
            Mydata.Fill(DT);
            DGV_DangKy.DataSource = DT;
            myConn.Close();
        }
        private void HienThiDN()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            String sql_dn = "select * from dangnhap";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql_dn, myConn);
            DataTable DT = new DataTable();
            Mydata.Fill(DT);
            DGV_DangNhap.DataSource = DT;
            myConn.Close();
        }

        private void F_QLuser_Load(object sender, EventArgs e)
        {
            HienThiDK();
            HienThiDN();
        }

        private void DGV_DangNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbUserName.Text = DGV_DangNhap.CurrentRow.Cells[0].Value.ToString();
            lbQuyen.Text = DGV_DangNhap.CurrentRow.Cells[2].Value.ToString();
            lbPass.Text = DGV_DangNhap.CurrentRow.Cells[1].Value.ToString();
            lbUserName.ForeColor = Color.Green;
            if(lbQuyen.Text == "Admin")
            {
                lbQuyen.ForeColor = Color.Violet;
            } else
            {
                lbQuyen.ForeColor = Color.Pink;
            }
            btnDuyet.Enabled = false;
            if(lbUserName.Text == "admin")
            {
                btnXoa.Enabled = false;

            } else
            {
                btnXoa.Enabled = true;
            }
        }

        private void DGV_DangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbUserName.Text = DGV_DangKy.CurrentRow.Cells[0].Value.ToString();
            lbQuyen.Text = DGV_DangKy.CurrentRow.Cells[2].Value.ToString();
            lbPass.Text = DGV_DangKy.CurrentRow.Cells[1].Value.ToString();
            lbUserName.ForeColor = Color.Red;
            lbQuyen.ForeColor = Color.Red;
            btnDuyet.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string xoa_dk = "delete from dangky where username = '" + lbUserName.Text + "'";
            string xoa_dn = "delete from dangnhap where username = '" + lbUserName.Text + "'";
            SqlCommand cmd_dk = new SqlCommand(xoa_dk, myConn);
            SqlCommand cmd_dn = new SqlCommand(xoa_dn, myConn);
            if(lbUserName.Text == "")
            {
                MessageBox.Show("Rỗng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult DRsult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DRsult == DialogResult.Yes)
                {
                    if(lbUserName.ForeColor == Color.Red)
                    {
                        cmd_dk.ExecuteNonQuery();
                        Xoa();
                        HienThiDK();
                        
                    } else
                    {
                        cmd_dn.ExecuteNonQuery();
                        Xoa();
                        HienThiDN();
                    }
                }
            }
            myConn.Close();
        }
        private void Xoa()
        {
            lbUserName.Text = "";
            lbQuyen.Text = "";
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_ok = "insert into dangnhap values(N'"+ lbUserName.Text +"', N'"+ lbPass.Text +"', N'"+ lbQuyen.Text +"')";
            string sql_de = "delete from dangky where username = '" + lbUserName.Text + "'";
            SqlCommand cmd_i = new SqlCommand(sql_ok, myConn);
            SqlCommand cmd_de = new SqlCommand(sql_de, myConn);
            if(lbUserName.Text == "")
            {
                MessageBox.Show("Rỗng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult DRsult = MessageBox.Show("Bạn có chắc chắn duyệt?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DRsult == DialogResult.Yes)
                {
                    cmd_i.ExecuteNonQuery();
                    cmd_de.ExecuteNonQuery();
                    Xoa();
                    HienThiDK();
                    HienThiDN();
                }
            }
            myConn.Close();
        }
    }
}
