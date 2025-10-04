using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }
        public Lab01_Bai08(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }
        //Nhấn Home
        private void Button_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
        
        private List<string> dsMonAn = new List<string>();

        //Nhấn Thêm
        private void Button_Them_Click(object sender, EventArgs e)
        {
            string monMoi = TextBox_MonMoi.Text.Trim();

            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập món ăn!", "Thông báo");
                return;
            }

            dsMonAn.Add(monMoi);
            TextBox_DanhSach.Text = string.Join(Environment.NewLine, dsMonAn);

            TextBox_MonMoi.Clear();
            TextBox_MonMoi.Focus();
        }
        //Nhấn Tìm món ăn
        private void Button_TimMon_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống, hãy thêm món trước!", "Thông báo");
                return;
            }

            Random rand = new Random();
            int index = rand.Next(dsMonAn.Count);
            string monAnChon = dsMonAn[index];

            TextBox_KQ.Text = monAnChon;
        }
        // Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            dsMonAn.Clear();
            TextBox_DanhSach.Clear();
        }
    }
}
