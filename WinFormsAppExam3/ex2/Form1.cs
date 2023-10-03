namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b))
            {
                if (btnUCLN.Checked)
                {
                    int ucln = UCLN(a, b);
                    txtKetqua.Text = ucln.ToString();
                }
                else if (btnBCNN.Checked)
                {
                    int bcnn = BCNN(a, b);
                    txtKetqua.Text = bcnn.ToString();
                }
            }
            else
            {
                txtKetqua.Text = "Vui lòng nhập số nguyên hợp lệ cho a và b.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
            btnBCNN.Checked = false;
            btnUCLN.Checked = false;    
        }
        // Hàm tính UCLN
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tính BCNN
        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}