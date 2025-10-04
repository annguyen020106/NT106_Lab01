using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }
        public Lab01_Bai06(Point location, Size size)
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
            Lab01_Bai07 BT = new Lab01_Bai07(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Tìm kiếm
        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox_Ngay.Text.Trim(), out int ngay) ||
                !int.TryParse(TextBox_Thang.Text.Trim(), out int thang) ||
                !int.TryParse(TextBox_Nam.Text.Trim(), out int nam))
            {
                MessageBox.Show("Vui lòng nhập ngày/tháng/năm hợp lệ!", "Lỗi");
                return;
            }

            try
            {
                DateTime dob = new DateTime(nam, thang, ngay);
                string cung = LayCungHoangDao(ngay, thang);
                TextBox_KQ.Text = $"Ngày sinh: {dob:dd/MM/yyyy}\r\n" +
                                  $"Cung hoàng đạo: {cung}";
            }
            catch
            {
                MessageBox.Show("Ngày tháng năm không hợp lệ!", "Lỗi");
            }
        }

        private string LayCungHoangDao(int day, int month)
        {
            if ((day >= 21 && month == 3) || (day <= 20 && month == 4)) return "Bạch Dương (Aries)";
            if ((day >= 21 && month == 4) || (day <= 21 && month == 5)) return "Kim Ngưu (Taurus)";
            if ((day >= 22 && month == 5) || (day <= 21 && month == 6)) return "Song Tử (Gemini)";
            if ((day >= 22 && month == 6) || (day <= 22 && month == 7)) return "Cự Giải (Cancer)";
            if ((day >= 23 && month == 7) || (day <= 22 && month == 8)) return "Sư Tử (Leo)";
            if ((day >= 23 && month == 8) || (day <= 23 && month == 9)) return "Xử Nữ (Virgo)";
            if ((day >= 24 && month == 9) || (day <= 23 && month == 10)) return "Thiên Bình (Libra)";
            if ((day >= 24 && month == 10) || (day <= 22 && month == 11)) return "Thần Nông (Scorpio)";
            if ((day >= 23 && month == 11) || (day <= 21 && month == 12)) return "Nhân Mã (Sagittarius)";
            if ((day >= 22 && month == 12) || (day <= 20 && month == 1)) return "Ma Kết (Capricorn)";
            if ((day >= 21 && month == 1) || (day <= 19 && month == 2)) return "Bảo Bình (Aquarius)";
            if ((day >= 20 && month == 2) || (day <= 20 && month == 3)) return "Song Ngư (Pisces)";
            return "Không xác định";
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_Ngay.Text = "";
            TextBox_Thang.Text = "";
            TextBox_Nam.Text = "";
            TextBox_Ngay.Focus();
        }
    }
}
