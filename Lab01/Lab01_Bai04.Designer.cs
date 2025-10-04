namespace Lab01
{
    partial class Lab01_Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_Next = new Button();
            Button_Home = new Button();
            TextBox_HoTen = new TextBox();
            ComboBox_Phim = new ComboBox();
            ComboBox_Phong = new ComboBox();
            CheckedListBox_Ghe = new CheckedListBox();
            Button_Mua = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            TextBox_KQ = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(582, 405);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 25;
            Button_Next.Text = "Sang bài tiếp theo";
            Button_Next.UseVisualStyleBackColor = false;
            Button_Next.Click += Button_Next_Click;
            // 
            // Button_Home
            // 
            Button_Home.BackColor = Color.CornflowerBlue;
            Button_Home.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Home.ForeColor = Color.Navy;
            Button_Home.Location = new Point(12, 405);
            Button_Home.Name = "Button_Home";
            Button_Home.Size = new Size(130, 33);
            Button_Home.TabIndex = 24;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // TextBox_HoTen
            // 
            TextBox_HoTen.Location = new Point(172, 53);
            TextBox_HoTen.Name = "TextBox_HoTen";
            TextBox_HoTen.Size = new Size(198, 27);
            TextBox_HoTen.TabIndex = 26;
            // 
            // ComboBox_Phim
            // 
            ComboBox_Phim.FormattingEnabled = true;
            ComboBox_Phim.Location = new Point(172, 104);
            ComboBox_Phim.Name = "ComboBox_Phim";
            ComboBox_Phim.Size = new Size(198, 28);
            ComboBox_Phim.TabIndex = 27;
            ComboBox_Phim.SelectedIndexChanged += ComboBox_Phim_Chon;
            // 
            // ComboBox_Phong
            // 
            ComboBox_Phong.FormattingEnabled = true;
            ComboBox_Phong.Location = new Point(172, 156);
            ComboBox_Phong.Name = "ComboBox_Phong";
            ComboBox_Phong.Size = new Size(198, 28);
            ComboBox_Phong.TabIndex = 28;
            // 
            // CheckedListBox_Ghe
            // 
            CheckedListBox_Ghe.CheckOnClick = true;
            CheckedListBox_Ghe.FormattingEnabled = true;
            CheckedListBox_Ghe.Items.AddRange(new object[] { "A1 (VỚT)", "A2 (THƯỜNG)", "A3 (THƯỜNG)", "A4 (THƯỜNG)", "A5 (VỚT)", "B1", "B2 (VIP)", "B3 (VIP)", "B4 (VIP)", "B5", "C1 (VỚT)", "C2 (THƯỜNG)", "C3 (THƯỜNG)", "C4 (THƯỜNG)", "C5 (VỚT)" });
            CheckedListBox_Ghe.Location = new Point(32, 248);
            CheckedListBox_Ghe.Name = "CheckedListBox_Ghe";
            CheckedListBox_Ghe.Size = new Size(146, 114);
            CheckedListBox_Ghe.TabIndex = 29;
            // 
            // Button_Mua
            // 
            Button_Mua.BackColor = SystemColors.GradientInactiveCaption;
            Button_Mua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Mua.ForeColor = Color.Navy;
            Button_Mua.Location = new Point(207, 374);
            Button_Mua.Name = "Button_Mua";
            Button_Mua.Size = new Size(163, 29);
            Button_Mua.TabIndex = 30;
            Button_Mua.Text = "Mua";
            Button_Mua.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 32;
            label2.Text = "Tên phim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(32, 57);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 31;
            label1.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 33;
            label3.Text = "Số phòng";
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.BackColor = SystemColors.GradientInactiveCaption;
            TextBox_KQ.Location = new Point(411, 74);
            TextBox_KQ.Multiline = true;
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.ReadOnly = true;
            TextBox_KQ.ScrollBars = ScrollBars.Vertical;
            TextBox_KQ.Size = new Size(301, 288);
            TextBox_KQ.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(411, 48);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 35;
            label4.Text = "Thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 207);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 36;
            label5.Text = "Số ghế";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 222);
            label6.Name = "label6";
            label6.Size = new Size(163, 140);
            label6.TabIndex = 37;
            label6.Text = "         MÀN HÌNH\r\n\r\nA1    A2    A3    A4    A5\r\nB1    B2    B3    B4    B5\r\nC1    C2    C3    C4    C5\r\n\r\n          MÁY CHIẾU";
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TextBox_KQ);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button_Mua);
            Controls.Add(CheckedListBox_Ghe);
            Controls.Add(ComboBox_Phong);
            Controls.Add(ComboBox_Phim);
            Controls.Add(TextBox_HoTen);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Name = "Lab01_Bai04";
            Text = "Bài 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private Button Button_Home;
        private TextBox TextBox_HoTen;
        private ComboBox ComboBox_Phim;
        private ComboBox ComboBox_Phong;
        private CheckedListBox CheckedListBox_Ghe;
        private Button Button_Mua;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox TextBox_KQ;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}