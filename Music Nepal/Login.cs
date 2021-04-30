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

namespace Music_Nepal
{
    public partial class Login : Form
    {
        private string connetionString;
        private string sql;
        private SqlConnection connection;
        private SqlCommand command;

        public Login()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CTRLSOFT-BJMIA6\\SQLEXPRESS;Initial Catalog=MusicNepal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
  FROM Register where Username = '" + txtusername.Text + "'and UserPassword = '" + txtpassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            
            {
                this.Hide();
                main main = new main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void btncheckconnection_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            connetionString = "Data Source=CTRLSOFT-BJMIA6\\SQLEXPRESS;Initial Catalog=MusicNepal;Integrated Security=True";
            sql = "Select * from Artists";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();

                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                MessageBox.Show("connection successful ! ");
                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }
        bool ValidateData()
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("please enter userID");
                txtusername.Focus();
                return true;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("please enter PASSWORD");
                txtusername.Focus();
                return true;
            }
            return false;
        }
    }
}
