namespace WinFormsAppExam
{
    public partial class Form1 : Form
    {
        string logFilePath = Path.Combine(Application.StartupPath, "log.txt");
        List<int> accessCodes = new List<int> { 1645, 1689, 8345, 9998, 1006, 1008 };

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(logFilePath))
            {
                // Tạo tệp log nếu nó không tồn tại.
                File.Create(logFilePath).Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text.Length > 0)
            {
                txtSecurityCode.Text = txtSecurityCode.Text.Substring(0, txtSecurityCode.Text.Length - 1);
            }

        }

        private void txtSecurityCode_TextChanged(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text.Length == 4)
            {
                int enteredCode;
                if (int.TryParse(txtSecurityCode.Text, out enteredCode))
                {
                    if (accessCodes.Contains(enteredCode))
                    {
                        // Đăng nhập thành công.
                        listBoxLog.Items.Add($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} Tên nhóm đăng nhập");
                    }
                    else
                    {
                        // Đăng nhập thất bại.
                        listBoxLog.Items.Add($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} Restricted Access!");
                    }

                    // Xóa nội dung txtSecurityCode.Text sau khi kiểm tra.
                    txtSecurityCode.Text = "";
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu mã không hợp lệ.
                    MessageBox.Show("Mã không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string logEntry = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} {(accessCodes.Contains(enteredCode) ? "Access granted" : "Access denied")}";
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
        }


        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // Thêm số tương ứng vào txtSecurityCode.
                txtSecurityCode.Text += e.KeyChar;
                // Ngăn việc ký tự được nhập vào TextBox.
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSecurityCode.KeyPress += txtSecurityCode_KeyPress;
            txtSecurityCode.Focus();

        }

        private void txtSecurityCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                // Kiểm tra xem phím được nhấn là một phím số.
                // Thêm số tương ứng vào txtSecurityCode.
                txtSecurityCode.Text += (char)e.KeyValue;
            }
            else if (e.KeyCode == Keys.Back && txtSecurityCode.Text.Length > 0)
            {
                // Xử lý phím Backspace để xóa ký tự cuối cùng nếu có.
                txtSecurityCode.Text = txtSecurityCode.Text.Substring(0, txtSecurityCode.Text.Length - 1);
            }

            // Ngăn việc ký tự được nhập vào TextBox.
            e.SuppressKeyPress = true;
        }
    }
}