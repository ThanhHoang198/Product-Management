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
    public partial class Form1 : Form
    {
        SqlConnection ketnoi = null;
        string sqlconn = "Server=DESKTOP-S1U02KO\\THANHTHATTHA;database=thành;User id=sa;pwd=123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void mnufileexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnufilenewproject_Click(object sender, EventArgs e)
        {
            Newproject NEW = new Newproject();
            NEW.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thànhDataSet.sanpham' table. You can move, or remove it, as needed.
          
            /* List<Sanpham> dssp = new List<Sanpham>();
             dssp.Add(new Sanpham() { ma = "01", tensp = "mirinda", soluong = "20", dongia =8000 });
             dssp.Add(new Sanpham() { ma = "02", tensp = "xaxi", soluong = "25", dongia =7000 });
             dssp.Add(new Sanpham() { ma = "03", tensp = "chanleo", soluong = "30", dongia =6500 });
             gvsanpham.DataSource = dssp;*/   //dauadadulieugia vao gv
            DL();
            hienthilentreeview();
            hienthilencbo();
        }

        private void hienthilencbo()
        {
            cbodanhmuc.Items.Clear();
            foreach(Danhmuc x in CSDL)
            {
                cbodanhmuc.Items.Add(x);
            }
        }
        private void cbodanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodanhmuc.SelectedIndex == -1)
                return;
            else
            {
                Danhmuc DM = cbodanhmuc.SelectedItem as Danhmuc;
                hienthiloaisplencbo(DM);
            }
        }

        private void hienthiloaisplencbo(Danhmuc dm)
        {
            cboloai.Items.Clear();
            foreach (Loaisp lsp in dm.dslsp)
            {
                cboloai.Items.Add(lsp);
            }
        }

        private void hienthilistview(Loaisp y)
             {
                 lvsanpham.Items.Clear();
                 foreach (Sanpham x in y.dssp )
                 {
                                   
                     ListViewItem lvi = new ListViewItem(x.ma);
                     lvi.SubItems.Add(x.tensp);
                     lvi.SubItems.Add(x.kichco == false ? "Nhỏ" : "To"); //false la nam, con lai la nu
                     lvi.SubItems.Add(x.soluong);
                     lvi.SubItems.Add(x.dongia.ToString());
                     lvsanpham.Items.Add(lvi);
                    lvi.Tag = x;
                 }
             }

        private void tv_quanli_AfterSelect(object sender, TreeViewEventArgs e) //lấy dữ liệu khi click vào treeview
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 1)
                {
                    xoadulieunhap();
                    Loaisp y = e.Node.Tag as Loaisp;
                    hienthilistview(y);


                }
                else
                {
                    lvsanpham.Items.Clear();
                }
            }
        }


        List<Danhmuc> CSDL = new List<Danhmuc>();
        private void DL()
        {
            Danhmuc Đồ_uống = new Danhmuc() { maDM = "1", tenDM = "Đồ Uống" };
            CSDL.Add(Đồ_uống);

            Danhmuc Đồ_ăn = new Danhmuc() { maDM = "2", tenDM = "Đồ Ăn" };
            CSDL.Add(Đồ_ăn);

            Danhmuc Đồ_dùng = new Danhmuc() { maDM = "3", tenDM = "Đồ Dùng" };
            CSDL.Add(Đồ_dùng);

            Loaisp có_cồn = new Loaisp() { maloaisp = "1", tenloaisp = "Có Cồn",tendm=Đồ_uống };
            Đồ_uống.dslsp.Add(có_cồn);

            Loaisp có_ga = new Loaisp() { maloaisp = "2", tenloaisp = "Có Ga", tendm = Đồ_uống };
            Đồ_uống.dslsp.Add(có_ga);

            Loaisp ăn_nhanh = new Loaisp() { maloaisp = "1", tenloaisp = "Ăn Nhanh", tendm = Đồ_ăn };
            Đồ_ăn.dslsp.Add(ăn_nhanh);

            Loaisp ăn_chậm = new Loaisp() { maloaisp = "2", tenloaisp = "Ăn Chậm", tendm = Đồ_ăn };
            Đồ_ăn.dslsp.Add(ăn_chậm);

            Loaisp gia_dụng = new Loaisp() { maloaisp = "1", tenloaisp = "Gia Dụng", tendm =Đồ_dùng };
            Đồ_dùng.dslsp.Add(gia_dụng);

            Loaisp xây_dựng = new Loaisp() { maloaisp = "2", tenloaisp = "Xây Dựng", tendm = Đồ_dùng };
             Đồ_dùng.dslsp.Add(xây_dựng);

            Sanpham sp1 = new Sanpham() { ma = "01", tensp = "mirinda", kichco = false, soluong = "20", dongia = 8000,loaisp=có_ga};
            Sanpham sp2 = new Sanpham() { ma = "02", tensp = "xaxi", kichco = false, soluong = "25", dongia = 7000, loaisp = có_ga };
            có_ga.dssp.Add(sp1);
            có_ga.dssp.Add(sp2);
            Sanpham sp3 = new Sanpham() { ma = "01", tensp = "vodka", kichco = true, soluong = "30", dongia = 60000, loaisp = có_cồn };
            có_cồn.dssp.Add(sp3);
      }
        private void hienthilentreeview()
        {

            tv_quanli.Nodes.Clear();
            foreach (Danhmuc loai_danhmuc in CSDL)
            {
                TreeNode nodelv0 = new TreeNode(loai_danhmuc.tenDM);
              //  nodelv0.Tag = loai_danhmuc;
                tv_quanli.Nodes.Add(nodelv0);
                foreach (Loaisp loai_sp in loai_danhmuc.dslsp)
                {
                    
                    TreeNode nodelv1 = new TreeNode(loai_sp.tenloaisp);
                   nodelv1.Tag = loai_sp; // gán  tag bằng tên nó để tí lấy tag thì lấy đúng nó ra
                    nodelv0.Nodes.Add(nodelv1);
                  
                }
            }
            tv_quanli.ExpandAll();
        }

        private void Btncapnhat_Click(object sender, EventArgs e) //them vao csdl that
        {

            if (ketnoi == null)

                ketnoi = new SqlConnection(sqlconn);

            if (ketnoi.State == ConnectionState.Closed)
            {
                ketnoi.Open();
            }

             SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "Insert into sanpham(masp,tensanpham,soluong,dongia) " +
          "values(" + txtma.Text + ",N'" + txtten.Text + "'," + txtsoluong.Text + "," + txtdongia.Text + ")";
            command.CommandText =sql;
            command.Connection = ketnoi;
           int kq= command.ExecuteNonQuery();
                if (kq > 0)
                { MessageBox.Show("Thêm Thành Công!"); ketnoi.Close(); }
                else
            MessageBox.Show("Thêm Thất Bại!");
        }

        private void btnthemcach2_Click(object sender, EventArgs e)
        {
            if (ketnoi == null)

                ketnoi = new SqlConnection(sqlconn);

            if (ketnoi.State == ConnectionState.Closed)
            {
                ketnoi.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "Insert into sanpham(masp,tensanpham,soluong,dongia) " + "values(@masp,@tensanpham,@soluong,@dongia)";
            command.Parameters.Add("@masp", SqlDbType.Int).Value = (txtma.Text);
            command.Parameters.Add("@tensanpham", SqlDbType.NVarChar).Value = txtten.Text;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = ( txtsoluong.Text);
            command.Parameters.Add("@dongia", SqlDbType.Int).Value = (txtdongia.Text);
            command.CommandText = sql;
            command.Connection = ketnoi;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
            { MessageBox.Show("Thêm Thành Công!"); ketnoi.Close(); }
            else
                MessageBox.Show("Thêm Thất Bại!");
        
    }

        //them vao csdl gia
        /* {  if(cbodanhmuc.SelectedIndex==-1)
                 {
                     MessageBox.Show("Bạn chưa chọn loại danh mục");
                     return;
                 }
                 if (cboloai.SelectedIndex == -1)
                 {
                     MessageBox.Show("Bạn chưa chọn loại sản phẩm");
                     return;
                 }
                 Sanpham spmoi = new Sanpham();
                 spmoi.ma = txtma.Text;
                 spmoi.tensp = txtten.Text;
                 spmoi.soluong = txtsoluong.Text;
                 spmoi.kichco = radioButton2.Checked;
                 spmoi.dongia = int.Parse(txtdongia.Text);
                Loaisp LSP = cboloai.SelectedItem as Loaisp;
                 spmoi.loaisp = LSP;
                 LSP.dssp.Add(spmoi);
                 //Sanpham newsp = new Sanpham() { ma = txtma.Text, tensp = txtten.Text, soluong = txtsoluong.Text, dongia = txtdongia.Text };

                 xoadulieunhap();
             }*/

        Sanpham selectedsp = null;
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvsanpham.SelectedItems.Count > 0)
            {
                lvsanpham.Items.Remove(lvsanpham.SelectedItems[0]);

                // lvsanpham.Items.RemoveAt(lvsanpham.SelectedItems[0].Index); xoa theo chi so dong
                Loaisp lsp = selectedsp.loaisp;  //xoa trong csdl
                lsp.dssp.Remove(selectedsp);
                xoadulieunhap();
            }
            else
                MessageBox.Show("Bạn chưa chọn đối tượng cần xóa");
        }
        private void xoadulieunhap()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
            cbodanhmuc.Text = "";
            cboloai.Text = "";
            radioButton2.Checked = false;
            radioButton1.Checked = false;

        }

        private void lvsanpham_SelectedIndexChanged(object sender, EventArgs e) //hienthi nguoc lai giao dien
        {
            if (lvsanpham.SelectedItems.Count > 0) //tra ve tap cac phan tu
            {
                ListViewItem lview = lvsanpham.SelectedItems[0]; //chon hang dau tien
                Sanpham sp = lview.Tag as Sanpham;
                /*    txtma.Text = lview.SubItems[0].Text;
                    txtten.Text = lview.SubItems[1].Text;         Từ listview tham chiếu lên
                    txtsoluong.Text = lview.SubItems[2].Text;
                    txtdongia.Text = lview.SubItems[3].Text;*/
                txtma.Text = sp.ma;               
                txtten.Text = sp.tensp;
                if (sp.kichco)
                    radioButton2.Checked = true;
                else radioButton1.Checked = true;
                txtsoluong.Text = sp.soluong;
                cbodanhmuc.Text = sp.loaisp.tendm + "";
                cboloai.Text = sp.loaisp + "";
                //ep kieu roi tham chieu nhu csdl
                txtdongia.Text = sp.dongia + "";
                selectedsp = sp;

            }


        }

















        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picchon.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TEXT|*.txt|tấtca|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Bạn có muốn lưu vào: " + saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Bạn không lưu!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            colorDialog1.Color = btndoimau.BackColor; // lưu lại trên bảng màu khi bật lên
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btndoimau.BackColor = colorDialog1.Color;
            }
        }

        private void btndoifont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lbldoifont.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbldoifont.Font = fontDialog1.Font;
            }
        }

        private void btnchonthumuc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtduogndan.Text = folderBrowserDialog1.SelectedPath; // lưu
            }
        }
      


        private void thêmNToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Cửa_sổ_thêm_node cuaso = new Cửa_sổ_thêm_node();
            if (cuaso.ShowDialog() == DialogResult.OK)
            {

                if (tv_quanli.SelectedNode.Checked == false) // k ấn vào đâu thì chọn tạo mới root
                {
                    TreeNode node = new TreeNode(cuaso.txttennode.Text);
                    tv_quanli.Nodes.Add(node);
                }
                if (tv_quanli.SelectedNode != null) //tao nut con cua selectednode
                {
                    TreeNode node = new TreeNode(cuaso.txttennode.Text);
                    tv_quanli.SelectedNode.Nodes.Add(node);
                    if (node.Level == 2)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 3;
                    }
                }
            }
        }

        private void mnusuanut_Click(object sender, EventArgs e)
        {
            Cửa_sổ_thêm_node cuaso = new Cửa_sổ_thêm_node();
            if (cuaso.ShowDialog() == DialogResult.OK)
            {
                tv_quanli.SelectedNode.Text = cuaso.txttennode.Text;
            }
        }

        private void mnuxoanut_Click(object sender, EventArgs e)
        {
            if (tv_quanli.SelectedNode != null)
                tv_quanli.Nodes.Remove(tv_quanli.SelectedNode);

        }

        private void mnumorong_Click(object sender, EventArgs e)
        {
            if (tv_quanli.SelectedNode != null)
                tv_quanli.SelectedNode.ExpandAll();
        }

        private void mnuthugon_Click(object sender, EventArgs e)
        {
            if (tv_quanli.SelectedNode != null)
                tv_quanli.SelectedNode.Collapse();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)   //xử lí khi chọn tab bất kì
            {
                lvsanpham.BackColor = Color.Blue;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                gvsanpham.BackgroundColor = Color.Yellow;

            }


        }
        private void bảoLồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;  // gán cho button vua click

            btn.Text = "ĐÂY LÀ CONTEXTMENU";

        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            mnufileopen.PerformClick();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            mnufilenewproject.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lbldate.Text = date;
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                int percent = i * 100 / 100;

                backgroundWorker1.ReportProgress(percent, i); // cap nhat giao dien phan tram thuc hien va gia tri can cap nhat
                System.Threading.Thread.Sleep(100);

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolprogress.Value = e.ProgressPercentage; //lay phan tram o tren
            lblhienthi.Text = e.UserState + "";    // lay thang i ra

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // xong dowork thi lam
            button1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(); // goi dowwork lam
        }


        private void lvsanpham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1) // khac tru 1 la co chon
            {
                ColumnHeader col = lvsanpham.Columns[e.Column];
                MessageBox.Show("Bạn chọn cột: " + col.Text);
            }
        }

        private void mnufilesave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                bool kq=FileFactory.savefile(CSDL, saveFileDialog1.FileName);
                if (kq)
                    MessageBox.Show("Lưu thành công!");
            }
        }

        private void mnufileopen_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog()==DialogResult.OK)
            {

                CSDL = FileFactory.openfile(openFileDialog2.FileName);
                hienthilentreeview();
            }
        }


     

        private void btndem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ketnoi == null)

                    ketnoi = new SqlConnection(sqlconn);

                if (ketnoi.State == ConnectionState.Closed)
                {
                    ketnoi.Open();
                    //MessageBox.Show("Kết Nối Thành Công");
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select count(*) from sanpham";
                    command.Connection = ketnoi;
                    object data = command.ExecuteScalar();
                    int n = (int)data;
                    btndem.Text = n + "";
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Formtimkiem molen = new Formtimkiem();
            if(molen.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void btntimkiem2_Click(object sender, EventArgs e)
        {
                Formtimkiem2 form2 = new Formtimkiem2();
                if(form2.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(sqlconn);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "themsanpham";
            command.Connection = ketnoi;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtma.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtten.Text;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = txtsoluong.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtdongia.Text;
            int kq = command.ExecuteNonQuery();
                if(kq>0)
            {
                MessageBox.Show("Them thanh cong!");

            }
                else
            MessageBox.Show("Them that bai!");

        }
        SqlDataAdapter adapter = null; DataSet ds = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(sqlconn);
            adapter = new SqlDataAdapter("Select * from sanpham", ketnoi);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
    
            adapter.Fill(ds,"sanpham");
            gvsanpham.DataSource = ds.Tables["sanpham"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["sanpham"].NewRow();
            row["masp"] = txtma.Text;
            row["tensanpham"] = txtten.Text;
            row["soluong"] = txtsoluong.Text;
            row["dongia"] = txtdongia.Text;
            ds.Tables["sanpham"].Rows.Add(row);
            int kq = adapter.Update(ds.Tables["sanpham"]);
            if (kq > 0)
            {
                btntaidulieu.PerformClick();
                MessageBox.Show("Them thanh cong!");

            }
            else
                MessageBox.Show("Them that bai!");
        }
        int vt = -1;

        private void gvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
                return;
            DataRow row = ds.Tables["sanpham"].Rows[vt];
            txtma.Text = row["masp"]+"";
            txtten.Text = row["tensanpham"]+"";
            txtsoluong.Text = row["soluong"]+"";
            txtdongia.Text = row["dongia"]+"";
        }
        private void gvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e) // nhan vao gia tri trong ô
        {

            /*if (e.RowIndex == -1) return;
            DataGridViewRow row = gvsanpham.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);*/

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {   if(vt==-1)
            {
                MessageBox.Show("ban chua chon dong de sua!");
                return;
            }
            DataRow row = ds.Tables["sanpham"].Rows[vt];
            row.BeginEdit();
            row["masp"] = txtma.Text;
            row["tensanpham"] = txtten.Text;
            row["soluong"] = txtsoluong.Text;
            row["dongia"] = txtdongia.Text;
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["sanpham"]);
            if (kq > 0)
            {
                btntaidulieu.PerformClick();
                MessageBox.Show("Cap nhat thanh cong!");

            }
            else
                MessageBox.Show("Cap nhat that bai!");
        }

        private void btnxoadungadapter_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("ban chua chon dong de sua!");
                return;
            }
            DataRow row = ds.Tables["sanpham"].Rows[vt];
            row.Delete();
            int kq = adapter.Update(ds.Tables["sanpham"]);
            if (kq > 0)
            {
                btntaidulieu.PerformClick();
                MessageBox.Show("Xoa thanh cong!");

            }
            else
                MessageBox.Show("Xoa that bai!");
        }
    }
}
