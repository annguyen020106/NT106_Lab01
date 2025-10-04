namespace Lab01
{
    partial class Lab01_Bai02
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
            TextBox_So3 = new TextBox();
            TextBox_So2 = new TextBox();
            TextBox_So1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Button_Tim = new Button();
            Button_Xoa = new Button();
            TextBox_Min = new TextBox();
            TextBox_Max = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.BackColor = Color.CornflowerBlue;
            Button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Next.ForeColor = Color.Navy;
            Button_Next.Location = new Point(568, 358);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 33);
            Button_Next.TabIndex = 15;
            Button_Next.Text = "Sang bài tiếp theo";
            Button_Next.UseVisualStyleBackColor = false;
            Button_Next.Click += Button_Next_Click;
            // 
            // Button_Home
            // 
            Button_Home.BackColor = Color.CornflowerBlue;
            Button_Home.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Home.ForeColor = Color.Navy;
            Button_Home.Location = new Point(12, 358);
            Button_Home.Name = "Button_Home";
            Button_Home.Size = new Size(130, 33);
            Button_Home.TabIndex = 14;
            Button_Home.Text = "Về trang chủ";
            Button_Home.UseVisualStyleBackColor = false;
            Button_Home.Click += Button_Home_Click;
            // 
            // TextBox_So3
            // 
            TextBox_So3.Location = new Point(599, 41);
            TextBox_So3.Name = "TextBox_So3";
            TextBox_So3.Size = new Size(78, 27);
            TextBox_So3.TabIndex = 13;
            // 
            // TextBox_So2
            // 
            TextBox_So2.Location = new Point(382, 41);
            TextBox_So2.Name = "TextBox_So2";
            TextBox_So2.Size = new Size(78, 27);
            TextBox_So2.TabIndex = 12;
            // 
            // TextBox_So1
            // 
            TextBox_So1.Location = new Point(158, 41);
            TextBox_So1.Name = "TextBox_So1";
            TextBox_So1.Size = new Size(78, 27);
            TextBox_So1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(502, 50);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 10;
            label3.Text = "Số Thứ Ba";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(278, 50);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 9;
            label2.Text = "Số Thứ Hai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 8;
            label1.Text = "Số Thứ Nhất";
            // 
            // Button_Tim
            // 
            Button_Tim.BackColor = SystemColors.GradientInactiveCaption;
            Button_Tim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Tim.ForeColor = Color.Navy;
            Button_Tim.Location = new Point(201, 146);
            Button_Tim.Name = "Button_Tim";
            Button_Tim.Size = new Size(94, 29);
            Button_Tim.TabIndex = 16;
            Button_Tim.Text = "Tìm";
            Button_Tim.UseVisualStyleBackColor = false;
            Button_Tim.Click += Button_Tim_Click;
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(398, 146);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 29);
            Button_Xoa.TabIndex = 17;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // TextBox_Min
            // 
            TextBox_Min.Location = new Point(599, 232);
            TextBox_Min.Name = "TextBox_Min";
            TextBox_Min.Size = new Size(78, 27);
            TextBox_Min.TabIndex = 22;
            // 
            // TextBox_Max
            // 
            TextBox_Max.Location = new Point(158, 232);
            TextBox_Max.Name = "TextBox_Max";
            TextBox_Max.Size = new Size(78, 27);
            TextBox_Max.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(481, 241);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 20;
            label4.Text = "Số Nhỏ Nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(42, 241);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 19;
            label5.Text = "Số Lớn Nhất";
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 403);
            Controls.Add(TextBox_Min);
            Controls.Add(TextBox_Max);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(Button_Xoa);
            Controls.Add(Button_Tim);
            Controls.Add(Button_Next);
            Controls.Add(Button_Home);
            Controls.Add(TextBox_So3);
            Controls.Add(TextBox_So2);
            Controls.Add(TextBox_So1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai02";
            Text = "Bài 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private Button Button_Home;
        private TextBox TextBox_So3;
        private TextBox TextBox_So2;
        private TextBox TextBox_So1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Button_Tim;
        private Button Button_Xoa;
        private TextBox TextBox_Min;
        private TextBox TextBox_Max;
        private Label label4;
        private Label label5;
    }
}