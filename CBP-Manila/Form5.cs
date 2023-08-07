using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CBP_Manila
{

    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            username.Enabled = false;
            password.Enabled = false;

            password.PasswordChar = '*';

        }

        private void log_inBTN_MouseHover(object sender, EventArgs e)
        {
            log_inBTN.BackColor = Color.Green;
        }

        private void log_inBTN_MouseLeave(object sender, EventArgs e)
        {
            log_inBTN.BackColor = Color.Yellow;
        }

        private void sign_upBTN_MouseHover(object sender, EventArgs e)
        {
            sign_upBTN.BackColor = Color.Green;
        }

        private void sign_upBTN_MouseLeave(object sender, EventArgs e)
        {
            sign_upBTN.BackColor = Color.Yellow;
        }

        private void sign_upBTN_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Close();
        }

        private void log_inBTN_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from log where Username= '"+username.Text+"' and Password= '"+password.Text+"' ";
            OleDbDataReader reader = cmd.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                userLog.var = username.Text;
                //Open new form
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate Data make sure youonly have one account!", "Log In Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("If you dont have an account click Sign In!", "Log In Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void passwordTXT_Click(object sender, EventArgs e)
        {
            passwordTXT.Visible = false;
            password.Enabled = true;
            password.Focus();
        }

        private void usernameTXT_Click_1(object sender, EventArgs e)
        {
            usernameTXT.Visible = false;
            username.Enabled = true;
            username.Focus();
        }

        private void Form5_Click(object sender, EventArgs e)
        {
            if ((usernameTXT.Visible == false) && (passwordTXT.Visible == false) && (username.Text == "") && (password.Text == ""))
            {
                usernameTXT.Visible = true;
                passwordTXT.Visible = true;
                username.Enabled = false;
                password.Enabled = false;
            }
        }
    }
}
