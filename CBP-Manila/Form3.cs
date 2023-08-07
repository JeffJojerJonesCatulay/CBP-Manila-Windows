using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBP_Manila
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void searchAndRetrieveData_BusinessName(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessNameVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_BusinessDescription(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessDescriptionVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Address(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessAddressVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Hours(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessHourVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Contact(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                   businessContactVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Website(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessWebsiteVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Facebook(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessFacebookVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Instagram(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessInstagramVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchAndRetrieveData_Requirement(string search)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    businessRequirementsVal.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLOSING
        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string searchThis = searchValue.search;

            string retrieveData_name = "SELECT BusinessName FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_BusinessName(retrieveData_name);

            string retrieveData_des = "SELECT BusinessDescription FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_BusinessDescription(retrieveData_des);

            string retrieveData_add = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Address(retrieveData_add);

            string retrieveData_hour = "SELECT BusinessHours FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Hours(retrieveData_hour);

            string retrieveData_contact = "SELECT ContactNumbers FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Contact(retrieveData_contact);

            string retrieveData_website = "SELECT Website FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Website(retrieveData_website);

            string retrieveData_facebook = "SELECT Facebook FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Facebook(retrieveData_facebook);

            string retrieveData_insta = "SELECT Instagram FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Instagram(retrieveData_insta);

            string retrieveData_req = "SELECT Requirement FROM BusinessData WHERE BusinessName='"+searchThis+"'";
            searchAndRetrieveData_Requirement(retrieveData_req);

            businessDescriptionVal.MaximumSize = new Size(700, 0);
            businessDescriptionVal.AutoSize = true;

            businessAddressVal.MaximumSize = new Size(700, 0);
            businessAddressVal.AutoSize = true;

            businessWebsiteVal.MaximumSize = new Size(700, 0);
            businessWebsiteVal.AutoSize = true;

            businessFacebookVal.MaximumSize = new Size(700, 0);
            businessFacebookVal.AutoSize = true;

            businessInstagramVal.MaximumSize = new Size(700, 0);
            businessInstagramVal.AutoSize = true;

            businessRequirementsVal.MaximumSize = new Size(700, 0);
            businessRequirementsVal.AutoSize = true;

        }

        private void businessWebsiteVal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (businessWebsiteVal.Text == "Unavailable")
            {
                MessageBox.Show("The Business Doesn't have a Website", "Good Day!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String url = businessWebsiteVal.Text;
                var si = new ProcessStartInfo(url);
                Process.Start(si);
                businessWebsiteVal.LinkVisited = true;
            }
        }

        private void businessFacebookVal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (businessFacebookVal.Text == "Unavailable")
            {
                MessageBox.Show("The Business Doesn't have a Facebook", "Good Day!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String url = businessFacebookVal.Text;
                var si = new ProcessStartInfo(url);
                Process.Start(si);
                businessWebsiteVal.LinkVisited = true;
            }
        }

        private void businessInstagramVal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (businessInstagramVal.Text == "Unavailable")
            {
                MessageBox.Show("The Business Doesn't have a Instagram", "Good Day!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String url = businessInstagramVal.Text;
                var si = new ProcessStartInfo(url);
                Process.Start(si);
                businessWebsiteVal.LinkVisited = true;
            }
        }

        private void businessDescriptionVal_Click(object sender, EventArgs e)
        {

        }
    }
}
