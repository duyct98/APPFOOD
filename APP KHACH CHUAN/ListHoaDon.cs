using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_KHACH_CHUAN
{

    
    public partial class ListHoaDon : UserControl
    {
        public ListHoaDon()
        {
            InitializeComponent();
        }

        public int donHangID { get; set; }
        Form1 f1 = new Form1();
       
        private void button1_Click(object sender, EventArgs e)
        {
            thongTinDonHang.DonHangId = donHangID;
            thongTinDonHang ThongTinDonHang = new thongTinDonHang();
            ThongTinDonHang.Show();
        }
        
       
        private void ListHoaDon_Load(object sender, EventArgs e)
        {
            txtHoaDonID.Text = donHangID.ToString();
            txtGiaFood.Text = f1.Laydatasql("select tongbill from view_Bill1 where donhangid = " + donHangID + " ");

        }
    }
}
