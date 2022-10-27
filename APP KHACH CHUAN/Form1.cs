using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_KHACH_CHUAN
{
    public partial class Form1 : Form
    {

        public static int cuaHangID { get; set; }
        public static int khachid { get; set; }

        public int getIDShop()
        {
            return cuaHangID;
        }

        public Form1()
        {
            InitializeComponent();

        }
        public string strcon = "Data Source=ADMIN;Initial Catalog=QL_APPFOODtest45;Integrated Security=True";
        public void sqlcode(string data) // select * fromm ....
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand updateCmd = new SqlCommand(data, conn);
            updateCmd.CommandType = CommandType.Text;
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }
        public string Laydatasql(string codesql)
        {
            string data = null;
            SqlConnection conn = new SqlConnection(strcon);
            if (conn == null)
            {
                conn = new SqlConnection(strcon);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = codesql;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                data = reader.GetValue(0).ToString();
               
             
                
            }

            conn.Close();
            reader.Close();
            return data;

        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack_Click(sender,e);



        }
        
        private void listDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void itemFood1_BtnThem_Click(object sender, EventArgs e)
        {
            

        }


        
        public void setKhachId()
        {
            khachid = Convert.ToInt32(Laydatasql("select khachid from tbl_khach where khachid= '"+LOGIN.taikhoan+"'"));
        }
       
        public void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            int donhangid = Convert.ToInt32(Laydatasql("insert tbl_DonHang(NgayBan,KhachID) values (GETDATE(),"+khachid+") SELECT @@IDENTITY asLastID"));
           
            for (int i = 0; i < itemFoodDonHang.listDatHang.Count ; i++)
            {

                if (itemFoodDonHang.listDatHang[i].getSoLuong() > 0)
                {
                    int idfood = itemFoodDonHang.listDatHang[i].getIDFood();
                    int soluong = itemFoodDonHang.listDatHang[i].getSoLuong();
                    
                    sqlcode("insert into tbl_hang(Donhangid,hangid,soluong) values ("+donhangid+",'" + idfood + "','" + soluong + "')");

                }



            }
            itemFoodDonHang.listDatHang.Clear();
            panelDonHang.Controls.Clear();
            txtGia.Text = 0.ToString();
            MessageBox.Show("Đặt hàng thành công !!!!");


        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void itemFood_BtnThem_Click(object sender, EventArgs e)
        {


            itemFoodDonHang.listDatHang[itemFood.getCount].tangSoLuong();

            panelDonHang.Controls.Add(itemFoodDonHang.listDatHang[itemFood.getCount]);

            double gia = itemFoodDonHang.listDatHang[itemFood.getCount].getGiaFood();
            txtGia.Text = (gia + Convert.ToDouble(txtGia.Text)).ToString("0,000");

            



        }
        private void itemFood_BtnHuy_Click(object sender, EventArgs e)
        {

            
            if (itemFoodDonHang.listDatHang[itemFood.getCount].getSoLuong() == 1)
            {
                panelDonHang.Controls.Remove(itemFoodDonHang.listDatHang[itemFood.getCount]);
            }

            itemFoodDonHang.listDatHang[itemFood.getCount].giamSoLuong();

            double gia = itemFoodDonHang.listDatHang[itemFood.getCount].getGiaFood();

            if (Convert.ToDouble(txtGia.Text) > 0&& itemFoodDonHang.listDatHang[itemFood.getCount].getSoLuong()>0)
            {
                txtGia.Text = (Convert.ToDouble(txtGia.Text) - gia).ToString();
            }
            


        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
        
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void groupMenu_Enter(object sender, EventArgs e)
        {

        }

       

        private void groupDangNhap_Enter(object sender, EventArgs e)
        {

        }

      
       

        private void label10_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        { 
            homePanel.Controls.Clear();

            itemFood.listfood.Clear();
            itemFoodDonHang.listDatHang.Clear();

            itemFood.dem = 1;
            
            for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where cuahangid= '" + getIDShop() + "'")); i++)
            {
                itemFood.listfood.Add(new itemFood());
                itemFood.listfood[i].dataFood();

                itemFood.listfood[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                itemFood.listfood[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);

                itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                itemFoodDonHang.listDatHang[i].setIDFood(itemFood.listfood[i].getIDFood());
                itemFoodDonHang.listDatHang[i].setTenFood(itemFood.listfood[i].getTenFood());
                itemFoodDonHang.listDatHang[i].SetGiaFood(itemFood.listfood[i].getGiaFood());
               
                itemFood.listfood[i].count = i;
                itemFoodDonHang.listDatHang[i].count = i;


                homePanel.Controls.Add(itemFood.listfood[i]);
               
            }

            for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(CuaHangID) from tbl_CuaHang")); i++)
            {
               
                ShopFood.listShopFood[i].PictureBox1_Click -=  PictureBox1_Click;

                

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            homePanel.Controls.Clear();
            itemFood.dem = 0;

            if (itemFood.listThucUong.Count > 0)
            {
                for (int i = 0; i < itemFood.listThucUong.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listThucUong[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'monanchinh'")); i++)
                {


                    itemFood.listThucUong.Add(new itemFood());
                    itemFood.listThucUong[i].getDataFood("nuocuong");
                    itemFood.listThucUong[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listThucUong[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listThucUong[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listThucUong[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listThucUong[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listThucUong[i].getGiaFood());
                    itemFood.listThucUong[i].doiMauItemFood(192, 255, 192);
                    itemFood.listThucUong[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "nuocuong";
                    itemFoodDonHang.getCount++;

                }
                textBox2.Text = itemFoodDonHang.getCount.ToString();
            }


        }
        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private void groupDatHangThanhCong_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }
        
            
        private void button4_Click(object sender, EventArgs e)
        {
            homePanel.BackColor=  System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            
            homePanel.Controls.Clear();
            itemFood.dem = 0;
            if (itemFood.listRuouBia.Count > 0)
            {
                for (int i = 0; i < itemFood.listRuouBia.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listRuouBia[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'ruoubia'")); i++)
                {


                    itemFood.listRuouBia.Add(new itemFood());
                    itemFood.listRuouBia[i].getDataFood("ruoubia");
                    itemFood.listRuouBia[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listRuouBia[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listRuouBia[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listRuouBia[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listRuouBia[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listRuouBia[i].getGiaFood());

                    itemFood.listRuouBia[i].doiMauItemFood(255, 255, 128);
                    itemFood.listRuouBia[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "ruoubia";
                    itemFoodDonHang.getCount++;

                }
            }
        }


        
   

        private void button2_Click_1(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            
            homePanel.Controls.Clear();
            itemFood.dem = 0;

            if (itemFood.listAnChinh.Count>0)
            {
                for(int i = 0; i < itemFood.listAnChinh.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listAnChinh[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'monanchinh'")); i++)
                {


                    itemFood.listAnChinh.Add(new itemFood());
                    itemFood.listAnChinh[i].getDataFood("monanchinh");
                    itemFood.listAnChinh[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listAnChinh[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listAnChinh[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listAnChinh[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listAnChinh[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listAnChinh[i].getGiaFood());
                    itemFood.listAnChinh[i].doiMauItemFood(255, 128, 128);
                    itemFood.listAnChinh[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "monanchinh";
                    itemFoodDonHang.getCount++;

                }
                textBox2.Text = itemFoodDonHang.getCount.ToString();
            }

        }

        private void btnAnVat_Click(object sender, EventArgs e)
        {
           
                homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

                homePanel.Controls.Clear();
                itemFood.dem = 0;
            if (itemFood.listAnVat.Count > 0)
            {
                for (int i = 0; i < itemFood.listAnVat.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listAnVat[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'anvat'")); i++)
                {
                    

                    itemFood.listAnVat.Add(new itemFood());
                    itemFood.listAnVat[i].getDataFood("anvat");
                    itemFood.listAnVat[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listAnVat[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listAnVat[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFood.listAnVat[i].doiMauItemFood(128, 255, 255);
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listAnVat[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listAnVat[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listAnVat[i].getGiaFood());
                    itemFood.listAnVat[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "anvat";


                    itemFoodDonHang.getCount++;
                }
                
            }
            
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            txtGia.Text = 0.ToString();
            for(int i=0; i < itemFoodDonHang.listDatHang.Count; i++)
            {
                itemFoodDonHang.listDatHang[i].resetSolLuong();
            }
            panelDonHang.Controls.Clear();
        }
    }
}
