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
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Atestat_DB.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");
            con.Open();

            //cmd = new SqlCommand("Truncate Table Words", con);
           // cmd.ExecuteNonQuery();
           // cmd = new SqlCommand("Truncate Table Users", con);
           // cmd.ExecuteNonQuery();
           // cmd = new SqlCommand("Truncate Table Scores", con);
           // cmd.ExecuteNonQuery();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_cuvant.Text.Length > 14)
            {
                textBox_cuvant.Text = string.Empty;
                MessageBox.Show("Cuvânt prea lung. Maxim 14 caractere.", "Eroare adăugare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            textBox_cuvant.Text = textBox_cuvant.Text.ToLower();
            string searchString = "Select Count(*) From Words Where Cuvant='" + textBox_cuvant.Text + "'";
            cmd = new SqlCommand(searchString, con);
            int exist = Int32.Parse(cmd.ExecuteScalar().ToString());

            if(exist == 0)
            {
                string insertString = "Insert Into Words Values ('" + textBox_cuvant.Text + "')";
                cmd = new SqlCommand(insertString, con);
                cmd.ExecuteNonQuery();

                textBox_cuvant.Text = string.Empty;
                MessageBox.Show("Cuvânt introdus cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                textBox_cuvant.Text = string.Empty;
                MessageBox.Show("Acest cuvânt există deja în baza de date.", "Eroare adăugare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ;
            }
        }
    }
}
