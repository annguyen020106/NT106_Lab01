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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }
        public Lab01_Bai05(Point location, Size size)
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
            Lab01_Bai06 BT = new Lab01_Bai06(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Tính
        private void Button_Tinh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_A.Text.Trim(), out int A) || A <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương cho A!", "Lỗi");
                return;
            }
            if (!int.TryParse(TextBox_B.Text.Trim(), out int B) || B <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương cho B!", "Lỗi");
                return;
            }

            string? luaChon = ComboBox_LuaChon.SelectedItem?.ToString();
            string ketQua = "";

            if (luaChon == "Bảng cửu chương")
            {
                int value = B - A;
                if (value <= 0)
                {
                    MessageBox.Show("Không thể in bảng cửu chương với số âm hoặc 0!", "Lỗi");
                    return;
                }

                ketQua = $"Bảng cửu chương {value}:\r\n";
                for (int i = 1; i <= 10; i++)
                {
                    ketQua += $"{value} x {i} = {value * i}\r\n";
                }
            }
            else if (luaChon == "Tính toán giá trị")
            {
                int hieu = A - B;
                if (hieu < 0)
                {
                    MessageBox.Show("(A - B)! không hợp lệ vì A < B", "Lỗi");
                    return;
                }

                long giaiThua = 1;
                for (int i = 1; i <= hieu; i++) giaiThua *= i;

                long tong = 0;
                for (int i = 1; i <= B; i++)
                {
                    long mu = 1;
                    for (int j = 1; j <= i; j++) mu *= A;
                    tong += mu;
                }

                ketQua = $"(A - B)! = ({A} - {B})! = {giaiThua}\r\n" +
                         $"Tổng S = {A}^1 + {A}^2 + ... + {A}^{B} = {tong}\r\n";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng!", "Thông báo");
            }

            TextBox_KQ.Text = ketQua;
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_A.Text = "";
            TextBox_B.Text = "";
            ComboBox_LuaChon.Text = "";
            TextBox_A.Focus();
        }
    }
}
