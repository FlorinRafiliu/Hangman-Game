using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atestat_2023
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Atestat_DB.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_conectare_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text == "admin" && textBox_password.Text == "admin123")
            {
                Admin admin = new Admin();

                this.Hide();
                admin.ShowDialog();
                this.Show();

                textBox_username.Text = string.Empty;
                textBox_password.Text = string.Empty;
                return;
            }

            string checkString = "Select Count(*) From Users Where Username='" + textBox_username.Text + "' And Password= '" + textBox_password.Text + "'";
            cmd = new SqlCommand(checkString, con);
            int exist = Int32.Parse(cmd.ExecuteScalar().ToString());

            if(exist != 0)
            {
                Joc joc = new Joc();

                joc.Username = textBox_username.Text;

                textBox_username.Text = string.Empty;
                textBox_password.Text = string.Empty;

                this.Hide();
                joc.ShowDialog();
                this.Show();
            } 
            else
            {
                textBox_password.Text = string.Empty;
                textBox_username.Text = string.Empty;
                MessageBox.Show("Numele de utilizator și/sau parola sunt invalide!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.Open();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
