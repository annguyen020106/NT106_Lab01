namespace Lab01
{
    partial class Lab01_Bai07
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
            TextBox_Nhap = new TextBox();
            TextBox_KQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Button_Xoa = new Button();
            Button_HienThi = new Button();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(553, 405);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 33;
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
            Button_Home.TabIndex = 32;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // TextBox_Nhap
            // 
            TextBox_Nhap.Location = new Point(81, 19);
            TextBox_Nhap.Name = "TextBox_Nhap";
            TextBox_Nhap.Size = new Size(602, 27);
            TextBox_Nhap.TabIndex = 34;
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(12, 103);
            TextBox_KQ.Multiline = true;
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(671, 246);
            TextBox_KQ.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 36;
            label1.Text = "Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 37;
            label2.Text = "Kết quả";
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(448, 355);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 33);
            Button_Xoa.TabIndex = 50;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_HienThi
            // 
            Button_HienThi.BackColor = SystemColors.GradientInactiveCaption;
            Button_HienThi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_HienThi.ForeColor = Color.Navy;
            Button_HienThi.Location = new Point(154, 355);
            Button_HienThi.Name = "Button_HienThi";
            Button_HienThi.Size = new Size(94, 33);
            Button_HienThi.TabIndex = 49;
            Button_HienThi.Text = "Xử lý";
            Button_HienThi.UseVisualStyleBackColor = false;
            Button_HienThi.Click += Button_XuLy_Click;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_HienThi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBox_KQ);
            Controls.Add(TextBox_Nhap);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Name = "Lab01_Bai07";
            Text = "Bài 07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private Button Button_Home;
        private TextBox TextBox_Nhap;
        private TextBox TextBox_KQ;
        private Label label1;
        private Label label2;
        private Button Button_Xoa;
        private Button Button_HienThi;
    }
}