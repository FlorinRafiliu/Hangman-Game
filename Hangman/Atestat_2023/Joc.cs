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
    public partial class Joc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Atestat_DB.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();
        public string Username;

        public Joc()
        {
            InitializeComponent();
        }

        void updateDataGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Username, Punctaj, Data From Scores Order by Punctaj Desc", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button_joc_nou_Click(object sender, EventArgs e)
        {
            Spanzuratoare spanzuratoare = new Spanzuratoare();
            this.Hide();
            spanzuratoare.Username = Username;
            spanzuratoare.ShowDialog();
            this.Show();

            updateDataGridView();
        }

        private void Joc_Load(object sender, EventArgs e)
        {
            con.Open();

            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");

            label_username.Text = label_username.Text + " " + Username + "!";
            updateDataGridView();
        }

        private void Joc_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
