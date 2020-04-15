namespace backgroundworker
{
    partial class Formtimkiem
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
            this.btntim = new System.Windows.Forms.Button();
            this.txtmatimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btntimkiem2 = new System.Windows.Forms.Button();
            this.btnprce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(150, 56);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(195, 44);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm Kiếm Trực Tiếp";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtmatimkiem
            // 
            this.txtmatimkiem.Location = new System.Drawing.Point(34, 65);
            this.txtmatimkiem.Name = "txtmatimkiem";
            this.txtmatimkiem.Size = new System.Drawing.Size(100, 22);
            this.txtmatimkiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã sản phẩm cần tìm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kích Cỡ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn Giá:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(150, 121);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(416, 22);
            this.txtten.TabIndex = 7;
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(150, 158);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(416, 22);
            this.txtkichco.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(150, 197);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(416, 22);
            this.txtsoluong.TabIndex = 9;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(150, 228);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(416, 22);
            this.txtdongia.TabIndex = 10;
            // 
            // btntimkiem2
            // 
            this.btntimkiem2.Location = new System.Drawing.Point(371, 71);
            this.btntimkiem2.Name = "btntimkiem2";
            this.btntimkiem2.Size = new System.Drawing.Size(195, 44);
            this.btntimkiem2.TabIndex = 11;
            this.btntimkiem2.Text = "Tìm Kiếm Dùng Param";
            this.btntimkiem2.UseVisualStyleBackColor = true;
            this.btntimkiem2.Click += new System.EventHandler(this.btntimkiem2_Click);
            // 
            // btnprce
            // 
            this.btnprce.Location = new System.Drawing.Point(371, 13);
            this.btnprce.Name = "btnprce";
            this.btnprce.Size = new System.Drawing.Size(195, 44);
            this.btnprce.TabIndex = 12;
            this.btnprce.Text = "Tìm Kiếm Dùng Proce";
            this.btnprce.UseVisualStyleBackColor = true;
            this.btnprce.Click += new System.EventHandler(this.btnprce_Click);
            // 
            // Formtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 305);
            this.Controls.Add(this.btnprce);
            this.Controls.Add(this.btntimkiem2);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtkichco);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmatimkiem);
            this.Controls.Add(this.btntim);
            this.Name = "Formtimkiem";
            this.Text = "Tìm Theo Mã";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtmatimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btntimkiem2;
        private System.Windows.Forms.Button btnprce;
    }
}