namespace Lab01
{
    partial class Lab01_Bai06
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBox_Ngay = new TextBox();
            TextBox_Thang = new TextBox();
            TextBox_Nam = new TextBox();
            TextBox_KQ = new TextBox();
            Button_Xoa = new Button();
            Button_TimKiem = new Button();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(567, 405);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 35;
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
            Button_Home.TabIndex = 34;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(80, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 36;
            label1.Text = "Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(279, 64);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 37;
            label2.Text = "Tháng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(487, 64);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 38;
            label3.Text = "Năm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(80, 218);
            label4.Name = "label4";
            label4.Size = new Size(270, 28);
            label4.TabIndex = 39;
            label4.Text = "Cung hoàng đạo của bạn là";
            // 
            // TextBox_Ngay
            // 
            TextBox_Ngay.Location = new Point(148, 64);
            TextBox_Ngay.Name = "TextBox_Ngay";
            TextBox_Ngay.Size = new Size(76, 27);
            TextBox_Ngay.TabIndex = 43;
            // 
            // TextBox_Thang
            // 
            TextBox_Thang.Location = new Point(356, 64);
            TextBox_Thang.Name = "TextBox_Thang";
            TextBox_Thang.Size = new Size(76, 27);
            TextBox_Thang.TabIndex = 44;
            // 
            // TextBox_Nam
            // 
            TextBox_Nam.Location = new Point(550, 64);
            TextBox_Nam.Name = "TextBox_Nam";
            TextBox_Nam.Size = new Size(84, 27);
            TextBox_Nam.TabIndex = 45;
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(356, 218);
            TextBox_KQ.Multiline = true;
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(278, 58);
            TextBox_KQ.TabIndex = 46;
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(436, 298);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 33);
            Button_Xoa.TabIndex = 48;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_TimKiem
            // 
            Button_TimKiem.BackColor = SystemColors.GradientInactiveCaption;
            Button_TimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_TimKiem.ForeColor = Color.Navy;
            Button_TimKiem.Location = new Point(166, 298);
            Button_TimKiem.Name = "Button_TimKiem";
            Button_TimKiem.Size = new Size(144, 33);
            Button_TimKiem.TabIndex = 47;
            Button_TimKiem.Text = "Tìm kiếm";
            Button_TimKiem.UseVisualStyleBackColor = false;
            Button_TimKiem.Click += Button_TimKiem_Click;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_TimKiem);
            Controls.Add(TextBox_KQ);
            Controls.Add(TextBox_Nam);
            Controls.Add(TextBox_Thang);
            Controls.Add(TextBox_Ngay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Name = "Lab01_Bai06";
            Text = "Bài 06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private Button Button_Home;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBox_Ngay;
        private TextBox TextBox_Thang;
        private TextBox TextBox_Nam;
        private TextBox TextBox_KQ;
        private Button Button_Xoa;
        private Button Button_TimKiem;
    }
}