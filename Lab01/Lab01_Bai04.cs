using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai04 : Form
    {
        private readonly Dictionary<string, (int gia, List<int> phong)> dsPhim = new()
        {
            { "Đào, phở và piano", (45000, new List<int>{1,2,3}) },
            { "Mai", (100000, new List<int>{2,3}) },
            { "Gặp lại chị bầu", (70000, new List<int>{1}) },
            { "Tarot", (90000, new List<int>{3}) }
        };
        private readonly HashSet<string> gheDaBan = new();
        private void InitForm()
        {
            // Load phim
            ComboBox_Phim.Items.AddRange(dsPhim.Keys.ToArray());
            ComboBox_Phim.SelectedIndexChanged += ComboBox_Phim_Chon;

            // Load ghế
            CheckedListBox_Ghe.Items.Clear();
            for (char hang = 'A'; hang <= 'C'; hang++)
                for (int i = 1; i <= 5; i++) CheckedListBox_Ghe.Items.Add($"{hang}{i}");
            
            // Gán nút mua
            Button_Mua.Click += Button_Mua_Click;
        }
        public Lab01_Bai04()
        {
            InitializeComponent();
            InitForm();
        }
        public Lab01_Bai04(Point location, Size size)
        {
            InitializeComponent();
            InitForm();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }
        //Nhấn Home
        private void Button_Home_Click(object? sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
        //Nhấn Next
        private void Button_Next_Click(object? sender, EventArgs e)
        {
            Lab01_Bai05 BT = new Lab01_Bai05(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }

        //Chọn Phim
        private void ComboBox_Phim_Chon(object? sender, EventArgs e)
        {
            ComboBox_Phong.Items.Clear();

            if (ComboBox_Phim.SelectedItem is string tenPhim && dsPhim.ContainsKey(tenPhim))
            {
                var phim = dsPhim[tenPhim];
                foreach (int p in phim.phong)
                    ComboBox_Phong.Items.Add($"Phòng {p}");
            }

            // reset ghế khi đổi phim
            for (int i = 0; i < CheckedListBox_Ghe.Items.Count; i++)
                CheckedListBox_Ghe.SetItemChecked(i, false);
        }

        //Nhấn Mua
        private void Button_Mua_Click(object? sender, EventArgs e)
        {
            string hoTen = TextBox_HoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Lỗi");
                return;
            }

            string? tenPhim = ComboBox_Phim.SelectedItem?.ToString();
            string? phongStr = ComboBox_Phong.SelectedItem?.ToString();

            if (tenPhim == null || phongStr == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Lỗi");
                return;
            }

            if (!dsPhim.ContainsKey(tenPhim))
            {
                MessageBox.Show("Phim không tồn tại!", "Lỗi");
                return;
            }

            var selectedSeats = CheckedListBox_Ghe.CheckedItems.Cast<object>()
                .Select(s => s.ToString()?.Trim() ?? "")
                .Where(s => s != "")
                .ToList();

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Lỗi");
                return;
            }
            if (selectedSeats.Count > 2)
            {
                MessageBox.Show("Không được chọn nhiều hơn 2 ghế!", "Lỗi");
                return;
            }

            int phong = int.Parse(phongStr.Split(' ')[1]);

            var gheTrung = selectedSeats.Where(g => gheDaBan.Contains($"{phong}-{g}")).ToList();
            if (gheTrung.Count > 0)
            {
                MessageBox.Show($"Ghế đã bán: {string.Join(", ", gheTrung)}. Vui lòng chọn lại.", "Thông báo");
                return;
            }

            int giaChuan = dsPhim[tenPhim].gia;
            int tongTien = 0;
            var chiTietGhe = new List<string>();

            foreach (var ghe in selectedSeats)
            {
                int gia = TinhGiaVe(ghe, giaChuan);
                tongTien += gia;
                chiTietGhe.Add($"{ghe} - {gia:N0} đ");
                gheDaBan.Add($"{phong}-{ghe}");
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Họ tên: {hoTen}");
            sb.AppendLine($"Phim: {tenPhim}");
            sb.AppendLine($"Phòng chiếu: {phong}");
            sb.AppendLine("Ghế:");
            foreach (var line in chiTietGhe) sb.AppendLine("  " + line);
            sb.AppendLine($"Tổng tiền: {tongTien:N0} đ");

            TextBox_KQ.Text = sb.ToString();

            for (int i = 0; i < CheckedListBox_Ghe.Items.Count; i++)
                CheckedListBox_Ghe.SetItemChecked(i, false);
        }

        private int TinhGiaVe(string ghe, int giaChuan)
        {
            ghe = ghe.Trim().ToUpper();
            return ghe switch
            {
                "A1" or "A5" or "C1" or "C5" => giaChuan / 4,
                "B2" or "B3" or "B4" => giaChuan * 2,         
                _ => giaChuan                                   
            };
        }
    }
}
