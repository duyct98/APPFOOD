using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APP_KHACH_CHUAN
{
    public partial class itemFood : UserControl
    {

        public int idFood = 0;
        public string tenFood = null;
        public Double giaFood=0;
        public static int getCount;
        public static int dem = 1;
        Form1 f1 = new Form1();
        public itemFood()
        {

            InitializeComponent();
        }
        public static List<itemFood> listfood = new List<itemFood>();
        public static List<itemFood> listThucUong = new List<itemFood>();
        public static List<itemFood> listRuouBia = new List<itemFood>();
        public static List<itemFood> listAnVat = new List<itemFood>();
        public static List<itemFood> listAnChinh = new List<itemFood>();

        public event EventHandler BtnThem_Click;
        public event EventHandler BtnHuy_Click;
        
        public static Image Pic = null;


        public static Image anh(Image data)
        {
            Pic = data;
            return data;
        }




        

        public int count { get; set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            getCount = count;
            if (BtnThem_Click!=null)
                BtnThem_Click.Invoke(this, e);
            
            
        }
       
        
        private void sqlcode(string data) // select * fromm ....
        {
            SqlConnection conn = new SqlConnection(f1.strcon);
            conn.Open();
            SqlCommand updateCmd = new SqlCommand(data, conn);
            updateCmd.CommandType = CommandType.Text;
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }
      
        public void setTenFood(string data)
        {
            txtTenFood.Text = data;
        }
        public string getTenFood()
        {
            return txtTenFood.Text;
        }
        public void setIDFood(int data)
        {
            idFood = data;
        }
        public int getIDFood()
        {
            return idFood;
        }
        public void SetGiaFood(string data)
        {
            txtGiaFood.Text = data;
        }
        public double getGiaFood()
        {
            return Convert.ToDouble(txtGiaFood.Text);
        }
       
        public void dataFood()
        {
            while (true)
            {

                
                    


                    idFood = Convert.ToInt32(f1.Laydatasql("select HangID from tbl_hangban where HangID='" + dem + "' and cuahangid= '"+ f1.getIDShop() + "'" ));
                    txtTenFood.Text = f1.Laydatasql("select TenHang from tbl_hangban where hangid='" + dem + "'and cuahangid= '" + f1.getIDShop() + " '");
                    tenFood = txtTenFood.Text;
                    giaFood = Convert.ToDouble(f1.Laydatasql("select DonGia from tbl_hangban where hangid='" + dem + "'and cuahangid= '"+ f1.getIDShop() + "'"));
                    txtGiaFood.Text = giaFood.ToString();
               
               

                dem++;





                if (tenFood != ""&& tenFood != null)
                {
                    string ss = "SELECT anh from tbl_hangban where HangID = '" + idFood + "'and cuahangid= '"+ f1.getIDShop() + " '";

                    SqlConnection conn = new SqlConnection(f1.strcon);
                    conn.Open();
                    SqlCommand command = new SqlCommand(ss, conn);

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        picturebox1.BackgroundImage = Image.FromStream(ms);

                    }

                    break;
                }
                



            }
            
        }
        public void getDataFood(string data) // 
        {
            
            
            while (true)
                {
                dem++;
                idFood = Convert.ToInt32(f1.Laydatasql("select hangid from tbl_hangban where loai='" + data + "' and hangid=" + dem + ""));
                if (idFood != 0)
                    {
                        tenFood = f1.Laydatasql("select tenhang from tbl_hangban where loai='"+data+"' and hangid="+idFood+"");
                        giaFood = Convert.ToDouble(f1.Laydatasql("select dongia from tbl_hangban where loai='"+data+ "'and hangid=" + idFood+""));
                        txtGiaFood.Text = giaFood.ToString();
                        txtTenFood.Text = tenFood;
                        string ss = "SELECT anh from tbl_hangban where HangID = " + idFood + "and loai='"+data+"'";

                        SqlConnection conn = new SqlConnection(f1.strcon);
                        conn.Open();
                        SqlCommand command = new SqlCommand(ss, conn);

                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        picturebox1.BackgroundImage = Image.FromStream(ms);

                    }
                    
                    break;
                        
                        
                    }
                
                
                
                }
            
            
        }


        public void doiMauItemFood(int data1, int data2, int data3)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(data1)))), ((int)(((byte)(data2)))), ((int)(((byte)(data3)))));

        }
        public void itemFood_Load(object sender, EventArgs e)
        {
           
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            getCount = count;
            if (BtnHuy_Click != null)
                BtnHuy_Click.Invoke(this, e);

        }
        public void insertDonHang()
        {
            
        }
    }
}
