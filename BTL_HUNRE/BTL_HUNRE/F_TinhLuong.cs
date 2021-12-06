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
    public partial class F_TinhLuong : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        DataTable DT = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year;
        DateTime ngaydau, ngaycuoi;
        public F_TinhLuong()
        {
            InitializeComponent();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            TinhLuong();
        }

        private void F_TinhLuong_Load(object sender, EventArgs e)
        {
            txtNam.Value = nam;
            txtThang.Value = thang;
            HienThi();
        }

        private void HienThi()
        {
            
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            int KtNam = Convert.ToInt32(txtNam.Value.ToString());
            ngaydau = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "01/" + txtNam.Value.ToString());
            if(txtThang.Value.ToString() == "1" || txtThang.Value.ToString() == "3" || txtThang.Value.ToString() == "5" || txtThang.Value.ToString() == "7" || txtThang.Value.ToString() == "8" || txtThang.Value.ToString() == "10" || txtThang.Value.ToString() == "12")
            {
                ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "31/" + txtNam.Value.ToString());
            } else if(txtThang.Value.ToString() == "4" || txtThang.Value.ToString() == "6" || txtThang.Value.ToString() == "9" || txtThang.Value.ToString() == "11")
            {
                ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "30/" + txtNam.Value.ToString());
            } else if(txtThang.Text == "2" && KtNam % 4 == 0)
            {
                ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "29/" + txtNam.Value.ToString());
            } else
            {
                ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "28/" + txtNam.Value.ToString());
            }
            string sql = "select nhansu.manhansu, nhansu.hoten, nhansu.phucap, ngachluong.heso, chucvu.phucap as 'phucapcv' from nhansu, chucvu, ngachluong where nhansu.machucvu = chucvu.machucvu and nhansu.mangach = ngachluong.mangach";
            SqlDataAdapter myData = new SqlDataAdapter(sql, myConn);
            DT.Clear();
            DGV_TinhLuong.AutoGenerateColumns = false;
            myData.Fill(DT);
            DGV_TinhLuong.DataSource = DT;
            for(int i=0; i<DGV_TinhLuong.RowCount; i++)
            {
                string manhansu = DGV_TinhLuong.Rows[i].Cells["manhansu"].Value.ToString();
                DGV_TinhLuong.Rows[i].Cells["ngaylam"].Value = DemSoNgayLam(manhansu, ngaydau, ngaycuoi);
                DGV_TinhLuong.Rows[i].Cells["nghiphep"].Value = DemNghiCoPhep(manhansu, ngaydau, ngaycuoi);
                DGV_TinhLuong.Rows[i].Cells["khongphep"].Value = DemNghiKhongPhep(manhansu, ngaydau, ngaycuoi);
            }
            myConn.Close();
        }
        private int DemSoNgayLam(string mans, DateTime ngaydau, DateTime ngaycuoi)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            int songaylam = 0;
            string sql = "select manhansu, COUNT(ngay) as 'ngaylam' from chamcong where manhansu=N'" + mans + "' and (ngay >= N'" + ngaydau + "' and ngay <= N'" + ngaycuoi + "') and trinhtrang = N'Đi Làm' group by manhansu";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                songaylam = DR.GetInt32(1);
            }
            myConn.Close();
            return songaylam;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HienThi();
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
                DataView DV = new DataView(DT);
                DV.RowFilter = "hoten like '%" + timkiem + "%'";
                DGV_TinhLuong.DataSource = DV;
                int KtNam = Convert.ToInt32(txtNam.Value.ToString());
                ngaydau = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "01/" + txtNam.Value.ToString());
                if (txtThang.Value.ToString() == "1" || txtThang.Value.ToString() == "3" || txtThang.Value.ToString() == "5" || txtThang.Value.ToString() == "7" || txtThang.Value.ToString() == "8" || txtThang.Value.ToString() == "10" || txtThang.Value.ToString() == "12")
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "31/" + txtNam.Value.ToString());
                }
                else if (txtThang.Value.ToString() == "4" || txtThang.Value.ToString() == "6" || txtThang.Value.ToString() == "9" || txtThang.Value.ToString() == "11")
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "30/" + txtNam.Value.ToString());
                }
                else if (txtThang.Text == "2" && KtNam % 4 == 0)
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "29/" + txtNam.Value.ToString());
                }
                else
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Value.ToString() + "/" + "28/" + txtNam.Value.ToString());
                }
                for (int i = 0; i < DGV_TinhLuong.RowCount; i++)
                {
                    string manhansu = DGV_TinhLuong.Rows[i].Cells["manhansu"].Value.ToString();
                    DGV_TinhLuong.Rows[i].Cells["ngaylam"].Value = DemSoNgayLam(manhansu, ngaydau, ngaycuoi);
                    DGV_TinhLuong.Rows[i].Cells["nghiphep"].Value = DemNghiCoPhep(manhansu, ngaydau, ngaycuoi);
                    DGV_TinhLuong.Rows[i].Cells["khongphep"].Value = DemNghiKhongPhep(manhansu, ngaydau, ngaycuoi);
                }
                TinhLuong();
            }
        }

        private void txtThang_ValueChanged(object sender, EventArgs e)
        {
            HienThi();
        }

        private int DemNghiCoPhep(string mans, DateTime ngaydau, DateTime ngaycuoi)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            int nghicophep = 0;
            string sql = "select manhansu, COUNT(ngay) as 'nghicophep' from chamcong where manhansu=N'" + mans + "' and (ngay >= N'" + ngaydau + "' and ngay <= N'" + ngaycuoi + "') and trinhtrang = N'Nghỉ Có Phép' group by manhansu";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                nghicophep = DR.GetInt32(1);
            }
            myConn.Close();
            return nghicophep;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DTL = new DataTable();
            DTL.Columns.Add("ID", typeof(string));
            DTL.Columns.Add("Họ tên", typeof(string));
            DTL.Columns.Add("Hệ số lương", typeof(string));
            DTL.Columns.Add("Số ngày làm", typeof(string));
            DTL.Columns.Add("Nghỉ có phép", typeof(string));
            DTL.Columns.Add("Nghỉ không phép", typeof(string));
            DTL.Columns.Add("Thưởng - Phụ cấp", typeof(string));
            DTL.Columns.Add("Phụ cấp chức vụ", typeof(string));
            DTL.Columns.Add("Tổng lương", typeof(string));
            foreach(DataGridViewRow dgv in DGV_TinhLuong.Rows)
            {
                DTL.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value);
            }
            DS.Tables.Add(DTL);
            DS.WriteXmlSchema("Sample.xml");
            CR_DSLuong crv = new CR_DSLuong();
            BC_Luong cr = new BC_Luong();
            cr.SetDataSource(DS);
            crv.CRVLuong.ReportSource = cr;
            crv.CRVLuong.Refresh();
            crv.Show();
        }

        private int DemNghiKhongPhep(string mans, DateTime ngaydau, DateTime ngaycuoi)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            int nghikhongphep = 0;
            string sql = "select manhansu, COUNT(ngay) as 'nghikhongphep' from chamcong where manhansu=N'" + mans + "' and (ngay >= N'" + ngaydau + "' and ngay <= N'" + ngaycuoi + "') and trinhtrang = N'Nghỉ Không Phép' group by manhansu";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                nghikhongphep = DR.GetInt32(1);
            }
            myConn.Close();
            return nghikhongphep;
        }
        private void TinhLuong()
        {
            for (int i=0; i<DGV_TinhLuong.RowCount; i++)
            {
                string heso = DGV_TinhLuong.Rows[i].Cells["heso"].Value.ToString();
                string ngaylam = DGV_TinhLuong.Rows[i].Cells["ngaylam"].Value.ToString();
                string nghiphep = DGV_TinhLuong.Rows[i].Cells["nghiphep"].Value.ToString();
                string khongphep = DGV_TinhLuong.Rows[i].Cells["khongphep"].Value.ToString();
                string phucap = DGV_TinhLuong.Rows[i].Cells["phucap"].Value.ToString();
                string phucapcv = DGV_TinhLuong.Rows[i].Cells["phucapcv"].Value.ToString();
                int tongluong = 0;
                int hs = Int32.Parse(heso);
                int nl = Int32.Parse(ngaylam);
                int np = Int32.Parse(nghiphep);
                int kp = Int32.Parse(khongphep);
                int pc = Int32.Parse(phucap);
                int pccv = Int32.Parse(phucapcv);
                tongluong = ((1490000 * hs) / 26) * nl + pc + pccv;
                DGV_TinhLuong.Rows[i].Cells["tongluong"].Value = String.Format("{0:0,0}", tongluong);
            }
        }
    }
}
