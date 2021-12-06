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
    public partial class F_Tochuc : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_Tochuc()
        {
            InitializeComponent();
        }
        private Boolean KiemTra()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            Boolean kt = true;
            string matc = txtMaToChuc.Text;
            string sql_kt = "select * from donvi where madonvi = N'" + matc + "'";
            SqlCommand cmd = new SqlCommand(sql_kt, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (matc == DR[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Trùng mã khoa - bộ môn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaToChuc.Clear();
                    txtMaToChuc.Focus();
                    break;
                }
            }
            myConn.Close();
            return kt;
        }
        private void HienThi()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string madvtt = "TCDT";
            string sql = "select * from donvi where madonvitt = '" + madvtt + "'";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, myConn);
            DataTable DT = new DataTable();
            Mydata.Fill(DT);
            DGV_TT.DataSource = DT;
            myConn.Close();
        }
        private void Xoa()
        {
            txtMaToChuc.Clear();
            txtTenToChuc.Clear();
            txtTimKiem.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
        }

        private void F_Tochuc_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string madvtt = "TCDT";
            string sql = "insert into donvi values (N'" + txtMaToChuc.Text + "', N'" + txtTenToChuc.Text + "', N'" + txtDiaChi.Text + "', N'" + txtEmail.Text + "', N'" + txtDienThoai.Text + "', N'" + madvtt + "')";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            if (txtMaToChuc.Text == "")
            {
                errorProvider.SetError(txtMaToChuc, "Vui lòng không để trống!!!");
            }
            else
            {
                errorProvider.Clear();
                if (KiemTra())
                {
                    cmd.ExecuteNonQuery();
                    Xoa();
                    HienThi();
                }
            }
            myConn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string matc = txtMaToChuc.Text;
            string sql_del = "delete from donvi where madonvi = N'" + matc + "'";
            SqlCommand cmd = new SqlCommand(sql_del, myConn);
            if (txtMaToChuc.Text == "")
            {
                errorProvider.SetError(txtMaToChuc, "Vui lòng không để trống !!!");
                txtMaToChuc.Focus();
            }
            else
            {
                errorProvider.Clear();
                DialogResult DRsult = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DRsult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    HienThi();
                    Xoa();
                }
            }
            myConn.Close();
        }

        private void DGV_TT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTg.Text = DGV_TT.CurrentRow.Cells[0].Value.ToString();
            txtMaToChuc.Text = DGV_TT.CurrentRow.Cells[0].Value.ToString();
            txtTenToChuc.Text = DGV_TT.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = DGV_TT.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = DGV_TT.CurrentRow.Cells[3].Value.ToString();
            txtDienThoai.Text = DGV_TT.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            if (txtMaToChuc.Text == "")
            {
                errorProvider.SetError(txtMaToChuc, "Vui lòng không để trống !!!");
            }
            else
            {
                errorProvider.Clear();
                string tg = lbTg.Text;
                string sql_u1 = "update donvi set madonvi = N'" + txtMaToChuc.Text + "', tendonvi = N'" + txtTenToChuc.Text + "', diachi = N'" + txtDiaChi.Text + "', email = N'" + txtEmail.Text + "', dienthoai = N'" + txtDienThoai.Text + "' where madonvi = N'" + tg + "'";
                string sql_u2 = "update donvi set tendonvi = N'" + txtTenToChuc.Text + "', diachi = N'" + txtDiaChi.Text + "', email = N'" + txtEmail.Text + "', dienthoai = N'" + txtDienThoai.Text + "' where madonvi = N'" + tg + "'";
                SqlCommand cmd1 = new SqlCommand(sql_u1, myConn);
                SqlCommand cmd2 = new SqlCommand(sql_u2, myConn);
                DialogResult DResult = MessageBox.Show("Bạn có muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (txtMaToChuc.Text == tg)
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        if (KiemTra())
                        {
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    HienThi();
                    Xoa();
                }
            }
            myConn.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;
            if (txtTimKiem.Text == "")
            {
                HienThi();
            }
            else
            {
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                string madvtt = "TCDT";
                string sql_timkiem = "select * from donvi where tendonvi like N'%" + timkiem + "%' and madonvitt = N'" + madvtt + "'";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_timkiem, myConn);
                DataTable DT = new DataTable();
                Mydata.Fill(DT);
                DGV_TT.DataSource = DT;
                myConn.Close();
            }
        }
    }
}
