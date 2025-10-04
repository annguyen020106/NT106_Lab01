namespace Lab01
{
    partial class Lab01_Bai01
    {
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBox_So1 = new TextBox();
            TextBox_So2 = new TextBox();
            TextBox_KQ = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Button_Xoa = new Button();
            Button_KQ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(186, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 35);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(202, 125);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(229, 211);
            label3.Name = "label3";
            label3.Size = new Size(105, 35);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // TextBox_So1
            // 
            TextBox_So1.Location = new Point(368, 41);
            TextBox_So1.Name = "TextBox_So1";
            TextBox_So1.Size = new Size(186, 27);
            TextBox_So1.TabIndex = 3;
            // 
            // TextBox_So2
            // 
            TextBox_So2.Location = new Point(368, 127);
            TextBox_So2.Name = "TextBox_So2";
            TextBox_So2.Size = new Size(186, 27);
            TextBox_So2.TabIndex = 4;
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(368, 213);
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(186, 27);
            TextBox_KQ.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(15, 390);
            button1.Name = "button1";
            button1.Size = new Size(130, 33);
            button1.TabIndex = 6;
            button1.Text = "Về trang chủ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Home_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(589, 390);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 7;
            button2.Text = "Sang bài tiếp theo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button_Next_Click;
            // 
            // Button_Xoa
            // 
            Button_Xoa.BackColor = SystemColors.GradientInactiveCaption;
            Button_Xoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Xoa.ForeColor = Color.Navy;
            Button_Xoa.Location = new Point(186, 308);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 29);
            Button_Xoa.TabIndex = 22;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            Button_Xoa.Click += Button_Xoa_Click;
            // 
            // Button_KQ
            // 
            Button_KQ.BackColor = SystemColors.GradientInactiveCaption;
            Button_KQ.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_KQ.ForeColor = Color.Navy;
            Button_KQ.Location = new Point(460, 308);
            Button_KQ.Name = "Button_KQ";
            Button_KQ.Size = new Size(94, 29);
            Button_KQ.TabIndex = 23;
            Button_KQ.Text = "Kết quả";
            Button_KQ.UseVisualStyleBackColor = false;
            Button_KQ.Click += Button_KQ_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 446);
            Controls.Add(Button_KQ);
            Controls.Add(Button_Xoa);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(TextBox_KQ);
            Controls.Add(label3);
            Controls.Add(TextBox_So2);
            Controls.Add(TextBox_So1);
            Name = "Lab01_Bai01";
            Text = "Bài 01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBox_So1;
        private TextBox TextBox_So2;
        private TextBox TextBox_KQ;
        private Button button1;
        private Button button2;
        private Button Button_Xoa;
        private Button Button_KQ;
    }
}