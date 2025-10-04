namespace Lab01
{
    partial class Lab01_Bai03
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
            TextBox_KQ = new TextBox();
            TextBox_So = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Button_Xoa = new Button();
            Button_Doc = new Button();
            Button_Next = new Button();
            Button_Home = new Button();
            SuspendLayout();
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(133, 209);
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(322, 27);
            TextBox_KQ.TabIndex = 18;
            // 
            // TextBox_So
            // 
            TextBox_So.Location = new Point(399, 77);
            TextBox_So.Name = "TextBox_So";
            TextBox_So.Size = new Size(56, 27);
            TextBox_So.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(133, 183);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 15;
            label2.Text = "Kết quả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(133, 85);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 14;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(547, 207);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 29);
            Button_Xoa.TabIndex = 20;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_Doc
            // 
            Button_Doc.BackColor = SystemColors.GradientInactiveCaption;
            Button_Doc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Doc.ForeColor = Color.Navy;
            Button_Doc.Location = new Point(547, 82);
            Button_Doc.Name = "Button_Doc";
            Button_Doc.Size = new Size(94, 29);
            Button_Doc.TabIndex = 19;
            Button_Doc.Text = "Đọc";
            Button_Doc.UseVisualStyleBackColor = false;
            Button_Doc.Click += Button_Doc_Click;
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(613, 379);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 23;
            Button_Next.Text = "Sang bài tiếp theo";
            Button_Next.UseVisualStyleBackColor = false;
            Button_Next.Click += Button_Next_Click;
            // 
            // Button_Home
            // 
            Button_Home.BackColor = Color.CornflowerBlue;
            Button_Home.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Home.ForeColor = Color.Navy;
            Button_Home.Location = new Point(12, 379);
            Button_Home.Name = "Button_Home";
            Button_Home.Size = new Size(130, 33);
            Button_Home.TabIndex = 22;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 433);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_Doc);
            Controls.Add(TextBox_KQ);
            Controls.Add(TextBox_So);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai03";
            Text = "Bài 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox_KQ;
        private TextBox TextBox_So;
        private Label label2;
        private Label label1;
        private Button Button_Xoa;
        private Button Button_Doc;
        private Button Button_Next;
        private Button Button_Home;
    }
}