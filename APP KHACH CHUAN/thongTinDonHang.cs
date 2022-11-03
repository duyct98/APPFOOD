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
    public partial class thongTinDonHang : Form
    {
        public thongTinDonHang()
        {
            InitializeComponent();
        }
        public static int DonHangId { get; set; }
        public int hangid { get; set; }
        Form1 f1 = new Form1();
        List<ItemDatHang> listItemDatHang = new List<ItemDatHang>();
        private void thongTinDonHang_Load(object sender, EventArgs e)
        {
            txtDonHangID.Text = DonHangId.ToString();
            txtTongBiil.Text = (f1.Laydatasql("select sum(DonGia*SoLuong) from view_Hoadon2 where DonHangID = " + DonHangId + "")).ToString();
            hangid = 0;
            for (int i = 0;i< Convert.ToInt32(f1.Laydatasql("select COUNT(hangid)from view_Hoadon2  where DonHangID = " + DonHangId+"")) ; i++)
            {
                
                while (true)
                {
                    int test = Convert.ToInt32(f1.Laydatasql("select hangid from view_Hoadon2  where DonHangID = " + DonHangId + " and hangid = " + hangid + ""));

                    if (test != 0)
                    {
                        listItemDatHang.Add(new ItemDatHang());
                        listItemDatHang[i].getdata(hangid, DonHangId);
                        panelDonHang.Controls.Add(listItemDatHang[i]);
                        hangid++;
                        break;
                    }
                    hangid++;
                }
                

            }
            

            

           
        }
        public static event EventHandler BtnHoanThanhDonHang_Click;
        private void btnHoanThanhDonHang_Click(object sender, EventArgs e)
        {
            f1.sqlcode("delete from tbl_hang where DonHangID = "+DonHangId+ " delete from tbl_DonHang where DonHangID = "+DonHangId+"");
            f1.refreshHoaDon();
            this.Close();
            if (BtnHoanThanhDonHang_Click != null)
                BtnHoanThanhDonHang_Click.Invoke(this, e);
        }
    }
}
