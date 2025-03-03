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
    public partial class Inregistrare : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Atestat_DB.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();

        public Inregistrare()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_inregistrare_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text.Length <= 2)
            {
                MessageBox.Show("Username must contains at least 3 letters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_username.Text = string.Empty;
                textBox_password1.Text = string.Empty;
                textBox_password2.Text = string.Empty;
                return;
            }
            if(textBox_password1.Text != textBox_password2.Text)
            {
                MessageBox.Show("The passwords needs to be the same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_username.Text = string.Empty;
                textBox_password1.Text = string.Empty;
                textBox_password2.Text = string.Empty;
                return;
            }

            string checkString = "Select Count(*) From Users Where Username='" + textBox_username.Text + "'";
            cmd = new SqlCommand(checkString, con);
            int exist = Int32.Parse(cmd.ExecuteScalar().ToString());

            if (exist != 0)
            {
                MessageBox.Show("Already used Username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_username.Text = string.Empty;
                textBox_password1.Text = string.Empty;
                textBox_password2.Text = string.Empty;
                return ;
            }

            string insertString = "Insert Into Users Values ('" + textBox_username.Text + "', '" + textBox_password1.Text + "')";
            cmd = new SqlCommand(insertString, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("The account was created successfully!");
            this.Close();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            con.Open();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");

        }

        private void Inregistrare_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
