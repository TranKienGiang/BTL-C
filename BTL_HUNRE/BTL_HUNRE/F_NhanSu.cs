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
    public partial class F_NhanSu : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        public F_NhanSu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private Boolean KiemTra()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            Boolean kt = true;
            string manhansu = txtMaNhanSu.Text;
            string sql_kt = "select * from nhansu where manhansu = N'" + manhansu + "'";
            SqlCommand cmd = new SqlCommand(sql_kt, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (manhansu == DR[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã nhân sự đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNhanSu.Clear();
                    txtMaNhanSu.Focus();
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
            string sql = "select * from nhansu";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, myConn);
            DataTable DT = new DataTable();
            Mydata.Fill(DT);
            DGV_NhanSu.DataSource = DT;
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
        private void CB_DonVi()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_dvtt = "Select * from donvi where madonvitt = N'"+cbKhoiDV.SelectedValue.ToString() +"'";
            SqlDataAdapter myData = new SqlDataAdapter(sql_dvtt, myConn);
            DataSet ds = new DataSet();
            myData.Fill(ds);
            cbDonVi.DataSource = ds.Tables[0];
            cbDonVi.DisplayMember = "tendonvi";
            cbDonVi.ValueMember = "madonvi";
            myConn.Close();
        }
        private void CB_ChucVu()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_dvtt = "Select * from chucvu where madonvitt = N'" + cbKhoiDV.SelectedValue.ToString() + "'";
            SqlDataAdapter myData = new SqlDataAdapter(sql_dvtt, myConn);
            DataSet ds = new DataSet();
            myData.Fill(ds);
            cbChucVu.DataSource = ds.Tables[0];
            cbChucVu.DisplayMember = "tenchucvu";
            cbChucVu.ValueMember = "machucvu";
            myConn.Close();
        }
        private void CB_NgachLuong()
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_dvtt = "Select * from ngachluong";
            SqlDataAdapter myData = new SqlDataAdapter(sql_dvtt, myConn);
            DataSet ds = new DataSet();
            myData.Fill(ds);
            cbNgachLuong.DataSource = ds.Tables[0];
            cbNgachLuong.DisplayMember = "tenngach";
            cbNgachLuong.ValueMember = "mangach";
            myConn.Close();
        }
        private void F_NhanSu_Load(object sender, EventArgs e)
        {
            HienThi();
            CB_KhoiDV();
            CB_NgachLuong();
        }
        private void Xoa()
        {
            txtMaNhanSu.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            cbGioiTinh.ResetText();
            dtNgaySinh.ResetText();
            txtDienThoai.Clear();
            txtDanToc.Clear();
            txtTonGiao.Clear();
            txtQueQuan.Clear();
            txtThuongTru.Clear();
            txtEmail.Clear();
            cbHinhThuc.ResetText();
            cbKhoiDV.ResetText();
            cbDonVi.ResetText();
            cbChucVu.ResetText();
            dtNgayLam.ResetText();
            dtHetHD.ResetText();
            cbDoanDang.ResetText();
            dtNgayVaoDang.ResetText();
            txtChucVuDang.Clear();
            txtHocVi.Clear();
            txtChuyenNganh.Clear();
            txtNgoaiNgu.Clear();
            cbNgachLuong.ResetText();
            txtPhuCap.Clear();
            txtTimKiem.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void cbHinhThuc_TextChanged(object sender, EventArgs e)
        {
            if(cbHinhThuc.Text == "Chính thức")
            {

                lbHetHD.Enabled = false;
                dtHetHD.Enabled = false;
            } else
            {
                lbHetHD.Enabled = true;
                dtHetHD.Enabled = true;
            }
        }

        private void cbDoanDang_TextChanged(object sender, EventArgs e)
        {
            if(cbDoanDang.Text == "Đoàn viên")
            {
                lbNgayVaoDang.Enabled = false;
                dtNgayVaoDang.Enabled = false;
                lbChucVuDang.Enabled = false;
                txtChucVuDang.Enabled = false;
            } else
            {
                lbNgayVaoDang.Enabled = true;
                dtNgayVaoDang.Enabled = true;
                lbChucVuDang.Enabled = true;
                txtChucVuDang.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql_add = "insert into nhansu values (N'"+ txtMaNhanSu.Text + "', N'"+ txtHoTen.Text + "', N'"+ txtCMND.Text + "', N'"+ cbGioiTinh.Text + "', N'" + dtNgaySinh.Text + "', N'" +txtDanToc.Text + "', N'" +txtTonGiao.Text + "', N'" +txtQueQuan.Text + "', N'" + txtThuongTru.Text+ "', N'" + txtHocVi.Text+ "', N'" +txtChuyenNganh.Text + "', N'" + txtNgoaiNgu.Text+ "', N'" +cbDonVi.SelectedValue.ToString() + "', N'" + cbChucVu.SelectedValue.ToString()+ "', N'" + cbHinhThuc.Text+ "', N'" +dtNgayLam.Text + "', N'" +dtHetHD.Text + "', N'" +cbDoanDang.Text + "', N'" +dtNgayVaoDang.Text + "', N'" + txtChucVuDang.Text+ "', N'" + txtEmail.Text+ "', N'" +txtDienThoai.Text + "', N'" +txtPhuCap.Text + "', N'" +cbNgachLuong.SelectedValue.ToString() +"')";
            SqlCommand cmd = new SqlCommand(sql_add, myConn);
            if(txtMaNhanSu.Text == "")
            {
                errorProvider.SetError(txtMaNhanSu, "Vui lòng không để trống!!!");
            } else
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
            string manhansu = txtMaNhanSu.Text;
            string sql_del = "delete from nhansu where manhansu = N'" + manhansu + "'";
            string sql_chamcong = "delete from chamcong where manhansu = N'" + manhansu + "'";
            SqlCommand cmd = new SqlCommand(sql_del, myConn);
            SqlCommand cmd2 = new SqlCommand(sql_chamcong, myConn);
            if (txtMaNhanSu.Text == "")
            {
                errorProvider.SetError(txtMaNhanSu, "Vui lòng không để trống !!!");
                txtMaNhanSu.Focus();
            }
            else
            {
                errorProvider.Clear();
                DialogResult DRsult = MessageBox.Show("Xóa tất cả dữ liệu nhân viên này. Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DRsult == DialogResult.Yes)
                {
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    HienThi();
                    Xoa();
                }
            }
            myConn.Close();
        }

        private void cbKhoiDV_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbKhoiDV_TextChanged(object sender, EventArgs e)
        {
            cbChucVu.ResetText();
            cbDonVi.ResetText();
            CB_DonVi();
            CB_ChucVu();
        }

        private void DGV_NhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTg.Text = DGV_NhanSu.CurrentRow.Cells[0].Value.ToString();
            txtMaNhanSu.Text = DGV_NhanSu.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = DGV_NhanSu.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = DGV_NhanSu.CurrentRow.Cells[2].Value.ToString();
            cbGioiTinh.Text = DGV_NhanSu.CurrentRow.Cells[3].Value.ToString();
            dtNgaySinh.Text = DGV_NhanSu.CurrentRow.Cells[4].Value.ToString();
            txtDanToc.Text = DGV_NhanSu.CurrentRow.Cells[5].Value.ToString();
            txtTonGiao.Text = DGV_NhanSu.CurrentRow.Cells[6].Value.ToString();
            txtQueQuan.Text = DGV_NhanSu.CurrentRow.Cells[7].Value.ToString();
            txtThuongTru.Text = DGV_NhanSu.CurrentRow.Cells[8].Value.ToString();
            txtHocVi.Text = DGV_NhanSu.CurrentRow.Cells[9].Value.ToString();
            txtChuyenNganh.Text = DGV_NhanSu.CurrentRow.Cells[10].Value.ToString();
            txtNgoaiNgu.Text = DGV_NhanSu.CurrentRow.Cells[11].Value.ToString();
            cbDonVi.Text = DGV_NhanSu.CurrentRow.Cells[12].Value.ToString();
            cbChucVu.Text = DGV_NhanSu.CurrentRow.Cells[13].Value.ToString();
            cbHinhThuc.Text = DGV_NhanSu.CurrentRow.Cells[14].Value.ToString();
            dtNgayLam.Text = DGV_NhanSu.CurrentRow.Cells[15].Value.ToString();
            dtHetHD.Text = DGV_NhanSu.CurrentRow.Cells[16].Value.ToString();
            cbDoanDang.Text = DGV_NhanSu.CurrentRow.Cells[17].Value.ToString();
            dtNgayVaoDang.Text = DGV_NhanSu.CurrentRow.Cells[18].Value.ToString();
            txtChucVuDang.Text = DGV_NhanSu.CurrentRow.Cells[19].Value.ToString();
            txtEmail.Text = DGV_NhanSu.CurrentRow.Cells[20].Value.ToString();
            txtDienThoai.Text = DGV_NhanSu.CurrentRow.Cells[21].Value.ToString();
            txtPhuCap.Text = DGV_NhanSu.CurrentRow.Cells[22].Value.ToString();
            cbNgachLuong.Text = DGV_NhanSu.CurrentRow.Cells[23].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            if (txtMaNhanSu.Text == "")
            {
                errorProvider.SetError(txtMaNhanSu, "Vui lòng không để trống !!!");
            }
            else
            {
                errorProvider.Clear();
                string tg = lbTg.Text;
                string sql_u1 = "update nhansu set manhansu=N'" + txtMaNhanSu.Text + "', hoten=N'" + txtHoTen.Text + "',CCCD= N'" + txtCMND.Text + "', gioitinh=N'" + cbGioiTinh.Text + "',ngaysinh= N'" + dtNgaySinh.Text + "',dantoc= N'" + txtDanToc.Text + "',tongiao= N'" + txtTonGiao.Text + "',quequan= N'" + txtQueQuan.Text + "',thuongtru= N'" + txtThuongTru.Text + "',hocvicaonhat= N'" + txtHocVi.Text + "', chuyennganh=N'" + txtChuyenNganh.Text + "',trinhdongoaingu= N'" + txtNgoaiNgu.Text + "',madonvi = N'" + cbDonVi.SelectedValue.ToString() + "',machucvu= N'" + cbChucVu.SelectedValue.ToString() + "',hinhthucns= N'" + cbHinhThuc.Text + "',ngayvaolam= N'" + dtNgayLam.Text + "',ngayhethd= N'" + dtHetHD.Text + "',doandang= N'" + cbDoanDang.Text + "',ngayvaodang= N'" + dtNgayVaoDang.Text + "',chucvudang= N'" + txtChucVuDang.Text + "',email= N'" + txtEmail.Text + "',dienthoai= N'" + txtDienThoai.Text + "', phucap=N'" + txtPhuCap.Text + "',mangach= N'" + cbNgachLuong.SelectedValue.ToString() + "' where manhansu = N'" + tg + "'";
                string sql_u2 = "update nhansu set hoten=N'" + txtHoTen.Text + "',CCCD= N'" + txtCMND.Text + "', gioitinh=N'" + cbGioiTinh.Text + "',ngaysinh= N'" + dtNgaySinh.Text + "',dantoc= N'" + txtDanToc.Text + "',tongiao= N'" + txtTonGiao.Text + "',quequan= N'" + txtQueQuan.Text + "',thuongtru= N'" + txtThuongTru.Text + "',hocvicaonhat= N'" + txtHocVi.Text + "', chuyennganh=N'" + txtChuyenNganh.Text + "',trinhdongoaingu= N'" + txtNgoaiNgu.Text + "',madonvi = N'" + cbDonVi.SelectedValue.ToString() + "',machucvu= N'" + cbChucVu.SelectedValue.ToString() + "',hinhthucns= N'" + cbHinhThuc.Text + "',ngayvaolam= N'" + dtNgayLam.Text + "',ngayhethd= N'" + dtHetHD.Text + "',doandang= N'" + cbDoanDang.Text + "',ngayvaodang= N'" + dtNgayVaoDang.Text + "',chucvudang= N'" + txtChucVuDang.Text + "',email= N'" + txtEmail.Text + "',dienthoai= N'" + txtDienThoai.Text + "', phucap=N'" + txtPhuCap.Text + "',mangach= N'" + cbNgachLuong.SelectedValue.ToString() + "' where manhansu = N'" + tg + "'";
                SqlCommand cmd1 = new SqlCommand(sql_u1, myConn);
                SqlCommand cmd2 = new SqlCommand(sql_u2, myConn);
                DialogResult DResult = MessageBox.Show("Bạn có muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (txtMaNhanSu.Text == tg)
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
                string sql_timkiem = "select * from nhansu where hoten like N'%" + timkiem + "%'";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_timkiem, myConn);
                DataTable DT = new DataTable();
                Mydata.Fill(DT);
                DGV_NhanSu.DataSource = DT;
                myConn.Close();
            }
        }
    }
}
