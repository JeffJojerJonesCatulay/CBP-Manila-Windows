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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet.log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.logInDataSet.log);
            // TODO: This line of code loads data into the 'logInDataSet.log' table. You can move, or remove it, as needed.

            suffixName.Visible = false;
            suffixTXT.Visible = false;

            password.PasswordChar = '*';
            confirmPassword.PasswordChar = '*';

        }

        private void suffixConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (suffixConfirm.Checked == true)
            {
                suffixName.Visible = true;
                suffixTXT.Visible = true;
            } else
            {
                suffixName.Visible = false;
                suffixTXT.Visible = false;
            }
        }

        private void sign_upBTN_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            if ((lastName.Text == "") || (firstName.Text == "") || (middleName.Text == "") || (address.Text == "") || (contact.Text == "")
                || (age.Text == "") || (gender.SelectedIndex == -1) || (username.Text == "") || (password.Text == "") || (confirmPassword.Text == ""))
            {
                MessageBox.Show("Please Fill up All the Information", "Something is Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (password.Text == confirmPassword.Text)
                {
                    //Database Adding
                    try
                    {
                        con.Open();
                        cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "select * from log where Username= '" + username.Text +"' ";
                        OleDbDataReader reader = cmd.ExecuteReader();
                        int count = 0;

                        while (reader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Username is Already Taken", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Username is Already Taken", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            cmd = new OleDbCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "insert into log ([Surname], [Fistname], [Middle], [Suffix], [Address], [Contact], [Age], [Gender], [Username], [Password]) values ('" + lastName.Text + "','" + firstName.Text + "','" + middleName.Text + "','" + suffixName.Text + "','" + address.Text + "','" + contact.Text + "', '" + age.Text + "' , '" + gender.SelectedItem + "','" + username.Text + "','" + password.Text + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Success!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult result = MessageBox.Show("Do you like to proceed to Log In now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            lastName.Text = "";
                            firstName.Text = "";
                            middleName.Text = "";
                            suffixName.Text = "";
                            address.Text = "";
                            contact.Text = "";
                            age.Text = "";
                            gender.SelectedIndex = -1;
                            username.Text = "";
                            password.Text = "";
                            confirmPassword.Text = "";

                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Form5 f5 = new Form5();
                                this.Hide();
                                f5.ShowDialog();
                                this.Close();
                            }
                        }         
                    }
                    catch (Exception except)
                    {
                        MessageBox.Show("Error " + except);
                    }
                    //--------------
                }
                else
                {
                    MessageBox.Show("Password Don't Match", "Something is Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }       
        }

        private void logIn_MouseHover(object sender, EventArgs e)
        {
            logIn.ForeColor = Color.Orange;
        }

        private void logIn_MouseLeave(object sender, EventArgs e)
        {
            logIn.ForeColor = Color.Black;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                firstName.Focus();
            }
        }

        private void firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                middleName.Focus();
            }
        }

        private void middleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                address.Focus();
            }
        }

        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contact.Focus();
            }
        }

        private void contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                age.Focus();
            }
        }

        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmPassword.Focus();
            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
