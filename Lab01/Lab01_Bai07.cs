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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }
        public Lab01_Bai07(Point location, Size size)
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
            Lab01_Bai08 BT = new Lab01_Bai08(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Xử lý
        private void Button_XuLy_Click(object sender, EventArgs e)
        {
            string input = TextBox_Nhap.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Lỗi");
                return;
            }

            string[] Parts = input.Split(',');
            if (Parts.Length < 2)
            {
                MessageBox.Show("Sai format! Cần nhập: Họ tên, điểm1, điểm2,...", "Lỗi");
                return;
            }

            string HoTen = Parts[0].Trim();
            List<double> DSdiem = new List<double>();

            for (int i = 1; i < Parts.Length; i++)
            {
                if (!double.TryParse(Parts[i].Trim(), out double diem))
                {
                    MessageBox.Show("Sai format điểm tại vị trí: " + i, "Lỗi");
                    return;
                }
                DSdiem.Add(diem);
            }

            string KQ = $"Họ và tên: {HoTen}\r\n";

            for (int i = 0; i < DSdiem.Count; i++)
            {
                if (i < 9) KQ += $"Môn 0{i + 1}: {DSdiem[i]}\t";
                else KQ += $"Môn {i + 1}: {DSdiem[i]}\t";
                if ((i + 1) % 3 == 0) KQ += "\r\n";
            }
            KQ += "\r\n";

            double dtb = DSdiem.Average();
            KQ += $"Điểm trung bình: {dtb:F2}\r\n";

            double max = DSdiem.Max();
            double min = DSdiem.Min();
            int VTmax = DSdiem.IndexOf(max) + 1;
            int VTmin = DSdiem.IndexOf(min) + 1;
            KQ += $"Môn cao nhất: Môn {VTmax} ({max})\r\n";
            KQ += $"Môn thấp nhất: Môn {VTmin} ({min})\r\n";

            int Dau = DSdiem.Count(d => d >= 5);
            int Rot = DSdiem.Count(d => d < 5);
            KQ += $"Số môn đậu: {Dau}\r\n";
            KQ += $"Sô môn rớt: {Rot}\r\n";

            string xepLoai = "Kém";
            if (dtb >= 8 && DSdiem.All(d => d >= 6.5)) xepLoai = "Giỏi";
            else if (dtb >= 6.5 && DSdiem.All(d => d >= 5)) xepLoai = "Khá";
            else if (dtb >= 5 && DSdiem.All(d => d >= 3.5)) xepLoai = "Trung bình";
            else if (dtb >= 3.5 && DSdiem.All(d => d >= 2)) xepLoai = "Yếu";

            KQ += $"Xếp loại: {xepLoai}\r\n";

            TextBox_KQ.Text = KQ;
        }
        //Nhấn Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_Nhap.Clear();
            TextBox_KQ.Clear();
            TextBox_Nhap.Focus();
        }
    }
}
