using System;
using System.Threading;

namespace FormAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox3.Enabled = false;
            DateTime currentTime = DateTime.Now;
            label4.Text = currentTime.ToString("HH:mm:ss");
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);

                double sum = number1 + number2;

                textBox3.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text += ex.Message;
                textBox3.BackColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}