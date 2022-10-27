namespace APP_KHACH_CHUAN
{
    partial class Form1
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
            this.homePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.labelGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.panelDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.btnRuouBia = new System.Windows.Forms.Button();
            this.btnMonChinh = new System.Windows.Forms.Button();
            this.btnAnVat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThucUong = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.AutoScroll = true;
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.homePanel.Location = new System.Drawing.Point(0, 75);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(828, 501);
            this.homePanel.TabIndex = 0;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(833, 544);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(228, 32);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Tiến hành đặt món";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.Location = new System.Drawing.Point(1067, 544);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(160, 32);
            this.btnHuyDon.TabIndex = 3;
            this.btnHuyDon.Text = "Hủy Đơn Hàng";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.BackColor = System.Drawing.SystemColors.Control;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGia.Location = new System.Drawing.Point(844, 512);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(159, 24);
            this.labelGia.TabIndex = 4;
            this.labelGia.Text = "Tổng Đơn Hàng";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtGia.Location = new System.Drawing.Point(1022, 509);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(147, 29);
            this.txtGia.TabIndex = 5;
            this.txtGia.Text = "0";
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // panelDonHang
            // 
            this.panelDonHang.AllowDrop = true;
            this.panelDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelDonHang.AutoScroll = true;
            this.panelDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDonHang.Location = new System.Drawing.Point(834, 75);
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(393, 429);
            this.panelDonHang.TabIndex = 7;
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.btnRuouBia);
            this.groupMenu.Controls.Add(this.btnMonChinh);
            this.groupMenu.Controls.Add(this.btnAnVat);
            this.groupMenu.Controls.Add(this.label1);
            this.groupMenu.Controls.Add(this.btnThucUong);
            this.groupMenu.Controls.Add(this.homePanel);
            this.groupMenu.Controls.Add(this.panelDonHang);
            this.groupMenu.Controls.Add(this.txtGia);
            this.groupMenu.Controls.Add(this.labelGia);
            this.groupMenu.Controls.Add(this.btnHuyDon);
            this.groupMenu.Controls.Add(this.btnThanhToan);
            this.groupMenu.Location = new System.Drawing.Point(6, 26);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(1241, 599);
            this.groupMenu.TabIndex = 9;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "MENU";
            this.groupMenu.Enter += new System.EventHandler(this.groupMenu_Enter);
            // 
            // btnRuouBia
            // 
            this.btnRuouBia.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnRuouBia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRuouBia.FlatAppearance.BorderSize = 0;
            this.btnRuouBia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuouBia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRuouBia.Location = new System.Drawing.Point(638, 39);
            this.btnRuouBia.Name = "btnRuouBia";
            this.btnRuouBia.Size = new System.Drawing.Size(190, 36);
            this.btnRuouBia.TabIndex = 11;
            this.btnRuouBia.Text = "RƯỢU - BIA";
            this.btnRuouBia.UseVisualStyleBackColor = false;
            this.btnRuouBia.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMonChinh
            // 
            this.btnMonChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonChinh.FlatAppearance.BorderSize = 0;
            this.btnMonChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMonChinh.Location = new System.Drawing.Point(400, 39);
            this.btnMonChinh.Name = "btnMonChinh";
            this.btnMonChinh.Size = new System.Drawing.Size(232, 36);
            this.btnMonChinh.TabIndex = 10;
            this.btnMonChinh.Text = "MÓN ĂN CHÍNH";
            this.btnMonChinh.UseVisualStyleBackColor = false;
            this.btnMonChinh.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAnVat
            // 
            this.btnAnVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnVat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAnVat.FlatAppearance.BorderSize = 0;
            this.btnAnVat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnVat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAnVat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnVat.Location = new System.Drawing.Point(208, 39);
            this.btnAnVat.Name = "btnAnVat";
            this.btnAnVat.Size = new System.Drawing.Size(186, 36);
            this.btnAnVat.TabIndex = 9;
            this.btnAnVat.Text = "ĂN VẶT";
            this.btnAnVat.UseVisualStyleBackColor = false;
            this.btnAnVat.Click += new System.EventHandler(this.btnAnVat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1174, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "VND";
            // 
            // btnThucUong
            // 
            this.btnThucUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThucUong.FlatAppearance.BorderSize = 0;
            this.btnThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucUong.Location = new System.Drawing.Point(0, 39);
            this.btnThucUong.Name = "btnThucUong";
            this.btnThucUong.Size = new System.Drawing.Size(202, 36);
            this.btnThucUong.TabIndex = 0;
            this.btnThucUong.Text = "THỨC UỐNG";
            this.btnThucUong.UseVisualStyleBackColor = false;
            this.btnThucUong.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, -10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 632);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel homePanel;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.FlowLayoutPanel panelDonHang;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThucUong;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRuouBia;
        private System.Windows.Forms.Button btnMonChinh;
        private System.Windows.Forms.Button btnAnVat;
    }
}

