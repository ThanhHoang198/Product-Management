namespace backgroundworker
{
    partial class Formtimkiem2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvsanpham2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbodanhmuc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasua = new System.Windows.Forms.TextBox();
            this.txttensua = new System.Windows.Forms.TextBox();
            this.txtsoluongsua = new System.Windows.Forms.TextBox();
            this.txtdongiasua = new System.Windows.Forms.TextBox();
            this.btnsuadungparam = new System.Windows.Forms.Button();
            this.btnxoadungparam = new System.Windows.Forms.Button();
            this.btnsuadungproc = new System.Windows.Forms.Button();
            this.btnxoadungproc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvsanpham2
            // 
            this.lvsanpham2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lvsanpham2.FullRowSelect = true;
            this.lvsanpham2.GridLines = true;
            this.lvsanpham2.HideSelection = false;
            this.lvsanpham2.Location = new System.Drawing.Point(165, 47);
            this.lvsanpham2.Name = "lvsanpham2";
            this.lvsanpham2.Size = new System.Drawing.Size(548, 118);
            this.lvsanpham2.TabIndex = 2;
            this.lvsanpham2.UseCompatibleStateImageBehavior = false;
            this.lvsanpham2.View = System.Windows.Forms.View.Details;
            this.lvsanpham2.SelectedIndexChanged += new System.EventHandler(this.lvsanpham2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sản Phẩm";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kích Cỡ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            this.columnHeader4.Width = 100;
            // 
            // lbodanhmuc
            // 
            this.lbodanhmuc.FormattingEnabled = true;
            this.lbodanhmuc.ItemHeight = 16;
            this.lbodanhmuc.Location = new System.Drawing.Point(3, 47);
            this.lbodanhmuc.Name = "lbodanhmuc";
            this.lbodanhmuc.Size = new System.Drawing.Size(147, 372);
            this.lbodanhmuc.TabIndex = 3;
            this.lbodanhmuc.SelectedIndexChanged += new System.EventHandler(this.lbodanhmuc_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtmasua
            // 
            this.txtmasua.Location = new System.Drawing.Point(302, 183);
            this.txtmasua.Name = "txtmasua";
            this.txtmasua.Size = new System.Drawing.Size(287, 22);
            this.txtmasua.TabIndex = 8;
            // 
            // txttensua
            // 
            this.txttensua.Location = new System.Drawing.Point(302, 226);
            this.txttensua.Name = "txttensua";
            this.txttensua.Size = new System.Drawing.Size(287, 22);
            this.txttensua.TabIndex = 9;
            // 
            // txtsoluongsua
            // 
            this.txtsoluongsua.Location = new System.Drawing.Point(302, 268);
            this.txtsoluongsua.Name = "txtsoluongsua";
            this.txtsoluongsua.Size = new System.Drawing.Size(287, 22);
            this.txtsoluongsua.TabIndex = 10;
            // 
            // txtdongiasua
            // 
            this.txtdongiasua.Location = new System.Drawing.Point(302, 310);
            this.txtdongiasua.Name = "txtdongiasua";
            this.txtdongiasua.Size = new System.Drawing.Size(287, 22);
            this.txtdongiasua.TabIndex = 11;
            // 
            // btnsuadungparam
            // 
            this.btnsuadungparam.Location = new System.Drawing.Point(194, 338);
            this.btnsuadungparam.Name = "btnsuadungparam";
            this.btnsuadungparam.Size = new System.Drawing.Size(176, 41);
            this.btnsuadungparam.TabIndex = 12;
            this.btnsuadungparam.Text = "Cập Nhật";
            this.btnsuadungparam.UseVisualStyleBackColor = true;
            this.btnsuadungparam.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoadungparam
            // 
            this.btnxoadungparam.Location = new System.Drawing.Point(438, 338);
            this.btnxoadungparam.Name = "btnxoadungparam";
            this.btnxoadungparam.Size = new System.Drawing.Size(176, 41);
            this.btnxoadungparam.TabIndex = 13;
            this.btnxoadungparam.Text = "Xóa ";
            this.btnxoadungparam.UseVisualStyleBackColor = true;
            this.btnxoadungparam.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsuadungproc
            // 
            this.btnsuadungproc.Location = new System.Drawing.Point(194, 390);
            this.btnsuadungproc.Name = "btnsuadungproc";
            this.btnsuadungproc.Size = new System.Drawing.Size(176, 41);
            this.btnsuadungproc.TabIndex = 14;
            this.btnsuadungproc.Text = "Cập Nhật Dùng Proc";
            this.btnsuadungproc.UseVisualStyleBackColor = true;
            this.btnsuadungproc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoadungproc
            // 
            this.btnxoadungproc.Location = new System.Drawing.Point(438, 386);
            this.btnxoadungproc.Name = "btnxoadungproc";
            this.btnxoadungproc.Size = new System.Drawing.Size(176, 41);
            this.btnxoadungproc.TabIndex = 15;
            this.btnxoadungproc.Text = "Xóa Dùng Proc";
            this.btnxoadungproc.UseVisualStyleBackColor = true;
            this.btnxoadungproc.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formtimkiem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 443);
            this.Controls.Add(this.btnxoadungproc);
            this.Controls.Add(this.btnsuadungproc);
            this.Controls.Add(this.btnxoadungparam);
            this.Controls.Add(this.btnsuadungparam);
            this.Controls.Add(this.txtdongiasua);
            this.Controls.Add(this.txtsoluongsua);
            this.Controls.Add(this.txttensua);
            this.Controls.Add(this.txtmasua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbodanhmuc);
            this.Controls.Add(this.lvsanpham2);
            this.Name = "Formtimkiem2";
            this.Text = "Tìm Theo Danh Mục";
            this.Load += new System.EventHandler(this.Formtimkiem2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvsanpham2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox lbodanhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasua;
        private System.Windows.Forms.TextBox txttensua;
        private System.Windows.Forms.TextBox txtsoluongsua;
        private System.Windows.Forms.TextBox txtdongiasua;
        private System.Windows.Forms.Button btnsuadungparam;
        private System.Windows.Forms.Button btnxoadungparam;
        private System.Windows.Forms.Button btnsuadungproc;
        private System.Windows.Forms.Button btnxoadungproc;
    }
}