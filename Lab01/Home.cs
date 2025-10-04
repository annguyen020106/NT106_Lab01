namespace Lab01
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
        }
        //Nhấn Bài 1
        private void Button_B1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 BT = new Lab01_Bai01(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 2
        private void Button_B2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 BT = new Lab01_Bai02(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 3
        private void Button_B3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 BT = new Lab01_Bai03(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 3.1
        private void Button_B31_Click(object sender, EventArgs e)
        {
            Lab01_Bai031 BT = new Lab01_Bai031(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 4
        private void Button_B4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 BT = new Lab01_Bai04(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 5
        private void Button_B5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 BT = new Lab01_Bai05(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 6
        private void Button_B6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 BT = new Lab01_Bai06(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 7
        private void Button_B7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 BT = new Lab01_Bai07(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 8
        private void Button_B8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 BT = new Lab01_Bai08(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
    }
}
