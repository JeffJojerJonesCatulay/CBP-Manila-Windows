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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        public void searchFilter(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------
                seearchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                seearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                seearchBox.AutoCompleteCustomSource = Collection;
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addressOfTheSelectedBusiness(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    previewAddress.Text = dr.GetString(0);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void searchFilter_Hardware(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------
                
                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                hardwareDD.Items.Clear();
                foreach (var item in Collection)
                {
                    hardwareDD.Items.Add(item);
                }
             
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Mall(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                mallsDD.Items.Clear();
                foreach (var item in Collection)
                {
                    mallsDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Pet(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                { 
                    Collection.Add(dr.GetString(0));
                }
                
                petshopsDD.Items.Clear();
                foreach (var item in Collection)
                {
                    petshopsDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Salon(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                salonsDD.Items.Clear();
                foreach (var item in Collection)
                {
                    salonsDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Store(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                storesDD.Items.Clear();
                foreach (var item in Collection)
                {
                    storesDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Food(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                foodsDD.Items.Clear();
                foreach (var item in Collection)
                {
                    foodsDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Commercial(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                commercialDD.Items.Clear();
                foreach (var item in Collection)
                {
                    commercialDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Furniture(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                furnituresDD.Items.Clear();
                foreach (var item in Collection)
                {
                    furnituresDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchFilter_Water(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;
                //-------------

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                waterDD.Items.Clear();
                foreach (var item in Collection)
                {
                    waterDD.Items.Add(item);
                }

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DropDown
        int dropdownChoice = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cBPBusinessDatabaseDataSet.BusinessData' table. You can move, or remove it, as needed.
            this.businessDataTableAdapter.Fill(this.cBPBusinessDatabaseDataSet.BusinessData);
            fullView.Visible = false;
            noFilter.Checked = true;
            closeDropdown();
            hardwareDD.SelectedIndex = 0;
            mallsDD.SelectedIndex = 0;
            petshopsDD.SelectedIndex = 0;
            salonsDD.SelectedIndex = 0;
            storesDD.SelectedIndex = 0;
            foodsDD.SelectedIndex = 0;
            commercialDD.SelectedIndex = 0;
            furnituresDD.SelectedIndex = 0;
            waterDD.SelectedIndex = 0;
            previewName.Text = "";
            previewAddress.Text = "";

            currentUser.Text = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            currentTime.Text = currentTimeDate;

            // Default Searchs
            String searchData = "SELECT BusinessName FROM BusinessData";
            searchFilter(searchData);

            String searchData_hardware = "SELECT BusinessName FROM BusinessData WHERE Category='Hardware'";
            searchFilter_Hardware(searchData_hardware);

            String searchData_mall = "SELECT BusinessName FROM BusinessData WHERE Category='Mall'";
            searchFilter_Mall(searchData_mall);

            String searchData_pet = "SELECT BusinessName FROM BusinessData WHERE Category='Pet Shop'";
            searchFilter_Pet(searchData_pet);

            String searchData_salon = "SELECT BusinessName FROM BusinessData WHERE Category='Salon'";
            searchFilter_Salon(searchData_salon);

            String searchData_store = "SELECT BusinessName FROM BusinessData WHERE Category='Store'";
            searchFilter_Store(searchData_store);

            String searchData_food = "SELECT BusinessName FROM BusinessData WHERE Category='Food'";
            searchFilter_Food(searchData_food);

            String searchData_commercial = "SELECT BusinessName FROM BusinessData WHERE Category='Commercial'";
            searchFilter_Commercial(searchData_commercial);

            String searchData_furniture = "SELECT BusinessName FROM BusinessData WHERE Category='Furniture'";
            searchFilter_Furniture(searchData_furniture);

            String searchData_water = "SELECT BusinessName FROM BusinessData WHERE Category='Water'";
            searchFilter_Water(searchData_water);
            // ------------

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            String searchValueUser = seearchBox.Text;
            this.ActiveControl = null;
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into logbook ([User], [BusinessName], [DateTimeAccessed]) values ('" + currentUser.Text + "', '" + searchValueUser + "', '" + currentTime.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                searchValue.search = searchValueUser;

                //New Form
                Form3 f3 = new Form3();
                f3.TopMost = true;
                f3.ShowDialog();
            }
            catch (Exception except)
            {
                MessageBox.Show("Error " + except);
            }
        }


        public void closeDropdown()
        {
            hardwareDD.Visible = false;
            mallsDD.Visible = false;
            petshopsDD.Visible = false;
            salonsDD.Visible = false;
            storesDD.Visible = false;
            foodsDD.Visible = false;
            commercialDD.Visible = false;
            furnituresDD.Visible = false;
            waterDD.Visible = false;
        }

        public void openCloseDropdown(int choice)
        {
            // 1 - Hardware
            // 2 - Mall
            // 3 - PetShop
            // 4 - Salon
            // 5 - Stores
            // 6 - Foods
            // 7 - Commercial
            // 8 - Furniture
            // 9 - WaterStations

            if (choice == 1)
            {
                if (hardwareDD.Visible == false)
                {
                    hardwareDD.Visible = true;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 2)
            {
                if (mallsDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = true;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 3)
            {
                if (petshopsDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = true;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 4)
            {
                if (salonsDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = true;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 5)
            {
                if (storesDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = true;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 6)
            {
                if (foodsDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = true;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 7)
            {
                if (commercialDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = true;
                    furnituresDD.Visible = false;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 8)
            {
                if (furnituresDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = true;
                    waterDD.Visible = false;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

            if (choice == 9)
            {
                if (waterDD.Visible == false)
                {
                    hardwareDD.Visible = false;
                    mallsDD.Visible = false;
                    petshopsDD.Visible = false;
                    salonsDD.Visible = false;
                    storesDD.Visible = false;
                    foodsDD.Visible = false;
                    commercialDD.Visible = false;
                    furnituresDD.Visible = false;
                    waterDD.Visible = true  ;
                    timer1.Stop();
                }
                else
                {
                    closeDropdown();
                    timer1.Stop();
                }
            }

        }

        public void clearPreview()
        {
            previewName.Text = "";
            previewAddress.Text = "";
        }

        //Close Form
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void hardwareBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.h1;
            dropdownChoice = 1;
            timer1.Start();      
        }

        private void mallsBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.m1;
            dropdownChoice = 2;
            timer1.Start();
        }

        private void petshopsBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.ps1;
            dropdownChoice = 3;
            timer1.Start();
        }

        private void salonsBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.s1;
            dropdownChoice = 4;
            timer1.Start();
        }

        private void storesBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.st1;
            dropdownChoice = 5;
            timer1.Start();
        }

        private void foodsBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.f1;
            dropdownChoice = 6;
            timer1.Start();
        }

        private void comercialBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.c1;
            dropdownChoice = 7;
            timer1.Start();
        }

        private void furnituresBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.f1;
            dropdownChoice = 8;
            timer1.Start();
        }

        private void waterBTN_Click(object sender, EventArgs e)
        {
            previewPic.BackgroundImage = CBP_Manila.Properties.Resources.ws1;
            dropdownChoice = 9;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            openCloseDropdown(dropdownChoice);
            timer1.Stop();
        }

        private void hardwareDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = hardwareDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void mallsDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = mallsDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void petshopsDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = petshopsDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void salonsDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = salonsDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void storesDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = storesDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);

        }

        private void foodsDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = foodsDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void commercialDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = commercialDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void furnituresDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = furnituresDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void waterDD_SelectedValueChanged(object sender, EventArgs e)
        {
            previewName.Text = waterDD.SelectedItem.ToString();
            String address_search = "SELECT BusinessAddress FROM BusinessData WHERE BusinessName='" + previewName.Text + "'";
            addressOfTheSelectedBusiness(address_search);
        }

        private void fullView_MouseHover(object sender, EventArgs e)
        {
            fullView.ForeColor = Color.Orange;
        }

        private void fullView_MouseLeave(object sender, EventArgs e)
        {
            fullView.ForeColor = Color.White;
        }

        private void homFORM_MouseHover(object sender, EventArgs e)
        {
            homFORM.ForeColor = Color.Black;
            homFORM.BackColor = Color.Yellow;
        }

        private void homFORM_MouseLeave(object sender, EventArgs e)
        {
            homFORM.ForeColor = Color.White;
            homFORM.BackColor = Color.Orange;
        }

        private void aboutFORM_MouseHover(object sender, EventArgs e)
        {
            aboutFORM.ForeColor = Color.Black;
            aboutFORM.BackColor = Color.Yellow;
        }

        private void aboutFORM_MouseLeave(object sender, EventArgs e)
        {
            aboutFORM.ForeColor = Color.White;
            aboutFORM.BackColor = Color.Orange;
        }

        private void fullView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into logbook ([User], [BusinessName], [DateTimeAccessed]) values ('" + currentUser.Text + "', '" + previewName.Text + "', '" + currentTime.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                searchValue.search = previewName.Text;
            }
            catch(Exception except)
            {
                MessageBox.Show("Error " + except);
            }
            
            //New Form
            Form3 f3 = new Form3();
            f3.TopMost = true;
            f3.ShowDialog();
        }

        private void homFORM_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void previewName_TextChanged(object sender, EventArgs e)
        {
            if (previewName.Text == "")
            {
                fullView.Visible = false;
            }
            else
            {
                fullView.Visible = true;
            }
        }

        private void aboutFORM_Click(object sender, EventArgs e)
        {
            // ABOUT
            Form4 f4 = new Form4();
            f4.TopMost = true;
            f4.ShowDialog();
        }

        private void binondo_CheckedChanged(object sender, EventArgs e)
        {   
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Binondo' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }


        private void ermita_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Ermita' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void intramuros_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Intramuros' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void sampaloc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sampaloc' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void paco_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Paco' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void pandacan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Pandacan' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void portArea_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Port Area' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void quiapo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Quiapo' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void malate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Malate' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void sanAndres_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Andres' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void sanMiguel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Miguel' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void sanNicholas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='San Nicolas' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void santaAna_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Ana' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void staCruz_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Sta Cruz' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void staMesa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Santa Mesa' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void tondo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo'";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Municipal='Tondo' AND Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void noFilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string search_Filter = "SELECT BusinessName FROM BusinessData";
                searchFilter(search_Filter);

                string municipal_category_filter_hardware = "SELECT BusinessName FROM BusinessData WHERE Category='Hardware'";
                searchFilter_Hardware(municipal_category_filter_hardware);

                string municipal_category_filter_mall = "SELECT BusinessName FROM BusinessData WHERE Category='Mall'";
                searchFilter_Mall(municipal_category_filter_mall);

                string municipal_category_filter_pet = "SELECT BusinessName FROM BusinessData WHERE Category='Pet Shop'";
                searchFilter_Pet(municipal_category_filter_pet);

                string municipal_category_filter_salon = "SELECT BusinessName FROM BusinessData WHERE Category='Salon'";
                searchFilter_Salon(municipal_category_filter_salon);

                string municipal_category_filter_store = "SELECT BusinessName FROM BusinessData WHERE Category='Store'";
                searchFilter_Store(municipal_category_filter_store);

                string municipal_category_filter_food = "SELECT BusinessName FROM BusinessData WHERE Category='Food'";
                searchFilter_Food(municipal_category_filter_food);

                string municipal_category_filter_commercial = "SELECT BusinessName FROM BusinessData WHERE Category='Commercial'";
                searchFilter_Commercial(municipal_category_filter_commercial);

                string municipal_category_filter_furniture = "SELECT BusinessName FROM BusinessData WHERE Category='Furniture'";
                searchFilter_Furniture(municipal_category_filter_furniture);

                string municipal_category_filter_water = "SELECT BusinessName FROM BusinessData WHERE Category='Water'";
                searchFilter_Water(municipal_category_filter_water);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
