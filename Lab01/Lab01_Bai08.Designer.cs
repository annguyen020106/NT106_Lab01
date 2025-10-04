namespace Lab01
{
    partial class Lab01_Bai08
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
            Button_Home = new Button();
            Button_Xoa = new Button();
            Button_Tim = new Button();
            label1 = new Label();
            TextBox_DanhSach = new TextBox();
            TextBox_MonMoi = new TextBox();
            Button_Them = new Button();
            label3 = new Label();
            TextBox_KQ = new TextBox();
            SuspendLayout();
            // 
            // Button_Home
            // 
            Button_Home.BackColor = Color.CornflowerBlue;
            Button_Home.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Home.ForeColor = Color.Navy;
            Button_Home.Location = new Point(12, 405);
            Button_Home.Name = "Button_Home";
            Button_Home.Size = new Size(130, 33);
            Button_Home.TabIndex = 32;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(527, 261);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 33);
            Button_Xoa.TabIndex = 56;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_Tim
            // 
            Button_Tim.BackColor = SystemColors.GradientInactiveCaption;
            Button_Tim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Tim.ForeColor = Color.Navy;
            Button_Tim.Location = new Point(336, 261);
            Button_Tim.Name = "Button_Tim";
            Button_Tim.Size = new Size(132, 33);
            Button_Tim.TabIndex = 55;
            Button_Tim.Text = "Tìm món ăn";
            Button_Tim.UseVisualStyleBackColor = false;
            Button_Tim.Click += Button_TimMon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 53;
            label1.Text = "Nhập món ăn";
            // 
            // TextBox_DanhSach
            // 
            TextBox_DanhSach.Location = new Point(336, 24);
            TextBox_DanhSach.Multiline = true;
            TextBox_DanhSach.Name = "TextBox_DanhSach";
            TextBox_DanhSach.Size = new Size(285, 231);
            TextBox_DanhSach.TabIndex = 52;
            // 
            // TextBox_MonMoi
            // 
            TextBox_MonMoi.Location = new Point(142, 24);
            TextBox_MonMoi.Name = "TextBox_MonMoi";
            TextBox_MonMoi.Size = new Size(188, 27);
            TextBox_MonMoi.TabIndex = 51;
            // 
            // Button_Them
            // 
            Button_Them.BackColor = SystemColors.GradientInactiveCaption;
            Button_Them.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Them.ForeColor = Color.Navy;
            Button_Them.Location = new Point(236, 57);
            Button_Them.Name = "Button_Them";
            Button_Them.Size = new Size(94, 33);
            Button_Them.TabIndex = 57;
            Button_Them.Text = "Thêm";
            Button_Them.UseVisualStyleBackColor = false;
            Button_Them.Click += Button_Them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(167, 329);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 59;
            label3.Text = "Món ăn hôm nay là";
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(336, 325);
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(285, 27);
            TextBox_KQ.TabIndex = 58;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(TextBox_KQ);
            Controls.Add(Button_Them);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_Tim);
            Controls.Add(label1);
            Controls.Add(TextBox_DanhSach);
            Controls.Add(TextBox_MonMoi);
            Controls.Add(Button_Home);
            Name = "Lab01_Bai08";
            Text = "Bài 08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Home;
        private Button Button_Xoa;
        private Button Button_Tim;
        private Label label1;
        private TextBox TextBox_DanhSach;
        private TextBox TextBox_MonMoi;
        private Button Button_Them;
        private Label label3;
        private TextBox TextBox_KQ;
    }
}