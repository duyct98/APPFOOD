namespace APP_KHACH_CHUAN
{
    partial class thongTinDonHang
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
            this.panelDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongBiil = new System.Windows.Forms.Label();
            this.txtDonHangID = new System.Windows.Forms.Label();
            this.btnHoanThanhDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDonHang
            // 
            this.panelDonHang.AutoScroll = true;
            this.panelDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelDonHang.Location = new System.Drawing.Point(14, 67);
            this.panelDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(432, 507);
            this.panelDonHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn hàng ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(219, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "VND";
            // 
            // txtTongBiil
            // 
            this.txtTongBiil.AutoSize = true;
            this.txtTongBiil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongBiil.Location = new System.Drawing.Point(134, 38);
            this.txtTongBiil.Name = "txtTongBiil";
            this.txtTongBiil.Size = new System.Drawing.Size(79, 20);
            this.txtTongBiil.TabIndex = 4;
            this.txtTongBiil.Text = "0000000";
            // 
            // txtDonHangID
            // 
            this.txtDonHangID.AutoSize = true;
            this.txtDonHangID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDonHangID.Location = new System.Drawing.Point(194, 7);
            this.txtDonHangID.Name = "txtDonHangID";
            this.txtDonHangID.Size = new System.Drawing.Size(19, 20);
            this.txtDonHangID.TabIndex = 5;
            this.txtDonHangID.Text = "0";
            // 
            // btnHoanThanhDonHang
            // 
            this.btnHoanThanhDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanhDonHang.Location = new System.Drawing.Point(317, 7);
            this.btnHoanThanhDonHang.Name = "btnHoanThanhDonHang";
            this.btnHoanThanhDonHang.Size = new System.Drawing.Size(129, 50);
            this.btnHoanThanhDonHang.TabIndex = 6;
            this.btnHoanThanhDonHang.Text = "Hoành thành đơn hàng";
            this.btnHoanThanhDonHang.UseVisualStyleBackColor = true;
            this.btnHoanThanhDonHang.Click += new System.EventHandler(this.btnHoanThanhDonHang_Click);
            // 
            // thongTinDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 585);
            this.Controls.Add(this.btnHoanThanhDonHang);
            this.Controls.Add(this.txtDonHangID);
            this.Controls.Add(this.txtTongBiil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDonHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "thongTinDonHang";
            this.Text = "thongTinDonHang";
            this.Load += new System.EventHandler(this.thongTinDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTongBiil;
        private System.Windows.Forms.Label txtDonHangID;
        private System.Windows.Forms.Button btnHoanThanhDonHang;
    }
}