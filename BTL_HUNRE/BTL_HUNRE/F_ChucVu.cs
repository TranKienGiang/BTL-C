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
    public partial class F_ChucVu : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_ChucVu()
        {
            InitializeComponent();
        }
        private Boolean KiemTra()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            Boolean kt = true;
            string macv = txtMaCV.Text;
            string sql_kt = "select * from chucvu where machucvu = N'" + macv + "'";
            SqlCommand cmd = new SqlCommand(sql_kt, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (macv == DR[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã chức vụ đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaCV.Clear();
                    txtMaCV.Focus();
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
            string sql = "select * from chucvu";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, myConn);
            DataTable DT = new DataTable();
            Mydata.Fill(DT);
            DGV_CV.DataSource = DT;
            myConn.Close();
        }
        private void Xoa()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtPhuCap.Clear();
            txtTimKiem.Clear();
            cbKhoiDV.ResetText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql = "insert into chucvu values (N'" + txtMaCV.Text + "', N'" + txtTenCV.Text + "', N'" + txtPhuCap.Text + "', N'" + cbKhoiDV.SelectedValue.ToString() + "')";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            if (txtMaCV.Text == "")
            {
                errorProvider.SetError(txtMaCV, "Vui lòng không để trống!!!");
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
        private void CB_KhoiDV()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_dvtt = "Select * from donvitructhuoc";
            SqlDataAdapter myData = new SqlDataAdapter(sql_dvtt, myConn);
            DataSet ds = new DataSet();
            myData.Fill(ds);
            cbKhoiDV.DataSource = ds.Tables[0];
            cbKhoiDV.DisplayMember = "tendonvitt";
            cbKhoiDV.ValueMember = "madonvitt";
            myConn.Close();
        }
        private void F_ChucVu_Load(object sender, EventArgs e)
        {
            HienThi();
            CB_KhoiDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string macv = txtMaCV.Text;
            string sql_del = "delete from chucvu where machucvu = N'" + macv + "'";
            SqlCommand cmd = new SqlCommand(sql_del, myConn);
            if (txtMaCV.Text == "")
            {
                errorProvider.SetError(txtMaCV, "Vui lòng không để trống !!!");
                txtMaCV.Focus();
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

        private void DGV_CV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTg.Text = DGV_CV.CurrentRow.Cells[0].Value.ToString();
            txtMaCV.Text = DGV_CV.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = DGV_CV.CurrentRow.Cells[1].Value.ToString();
            txtPhuCap.Text = DGV_CV.CurrentRow.Cells[2].Value.ToString();
            cbKhoiDV.Text = DGV_CV.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            if (txtMaCV.Text == "")
            {
                errorProvider.SetError(txtMaCV, "Vui lòng không để trống !!!");
            }
            else
            {
                errorProvider.Clear();
                string tg = lbTg.Text;
                string sql_u1 = "update chucvu set machucvu = N'" + txtMaCV.Text + "', tenchucvu = N'" + txtTenCV.Text + "', phucap = N'" + txtPhuCap.Text + "', madonvitt = N'" + cbKhoiDV.SelectedValue.ToString() + "' where machucvu = N'" + tg + "'";
                string sql_u2 = "update chucvu set tenchucvu = N'" + txtTenCV.Text + "', phucap = N'" + txtPhuCap.Text + "', madonvitt = N'" + cbKhoiDV.SelectedValue.ToString() + "' where machucvu = N'" + tg + "'";
                SqlCommand cmd1 = new SqlCommand(sql_u1, myConn);
                SqlCommand cmd2 = new SqlCommand(sql_u2, myConn);
                DialogResult DResult = MessageBox.Show("Bạn có muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (txtMaCV.Text == tg)
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
    }
}
