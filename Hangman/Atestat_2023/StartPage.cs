using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_2023
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void button_inregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare inregistrare = new Inregistrare();

            this.Hide();
            inregistrare.ShowDialog();
            this.Show();
        }
    }
}
