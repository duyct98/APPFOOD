﻿namespace APP_KHACH_CHUAN
{
    partial class itemFoodDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tenFood = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.Gia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenFood
            // 
            this.tenFood.AutoSize = true;
            this.tenFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tenFood.Location = new System.Drawing.Point(6, 15);
            this.tenFood.Name = "tenFood";
            this.tenFood.Size = new System.Drawing.Size(47, 24);
            this.tenFood.TabIndex = 0;
            this.tenFood.Text = "Tên";
            this.tenFood.Click += new System.EventHandler(this.tenFood_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.Enabled = false;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SoLuong.Location = new System.Drawing.Point(331, 24);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(40, 29);
            this.SoLuong.TabIndex = 3;
            this.SoLuong.Text = "0";
            this.SoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Enabled = false;
            this.Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Gia.Location = new System.Drawing.Point(12, 39);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(41, 24);
            this.Gia.TabIndex = 4;
            this.Gia.Text = "Giá";
            // 
            // itemFoodDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.tenFood);
            this.Name = "itemFoodDonHang";
            this.Size = new System.Drawing.Size(385, 73);
            this.Load += new System.EventHandler(this.itemFoodDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenFood;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label Gia;
    }
}