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
    public partial class F_ChamCong : Form
    {
        String chuoi = @"Data Source=DESKTOP-2FSGJPD\SQLEXPRESS;Initial Catalog=HUNRE;Integrated Security=True";
        SqlConnection myConn;
        DataTable DT = new DataTable();
        public F_ChamCong()
        {
            InitializeComponent();
        }
        private Boolean KiemTraTT(string manhansu)
        {
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql = "select * from chamcong where ngay=N'" + dtChamCong.Text + "' and manhansu = N'"+ manhansu +"'";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            Boolean kt = true;
            while (DR.Read())
            {
                if(DR.HasRows)
                {
                    kt = false;
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
            string sql = "select * from chamcong where ngay=N'" + dtChamCong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                myConn.Close();
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                DT.Clear();
                DGVChamCong.Refresh();
                string sql_cc = "select chamcong.manhansu,nhansu.hoten,chamcong.trinhtrang from nhansu,chamcong where ngay=N'" + dtChamCong.Text + "' and nhansu.manhansu=chamcong.manhansu";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_cc, myConn);
                Mydata.Fill(DT);
                DGVChamCong.DataSource = DT;
                myConn.Close();

            }
            else
            {
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                DT.Clear();
                DGVChamCong.Refresh();
                string sql_cc = "select manhansu,hoten from nhansu";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_cc, myConn);

                Mydata.Fill(DT);
                DGVChamCong.DataSource = DT;
            }
            myConn.Close();
        }
        private void F_ChamCong_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void lbTittle_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ckkAll.Checked = false;
            myConn = new SqlConnection(chuoi);
            myConn.Open();
            string sql = "select * from chamcong where ngay=N'" + dtChamCong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                myConn.Close();
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                DT.Clear();
                DGVChamCong.Refresh();
                string sql_cc = "select chamcong.manhansu,nhansu.hoten,chamcong.trinhtrang from nhansu,chamcong where ngay=N'" + dtChamCong.Text + "' and nhansu.manhansu=chamcong.manhansu";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_cc, myConn);
                Mydata.Fill(DT);
                DGVChamCong.DataSource = DT;
                myConn.Close();

            } else
            {
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                DT.Clear();
                DGVChamCong.Refresh();
                string sql_cc = "select manhansu,hoten from nhansu";
                SqlDataAdapter Mydata = new SqlDataAdapter(sql_cc, myConn);
                
                Mydata.Fill(DT);
                DGVChamCong.DataSource = DT;
            }
            myConn.Close();
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            if(ckkAll.Checked == true)
            {
                for (int i = 0; i < DGVChamCong.RowCount; i++)
                    DGVChamCong.Rows[i].Cells["TinhTrang"].Value = "Đi Làm";
            } else
            {
                for (int i = 0; i < DGVChamCong.RowCount; i++)
                    DGVChamCong.Rows[i].Cells["TinhTrang"].Value = "";
            }
        }

        private void F_ChamCong_SizeChanged(object sender, EventArgs e)
        {
            lbTittle.Left = (this.Width - lbTittle.Width) / 2;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            for(int i=0; i<DGVChamCong.RowCount; i++)
            {
                string tinhtrang;
                if (DGVChamCong.Rows[i].Cells["TinhTrang"].Value == null)
                {
                    tinhtrang = "Nghỉ Không Phép";
                } else
                {
                    tinhtrang = DGVChamCong.Rows[i].Cells["TinhTrang"].Value.ToString();
                }
                string mans = DGVChamCong.Rows[i].Cells["manhansu"].Value.ToString();
                string sql = null;
                if (KiemTraTT(mans))
                {
                    //insert
                    sql = "insert into chamcong values(N'" + mans + "', N'" + dtChamCong.Text + "', N'" + tinhtrang + "')";
                } else
                {
                    //update
                    sql = "update chamcong set trinhtrang = N'" + tinhtrang + "' where manhansu = N'" + mans + "' and ngay = N'" + dtChamCong.Text + "'";
                }
                myConn = new SqlConnection(chuoi);
                myConn.Open();
                SqlCommand cmd = new SqlCommand(sql, myConn);
                cmd.ExecuteNonQuery();
            }
            myConn.Close();
            DGVChamCong.Refresh();
        }
    }
}
