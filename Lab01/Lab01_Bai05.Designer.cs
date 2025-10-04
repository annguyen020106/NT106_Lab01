namespace Lab01
{
    partial class Lab01_Bai05
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
            Button_Xoa = new Button();
            Button_Tinh = new Button();
            TextBox_A = new TextBox();
            label1 = new Label();
            TextBox_B = new TextBox();
            label3 = new Label();
            TextBox_KQ = new TextBox();
            ComboBox_LuaChon = new ComboBox();
            label = new Label();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(566, 457);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 31;
            Button_Next.Text = "Sang bài tiếp theo";
            Button_Next.UseVisualStyleBackColor = false;
            Button_Next.Click += Button_Next_Click;
            // 
            // Button_Home
            // 
            Button_Home.BackColor = Color.CornflowerBlue;
            Button_Home.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Home.ForeColor = Color.Navy;
            Button_Home.Location = new Point(12, 457);
            Button_Home.Name = "Button_Home";
            Button_Home.Size = new Size(130, 33);
            Button_Home.TabIndex = 30;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(453, 189);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 44);
            Button_Xoa.TabIndex = 29;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_Tinh
            // 
            Button_Tinh.BackColor = SystemColors.GradientInactiveCaption;
            Button_Tinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Tinh.ForeColor = Color.Navy;
            Button_Tinh.Location = new Point(161, 189);
            Button_Tinh.Name = "Button_Tinh";
            Button_Tinh.Size = new Size(144, 44);
            Button_Tinh.TabIndex = 28;
            Button_Tinh.Text = "Tính các giá trị";
            Button_Tinh.UseVisualStyleBackColor = false;
            Button_Tinh.Click += Button_Tinh_Click;
            // 
            // TextBox_A
            // 
            TextBox_A.Location = new Point(243, 49);
            TextBox_A.Name = "TextBox_A";
            TextBox_A.Size = new Size(83, 27);
            TextBox_A.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(167, 53);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 24;
            label1.Text = "Nhập A";
            // 
            // TextBox_B
            // 
            TextBox_B.Location = new Point(464, 49);
            TextBox_B.Name = "TextBox_B";
            TextBox_B.Size = new Size(83, 27);
            TextBox_B.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(388, 53);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 32;
            label3.Text = "Nhập B";
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.BackColor = SystemColors.GradientInactiveCaption;
            TextBox_KQ.Location = new Point(161, 267);
            TextBox_KQ.Multiline = true;
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(386, 223);
            TextBox_KQ.TabIndex = 35;
            // 
            // ComboBox_LuaChon
            // 
            ComboBox_LuaChon.FormattingEnabled = true;
            ComboBox_LuaChon.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            ComboBox_LuaChon.Location = new Point(306, 95);
            ComboBox_LuaChon.Name = "ComboBox_LuaChon";
            ComboBox_LuaChon.Size = new Size(151, 28);
            ComboBox_LuaChon.TabIndex = 36;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Navy;
            label.Location = new Point(167, 239);
            label.Name = "label";
            label.Size = new Size(85, 28);
            label.TabIndex = 37;
            label.Text = "Kết quả";
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 498);
            Controls.Add(label);
            Controls.Add(ComboBox_LuaChon);
            Controls.Add(TextBox_KQ);
            Controls.Add(TextBox_B);
            Controls.Add(label3);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_Tinh);
            Controls.Add(TextBox_A);
            Controls.Add(label1);
            Name = "Lab01_Bai05";
            Text = "Bài 05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private Button Button_Home;
        private Button Button_Xoa;
        private Button Button_Tinh;
        private TextBox TextBox_A;
        private Label label1;
        private TextBox TextBox_B;
        private Label label3;
        private TextBox TextBox_KQ;
        private ComboBox ComboBox_LuaChon;
        private Label label;
    }
}