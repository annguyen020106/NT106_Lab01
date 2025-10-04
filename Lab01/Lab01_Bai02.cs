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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }
        public Lab01_Bai02(Point location, Size size)
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
            Lab01_Bai03 BT = new Lab01_Bai03(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Tìm
        private void Button_Tim_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextBox_So1.Text.Trim(), out double so1))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ! Vui lòng nhập số nguyên.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So1.Focus();
                return;
            }

            if (!double.TryParse(TextBox_So2.Text.Trim(), out double so2))
            {
                MessageBox.Show("Số thứ hai không hợp lệ! Vui lòng nhập số nguyên.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So2.Focus();
                return;
            }

            if (!double.TryParse(TextBox_So3.Text.Trim(), out double so3))
            {
                MessageBox.Show("Số thứ ba không hợp lệ! Vui lòng nhập số nguyên.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So3.Focus();
                return;
            }
            double max = Math.Max(so1, Math.Max(so2, so3));
            double min = Math.Min(so1, Math.Min(so2, so3));

            TextBox_Max.Text = max.ToString();
            TextBox_Min.Text = min.ToString();
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_So1.Text = "";
            TextBox_So2.Text = "";
            TextBox_So3.Text = "";
            TextBox_So1.Focus();
        }
    }
}
