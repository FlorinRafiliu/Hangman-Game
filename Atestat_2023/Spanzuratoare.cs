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
    public partial class Spanzuratoare : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Atestat_DB.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();

        string Word;
        int stadiu = 6, punctaj = 100, n = 0;
        public string Username;

        void Finish()
        {
            if (punctaj == 0)
            {
                MessageBox.Show("Ai pierdut!", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            else
            {
                MessageBox.Show("Felictări! Ai câștigat cu " + punctaj.ToString() + " puncte.", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

            string insertString = "Insert Into Scores Values ('" + Username + "', " + punctaj + ", '" + DateTime.Now + "')";
            cmd = new SqlCommand(insertString, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }
        public Spanzuratoare()
        {
            InitializeComponent();
        }

        bool Find(string letter)
        {
            if (Word.Contains(letter))
                return true;
            return false;
        }

        void Apare(string letter)
        {
            for(int i = 0; i < Word.Length; i++)
            {
                if(Word[i].ToString() == letter)
                {
                    if (i + 1 == 1)
                    {
                        letter1.Visible = true;
                        letter1.Text = letter.ToUpper();
                    }
                    if (i + 1 == 2)
                    {
                        letter2.Visible = true;
                        letter2.Text = letter.ToUpper();
                    }
                    if (i + 1 == 3)
                    {
                        letter3.Visible = true;
                        letter3.Text = letter.ToUpper();
                    }
                    if (i + 1 == 4)
                    {
                        letter4.Visible = true;
                        letter4.Text = letter.ToUpper();
                    }
                    if (i + 1 == 5)
                    {
                        letter5.Visible = true;
                        letter5.Text = letter.ToUpper();
                    }
                    if (i + 1 == 6)
                    {
                        letter6.Visible = true;
                        letter6.Text = letter.ToUpper();
                    }
                    if (i + 1 == 7)
                    {
                        letter7.Visible = true;
                        letter7.Text = letter.ToUpper();
                    }
                    if (i + 1 == 8)
                    {
                        letter8.Visible = true;
                        letter8.Text = letter.ToUpper();
                    }
                    if (i + 1 == 9)
                    {
                        letter9.Visible = true;
                        letter9.Text = letter.ToUpper();
                    }
                    if (i + 1 == 10)
                    {
                        letter10.Visible = true;
                        letter10.Text = letter.ToUpper();
                    }
                    if (i + 1 == 11)
                    {
                        letter11.Visible = true;
                        letter11.Text = letter.ToUpper();
                    }
                    if (i + 1 == 12)
                    {
                        letter12.Visible = true;
                        letter12.Text = letter.ToUpper();
                    }
                    if (i + 1 == 13)
                    {
                        letter13.Visible = true;
                        letter13.Text = letter.ToUpper();
                    }
                    if (i + 1 == 14)
                    {
                        letter14.Visible = true;
                        letter14.Text = letter.ToUpper();
                    }
                    n++;
                    if (n == Word.Length)
                        Finish();
                }
            }
        }

        void UP()
        {
            stadiu++;
            if (stadiu > 6)
                stadiu = 6;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\" + stadiu.ToString() + @".jpg");
        }

        void DOWN()
        {
            stadiu--;
            if (stadiu == 0)
            {
                punctaj = 0;
                Finish();
            }
            else
            {
                punctaj -= 4;
                label_punctaj.Text = "Punctaj: " + punctaj.ToString();
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\" + stadiu.ToString() + @".jpg");
            }
        }

        private void v_Load(object sender, EventArgs e)
        {
            con.Open();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\back3.jpg");


            string extractString = "Select Cuvant From Words";

            SqlDataAdapter sda = new SqlDataAdapter(extractString, con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            Random random = new Random();
            int idWord = random.Next(0, dataTable.Rows.Count);

            Word = dataTable.Rows[idWord][0].ToString();

            label_word.Text = Word;

            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\" + (6).ToString() + @".jpg");

            label1.Text = string.Empty;
            for (int i = 0; i < Word.Length; i++)
                label1.Text = label1.Text + "_ ";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            string letter = buttonA.Text.ToLower();
            buttonA.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            string letter = buttonB.Text.ToLower();
            buttonB.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            string letter = buttonC.Text.ToLower();
            buttonC.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            string letter = buttonD.Text.ToLower();
            buttonD.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            string letter = buttonE.Text.ToLower();
            buttonE.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            string letter = buttonF.Text.ToLower();
            buttonF.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            string letter = buttonG.Text.ToLower();
            buttonG.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            string letter = buttonH.Text.ToLower();
            buttonH.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            string letter = buttonI.Text.ToLower();
            buttonI.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            string letter = buttonJ.Text.ToLower();
            buttonJ.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            string letter = buttonK.Text.ToLower();
            buttonK.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            string letter = buttonL.Text.ToLower();
            buttonL.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            string letter = buttonM.Text.ToLower();
            buttonM.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            string letter = buttonN.Text.ToLower();
            buttonN.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            string letter = buttonO.Text.ToLower();
            buttonO.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            string letter = buttonP.Text.ToLower();
            buttonP.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            string letter = buttonQ.Text.ToLower();
            buttonQ.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            string letter = buttonR.Text.ToLower();
            buttonR.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            string letter = buttonS.Text.ToLower();
            buttonS.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            string letter = buttonT.Text.ToLower();
            buttonT.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            string letter = buttonU.Text.ToLower();
            buttonU.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            string letter = buttonV.Text.ToLower();
            buttonV.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            string letter = buttonW.Text.ToLower();
            buttonW.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            string letter = buttonX.Text.ToLower();
            buttonX.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            string letter = buttonY.Text.ToLower();
            buttonY.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            string letter = buttonZ.Text.ToLower();
            buttonZ.Visible = false;
            if (Find(letter))
            {
                UP();
                Apare(letter);
            }
            else
                DOWN();
        }

        private void v_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
