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
    public partial class Formtimkiem : Form
    {
        SqlConnection ketnoi = null;
        string sqlconn = "Server=DESKTOP-S1U02KO\\THANHTHATTHA;database=thành;User id=sa;pwd=123456";

        public Formtimkiem()
        {
            InitializeComponent();
        }

        private void btntim_Click(object sender, EventArgs e)
        {

            if (ketnoi == null)

                ketnoi = new SqlConnection(sqlconn);

            if (ketnoi.State == ConnectionState.Closed)
            {
                ketnoi.Open();
            }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from sanpham where masp=" + txtmatimkiem.Text;
                command.Connection = ketnoi;
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()) //co du lieu thi bang true
                {
                    txtten.Text = reader.GetString(1);                
                    txtsoluong.Text = reader.GetInt32(4)+"";
                    txtdongia.Text = reader.GetInt32(5) + "";
                
                }
            reader.Close();
            }

        private void btntimkiem2_Click(object sender, EventArgs e)
        {
            if (ketnoi == null)

                ketnoi = new SqlConnection(sqlconn);

            if (ketnoi.State == ConnectionState.Closed)
            {
                ketnoi.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from sanpham where masp=@ma";
            command.Connection = ketnoi;
            SqlParameter pram = new SqlParameter("@ma", SqlDbType.Int);
            pram.Value = txtmatimkiem.Text;
            command.Parameters.Add(pram);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) //co du lieu thi bang true
            {
                txtten.Text = reader.GetString(1);
                txtsoluong.Text = reader.GetInt32(4) + "";
                txtdongia.Text = reader.GetInt32(5) + "";
            }
            reader.Close();

        }

        private void btnprce_Click(object sender, EventArgs e)
        {
            int ma =int.Parse( txtmatimkiem.Text);
            laysanphamtheoma(ma);
        }

        private void laysanphamtheoma(int ma)
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(sqlconn);
            if (ketnoi.State == ConnectionState.Closed)
            { ketnoi.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "laysanphamtheoma";
            command.Connection = ketnoi;
          
            SqlParameter param = new SqlParameter("@ma", SqlDbType.Int);
            param.Value = ma;
            command.Parameters.Add(param);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtten.Text = reader.GetString(1);
                txtsoluong.Text = reader.GetInt32(4) + "";
                txtdongia.Text = reader.GetInt32(5) + "";

            }
            reader.Close();
        }
    }
    }

