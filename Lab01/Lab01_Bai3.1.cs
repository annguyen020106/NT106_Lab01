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
    public partial class Lab01_Bai031 : Form
    {
        public Lab01_Bai031()
        {
            InitializeComponent();
        }
        public Lab01_Bai031(Point location, Size size)
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
            Lab01_Bai04 BT = new Lab01_Bai04(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        // Nhấn Đọc
        private void Button_Doc_Click(object sender, EventArgs e)
        {
            string raw = TextBox_So.Text.Trim();

            if (!long.TryParse(raw, out long n) || raw.Length > 12)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ (chỉ chấp nhận số nguyên <= 12 chữ số)!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_So.Focus();
                return;
            }

            if (raw.Length == 1)
            {
                string[] cachDoc = { "Không", "Một", "Hai", "Ba", "Bốn",
                                     "Năm", "Sáu", "Bảy", "Tám", "Chín" };
                TextBox_KQ.Text = cachDoc[n];
            }else
            {
                TextBox_KQ.Text = DocSoTiengViet(n);
            }
        }
        // Enter = Tab
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private string DocSoTiengViet(long number)
        {
            if (number == 0) return "Không";

            string[] donVi = { "", "nghìn", "triệu", "tỷ" };
            string[] so = { "không", "một", "hai", "ba", "bốn",
                            "năm", "sáu", "bảy", "tám", "chín" };

            string result = "";
            int group = 0;

            while (number > 0)
            {
                int block = (int)(number % 1000);
                number /= 1000;

                if (block > 0)
                {
                    string blockStr = DocBlock(block, so);
                    if (group > 0) result = blockStr + " " + donVi[group] + " " + result;
                    else result = blockStr + " " + result;
                }
                group++;
            }

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.Trim());
        }
        private string DocBlock(int number, string[] so)
        {
            int tram = number / 100;
            int chuc = (number / 10) % 10;
            int donvi = number % 10;
            string result = "";

            if (tram > 0)
            {
                result += so[tram] + " trăm";
                if (chuc == 0 && donvi > 0) result += " lẻ";
            }

            if (chuc > 0)
            {
                if (chuc == 1) result += " mười";
                else result += " " + so[chuc] + " mươi";
            }

            if (donvi > 0)
            {
                if (chuc == 0 && tram == 0) result += so[donvi];
                else if (donvi == 1 && chuc > 1) result += " mốt";
                else if (donvi == 5 && chuc > 0) result += " lăm";
                else result += " " + so[donvi];
            }

            return result.Trim();
        }
        // Xóa
        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            TextBox_So.Text = "";
            TextBox_KQ.Text = "";
            TextBox_So.Focus();
        }
    }
}
