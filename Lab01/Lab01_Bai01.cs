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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            TextBox_So1.Focus();
            InitializeComponent();
        }
        public Lab01_Bai01(Point location, Size size)
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
            Lab01_Bai02 BT = new Lab01_Bai02(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        // Nhấn Tính Tổng
        private void Button_KQ_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_So1.Text.Trim(), out int so1))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ! Vui lòng nhập số nguyên.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So1.Focus();
                return;
            }

            if (!int.TryParse(TextBox_So2.Text.Trim(), out int so2))
            {
                MessageBox.Show("Số thứ hai không hợp lệ! Vui lòng nhập số nguyên.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So2.Focus();
                return;
            }

            long tong = (long)so1 + so2;
            TextBox_KQ.Text = tong.ToString();
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_So1.Text = "";
            TextBox_So2.Text = "";
            TextBox_KQ.Text = "";
            TextBox_So1.Focus();
        }
    }
}
