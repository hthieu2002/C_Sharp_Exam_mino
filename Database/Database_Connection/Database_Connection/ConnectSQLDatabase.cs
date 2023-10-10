using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection
{
    public partial class ConnectSQLDatabase : Form
    {
        SqlConnection conn = null;
        string connectionString = "Server=TRUNG_HIEU\\SQLEXPRESS;Database=STUDENT_MANAGEMENT;User Id=sa;Password=261102;";

        public ConnectSQLDatabase()
        {
            InitializeComponent();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State==ConnectionState.Open) 
            {
                conn.Close();
                MessageBox.Show("Successful Disconnetion!!!");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("Successful connect");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect to server \n " + ex.Message);
            }
        }
    }
}
