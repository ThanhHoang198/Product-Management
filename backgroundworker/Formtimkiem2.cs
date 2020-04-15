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

namespace backgroundworker
{
    public partial class Formtimkiem2 : Form
    {
        public Formtimkiem2()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = null;
        string sqlconn = "Server=DESKTOP-S1U02KO\\THANHTHATTHA;database=thành;User id=sa;pwd=123456";
        private void Formtimkiem2_Load(object sender, EventArgs e)
        {

            if (ketnoi == null)
            { ketnoi = new SqlConnection(sqlconn); }
            if (ketnoi.State == ConnectionState.Closed)
            { ketnoi.Open(); }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from loaisp";
            command.Connection = ketnoi;

            lbodanhmuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string line = reader.GetInt32(0) + "-" + reader.GetString(1);
                lbodanhmuc.Items.Add(line);
            }
            reader.Close();

        }

        int madm = -1;

        private void lbodanhmuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbodanhmuc.SelectedIndex == -1)
                return;
            string line = lbodanhmuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            madm = int.Parse(arr[0]);
            hienthilenlview(madm);
        } 
           

        private void hienthilenlview(int madm)
         {  if (ketnoi == null)
             ketnoi = new SqlConnection(sqlconn);
    
            if (ketnoi.State == ConnectionState.Closed)
            { ketnoi.Open(); }
           SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from sanpham where maloai=@ma";
            command.Connection = ketnoi;
            SqlParameter pram = new SqlParameter("@ma", SqlDbType.Int);
            pram.Value = madm;
            command.Parameters.Add(pram);
            lvsanpham2.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
            string ten = reader.GetString(1);
            int soluong = reader.GetInt32(4);
            int dongia = reader.GetInt32(5);
            ListViewItem lv2 = new ListViewItem(ma + "");
            lv2.SubItems.Add(ten);
                lv2.SubItems.Add("");
                lv2.SubItems.Add(soluong+"");
                lv2.SubItems.Add(dongia+"");
                lvsanpham2.Items.Add(lv2);

            }
            reader.Close();
        }
        private void lvsanpham2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsanpham2.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvsanpham2.SelectedItems[0];
            txtmasua.Text = lvi.SubItems[0].Text;
            txttensua.Text= lvi.SubItems[1].Text;
            txtsoluongsua.Text= lvi.SubItems[3].Text;
            txtdongiasua.Text= lvi.SubItems[4].Text;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvsanpham2.SelectedItems.Count > 0)
            {
                if (ketnoi == null)
                { ketnoi = new SqlConnection(sqlconn); }
                if (ketnoi.State == ConnectionState.Closed)
                { ketnoi.Open(); }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "update sanpham set tensanpham=@ten,soluong=@sl,dongia=@gia where masp=@ma";
                command.CommandText = sql;
                command.Connection = ketnoi;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txttensua.Text;
                command.Parameters.Add("@sl", SqlDbType.Int).Value = txtsoluongsua.Text;
                command.Parameters.Add("@gia", SqlDbType.Int).Value = txtdongiasua.Text;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtmasua.Text;
                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    hienthilenlview(madm);
                    MessageBox.Show("Cập Nhật Thành Công!"); ketnoi.Close();
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại!");
            }
            else
                MessageBox.Show("Bạn chưa chọn đối tượng cần cập nhật");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvsanpham2.SelectedItems.Count > 0)
            {
                if (ketnoi == null)
                { ketnoi = new SqlConnection(sqlconn); }
                if (ketnoi.State == ConnectionState.Closed)
                { ketnoi.Open(); }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from sanpham where masp=@ma";
                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtmasua.Text;
                command.Connection = ketnoi;
                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    hienthilenlview(madm);
                    MessageBox.Show("Xóa Thành Công!"); ketnoi.Close();
                }
                else
                    MessageBox.Show("Xóa Thất Bại!");

            }
            else
                MessageBox.Show("Bạn chưa chọn đối tượng cần xóa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvsanpham2.SelectedItems.Count > 0)
            {
                if (ketnoi == null)
                { ketnoi = new SqlConnection(sqlconn); }
                if (ketnoi.State == ConnectionState.Closed)
                { ketnoi.Open(); }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "capnhat";
                command.Connection = ketnoi;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txttensua.Text;
                command.Parameters.Add("@soluong", SqlDbType.Int).Value = txtsoluongsua.Text;
                command.Parameters.Add("@gia", SqlDbType.Int).Value = txtdongiasua.Text;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtmasua.Text;
                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    hienthilenlview(madm);
                    MessageBox.Show("Cập Nhật Thành Công!"); ketnoi.Close();
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại!");
            }
            else
                MessageBox.Show("Bạn chưa chọn đối tượng cần cập nhật");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lvsanpham2.SelectedItems.Count > 0)
            {
                if (ketnoi == null)
                { ketnoi = new SqlConnection(sqlconn); }
                if (ketnoi.State == ConnectionState.Closed)
                { ketnoi.Open(); }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "xoadulieu";
                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtmasua.Text;
                command.Connection = ketnoi;
                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    hienthilenlview(madm);
                    MessageBox.Show("Xóa Thành Công!"); ketnoi.Close();
                }
                else
                    MessageBox.Show("Xóa Thất Bại!");
            }
        }
    }
}
