﻿namespace CUAHANG
{
    partial class itemOrder
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
            this.txtHoaDonID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txtGiaFood = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoaDonID
            // 
            this.txtHoaDonID.AutoSize = true;
            this.txtHoaDonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonID.Location = new System.Drawing.Point(55, 16);
            this.txtHoaDonID.Name = "txtHoaDonID";
            this.txtHoaDonID.Size = new System.Drawing.Size(28, 20);
            this.txtHoaDonID.TabIndex = 1;
            this.txtHoaDonID.Text = "ID";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(16, 16);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(33, 20);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID:";
            // 
            // txtGiaFood
            // 
            this.txtGiaFood.AutoSize = true;
            this.txtGiaFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaFood.Location = new System.Drawing.Point(282, 16);
            this.txtGiaFood.Name = "txtGiaFood";
            this.txtGiaFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaFood.Size = new System.Drawing.Size(83, 20);
            this.txtGiaFood.TabIndex = 2;
            this.txtGiaFood.Text = "Gia Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng hoá đơn: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(395, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "THỰC HIỆN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtGiaFood);
            this.Controls.Add(this.txtHoaDonID);
            this.Name = "itemOrder";
            this.Size = new System.Drawing.Size(530, 50);
            this.Load += new System.EventHandler(this.itemOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtHoaDonID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label txtGiaFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
