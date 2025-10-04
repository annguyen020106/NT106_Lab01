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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }
        public Lab01_Bai03(Point location, Size size)
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
        //Nhấn Next
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Lab01_Bai031 BT = new Lab01_Bai031(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Đọc
        private void Button_Doc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_So.Text.Trim(), out int n))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So.Focus();
                return;
            }

            if (n < 0 || n > 9)
            {
                MessageBox.Show("Vui lòng nhập số trong khoảng 0 – 9!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox_So.Focus();
                return;
            }

            string[] cachDoc = { "Không", "Một", "Hai", "Ba", "Bốn",
                                 "Năm", "Sáu", "Bảy", "Tám", "Chín" };

            TextBox_KQ.Text = cachDoc[n];
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_So.Text = "";
            TextBox_KQ.Text = "";
            TextBox_So.Focus();
        } 
    }
}
