namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKetqua.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtSoN.Text);
                int m = int.Parse(txtSoM.Text);
                int Tong = n + m;
                txtKetqua.Text = Tong.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtSoN.Text);
                int m = int.Parse(txtSoM.Text);
                int Tong = n - m;
                txtKetqua.Text = Tong.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtSoN.Text);
                int m = int.Parse(txtSoM.Text);
                int Tong = n * m;
                txtKetqua.Text = Tong.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            {
                int n = int.Parse(txtSoN.Text);
                int m = int.Parse(txtSoM.Text);
                int Tong = n / m;
                txtKetqua.Text = Tong.ToString();
            }
        }
    }
}