using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CBP_Manila
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        bool isCollapsed;

        public void searchFilter(string search)
        {
            try
            {
                //TO AUTOFILL
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CBPBusinessDatabase.accdb");
                OleDbCommand cmd;
                OleDbDataReader dr;

                 
                //-------------

                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cmd = new OleDbCommand(search, cn);

                cn.Open();
                dr = cmd.ExecuteReader();

                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    Collection.Add(dr.GetString(0));
                }

                textBox1.AutoCompleteCustomSource = Collection;
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Is Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void playVideoAnimation()
        {
            try
            {
                // Video Animation
                //C:\Users\JeffCatulay\source\repos\CBP-Manila\CBP-Manila\Resources\IntroAnimation.mp4
                string path = Directory.GetCurrentDirectory() + "\\IntroAnimation.mp4";
                using (FileStream fs = File.Open(path, FileMode.Open)) { }
                axWindowsMediaPlayer1.URL = path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.settings.playCount = 1000;
                axWindowsMediaPlayer1.uiMode = "None";
                axWindowsMediaPlayer1.settings.mute = true;
            }catch (Exception except)
            {

            }                                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataSet.businessTable' table. You can move, or remove it, as needed.
            playVideoAnimation();
                   
            // Auto Scroll
            panel2.AutoScroll = false;
            panel3.AutoScroll = false;
            panel4.AutoScroll = false;
            panel5.AutoScroll = false;
            panel6.AutoScroll = false;
            panel7.AutoScroll = false;
            panel8.AutoScroll = false;
            panel9.AutoScroll = false;
            panel10.AutoScroll = false;

            currentUser.Text = userLog.var;

            String searchData = "SELECT BusinessName FROM BusinessData";
            searchFilter(searchData);

            hardware1.Font = new Font("Century Gothic", 14);
            hardware2.Font = new Font("Century Gothic", 14);
            hardware3.Font = new Font("Century Gothic", 14);
            hardware4.Font = new Font("Century Gothic", 14);
            hardware5.Font = new Font("Century Gothic", 14);
            hardware6.Font = new Font("Century Gothic", 14);
            hardware7.Font = new Font("Century Gothic", 14);
            hardware8.Font = new Font("Century Gothic", 14);

            mall1.Font = new Font("Century Gothic", 14);
            mall2.Font = new Font("Century Gothic", 14);
            mall3.Font = new Font("Century Gothic", 14);
            mall4.Font = new Font("Century Gothic", 14);
            mall5.Font = new Font("Century Gothic", 14);
            mall6.Font = new Font("Century Gothic", 14);
            mall7.Font = new Font("Century Gothic", 14);
            mall8.Font = new Font("Century Gothic", 14);

            petshop1.Font = new Font("Century Gothic", 14);
            petshop2.Font = new Font("Century Gothic", 14);
            petshop3.Font = new Font("Century Gothic", 14);
            petshop4.Font = new Font("Century Gothic", 14);
            petshop5.Font = new Font("Century Gothic", 14);
            petshop6.Font = new Font("Century Gothic", 14);
            petshop7.Font = new Font("Century Gothic", 14);
            petshop8.Font = new Font("Century Gothic", 12);

            salon1.Font = new Font("Century Gothic", 14);
            salon2.Font = new Font("Century Gothic", 14);
            salon3.Font = new Font("Century Gothic", 14);
            salon4.Font = new Font("Century Gothic", 14);
            salon5.Font = new Font("Century Gothic", 14);
            salon6.Font = new Font("Century Gothic", 14);
            salon7.Font = new Font("Century Gothic", 14);
            salon8.Font = new Font("Century Gothic", 14);

            stores1.Font = new Font("Century Gothic", 12);
            stores2.Font = new Font("Century Gothic", 14);
            stores3.Font = new Font("Century Gothic", 14);
            stores4.Font = new Font("Century Gothic", 14);
            stores5.Font = new Font("Century Gothic", 14);
            stores6.Font = new Font("Century Gothic", 14);
            stores7.Font = new Font("Century Gothic", 14);
            stores8.Font = new Font("Century Gothic", 14);

            foods1.Font = new Font("Century Gothic", 14);
            foods2.Font = new Font("Century Gothic", 14);
            foods3.Font = new Font("Century Gothic", 14);
            foods4.Font = new Font("Century Gothic", 14);
            foods5.Font = new Font("Century Gothic", 14);
            foods6.Font = new Font("Century Gothic", 14);
            foods7.Font = new Font("Century Gothic", 14);
            foods8.Font = new Font("Century Gothic", 14);

            commercial1.Font = new Font("Century Gothic", 14);
            commercial2.Font = new Font("Century Gothic", 14);
            commercial3.Font = new Font("Century Gothic", 14);
            commercial4.Font = new Font("Century Gothic", 14);
            commercial5.Font = new Font("Century Gothic", 14);
            commercial6.Font = new Font("Century Gothic", 14);
            commercial7.Font = new Font("Century Gothic", 14);
            commercial8.Font = new Font("Century Gothic", 14);

            furniture1.Font = new Font("Century Gothic", 12);
            furniture2.Font = new Font("Century Gothic", 14);
            furniture3.Font = new Font("Century Gothic", 14);
            furniture4.Font = new Font("Century Gothic", 14);
            furniture5.Font = new Font("Century Gothic", 14);
            furniture6.Font = new Font("Century Gothic", 12);
            furniture7.Font = new Font("Century Gothic", 14);
            furniture8.Font = new Font("Century Gothic", 14);

            water1.Font = new Font("Century Gothic", 14);
            water2.Font = new Font("Century Gothic", 14);
            water3.Font = new Font("Century Gothic", 14);
            water4.Font = new Font("Century Gothic", 14);
            water5.Font = new Font("Century Gothic", 14);
            water6.Font = new Font("Century Gothic", 14);
            water7.Font = new Font("Century Gothic", 14);
            water8.Font = new Font("Century Gothic", 14);

            hardware1.Text = "Rufino Hardware";
            hardware2.Text = "Rex Hardware ";
            hardware3.Text = "JBBC Hardware";
            hardware4.Text = "Hzkia Hardware";
            hardware5.Text = "Sta. Mesa Hardware";
            hardware6.Text = "New Paco Hardware";
            hardware7.Text = "Luzon Sales Co Inc";
            hardware8.Text = "Jpl Hardware";

            mall1.Text = "Xentro Mall";
            mall2.Text = "Tayuman Center Mall";
            mall3.Text = "Decal Mall";
            mall4.Text = "Divisoria Mall";
            mall5.Text = "University Mall";
            mall6.Text = "Robinsons Otis";
            mall7.Text = "SM City";
            mall8.Text = "Isetann";

            petshop1.Text = "Oro Cargo Movers";
            petshop2.Text = "Pet+plus";
            petshop3.Text = "Dogs and the City ";
            petshop4.Text = "Pet Central";
            petshop5.Text = "Pets & Vets";
            petshop6.Text = "Cats Collection";
            petshop7.Text = "Kimtins Pet Shop";
            petshop8.Text = "Happymeal Raw Dogfood";

            salon1.Text = "Salon De Manila";
            salon2.Text = "Bangs";
            salon3.Text = "Ystilo Salon";
            salon4.Text = "Princess Cut Salon";
            salon5.Text = "F Salon";
            salon6.Text = "Nailflix Spa";
            salon7.Text = "Davids Salon";
            salon8.Text = "Premium CUT";

            stores1.Text = "Wellcome Supermarket";
            stores2.Text = "GJRELX Pandacan";
            stores3.Text = "Hilton Mart Paco";
            stores4.Text = "Savemore SMDC";
            stores5.Text = "All Day Convenience";
            stores6.Text = "Jerome Store";
            stores7.Text = "Junoesque & Co.";
            stores8.Text = "Danny Store";

            foods1.Text = "McDonald Intramuros";
            foods2.Text = "Moonleaf Tea Shop";
            foods3.Text = "Jollibee Binondo";
            foods4.Text = "Popeyes Louisiana Kitchen";
            foods5.Text = "Tapsilogan Food ";
            foods6.Text = "Chowking Espana";
            foods7.Text = "Sabroso Comfort";
            foods8.Text = "Jose Fastfood";

            commercial1.Text = "UnionBank";
            commercial2.Text = "Shell Paco";
            commercial3.Text = "Watsons Isetann";
            commercial4.Text = "Land Bank";
            commercial5.Text = "Cebuana Lhuillier ";
            commercial6.Text = "Ersao";
            commercial7.Text = "Security Bank ";
            commercial8.Text = "Philippine National Bank";

            furniture1.Text = "Dispatching Office";
            furniture2.Text = "Decena Invention";
            furniture3.Text = "FB Furnitures";
            furniture4.Text = "Storage Cabinet";
            furniture5.Text = "Bonny Furniture";
            furniture6.Text = "Jeamm Commercial";
            furniture7.Text = "Mega Office";
            furniture8.Text = "Silahis Center";

            water1.Text = "Mv Water Station";
            water2.Text = "Venice Water";
            water3.Text = "Aqua 300 Water";
            water4.Text = "Agua De Magdala";
            water5.Text = "Natures Flow ";
            water6.Text = "Sebastian Water";
            water7.Text = "Qualibest Water";
            water8.Text = "Jaybeth Water";

        }

        // Dropdown Options -- start
        private void hardwareBTN_Click(object sender, EventArgs e)
        {
            timer1.Start();
            hardwareBTN.BackgroundImage = CBP_Manila.Properties.Resources._9;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel2.Height += 20;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    panel2.AutoScroll = true;
                }
            }
            else
            {
                panel2.Height -= 100;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    panel2.AutoScroll = false;
                }
            }
        }

        private void mallsBTN_Click(object sender, EventArgs e)
        {
            timer2.Start();
            mallsBTN.BackgroundImage = CBP_Manila.Properties.Resources._8;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel3.Height += 20;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                    panel3.AutoScroll = true;
                }
            }
            else
            {
                panel3.Height -= 100;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                    panel3.AutoScroll = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel4.Height += 20;
                if (panel4.Size == panel4.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                    panel4.AutoScroll = true;
                }
            }
            else
            {
                panel4.Height -= 100;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                    panel4.AutoScroll = false;
                }
            }
        }

        private void petshopBTN_Click(object sender, EventArgs e)
        {
            timer3.Start();
            petshopBTN.BackgroundImage = CBP_Manila.Properties.Resources._7;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel5.Height += 20;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                    panel5.AutoScroll = true;
                }
            }
            else
            {
                panel5.Height -= 100;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                    panel5.AutoScroll = false;
                }
            }
        }

        private void salonBTN_Click(object sender, EventArgs e)
        {
            timer4.Start();
            salonBTN.BackgroundImage = CBP_Manila.Properties.Resources._6;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel6.Height += 20;
                if (panel6.Size == panel6.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;
                    panel6.AutoScroll = true;
                }
            }
            else
            {
                panel6.Height -= 100;
                if (panel6.Size == panel6.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                    panel6.AutoScroll = false;
                }
            }
        }

        private void storeBTN_Click(object sender, EventArgs e)
        {
            timer5.Start();
            storeBTN.BackgroundImage = CBP_Manila.Properties.Resources._5;
        }

        private void foodsBTN_Click(object sender, EventArgs e)
        {
            timer6.Start();
            foodsBTN.BackgroundImage = CBP_Manila.Properties.Resources._4;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel7.Height += 20;
                if (panel7.Size == panel7.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsed = false;
                    panel7.AutoScroll = true;
                }
            }
            else
            {
                panel7.Height -= 100;
                if (panel7.Size == panel7.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsed = true;
                    panel7.AutoScroll = false;
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel8.Height += 20;
                if (panel8.Size == panel8.MaximumSize)
                {
                    timer7.Stop();
                    isCollapsed = false;
                    panel8.AutoScroll = true;
                }
            }
            else
            {
                panel8.Height -= 100;
                if (panel8.Size == panel8.MinimumSize)
                {
                    timer7.Stop();
                    isCollapsed = true;
                    panel8.AutoScroll = false;
                }
            }
        }

        private void commercialBTN_Click(object sender, EventArgs e)
        {
            timer7.Start();
            commercialBTN.BackgroundImage = CBP_Manila.Properties.Resources._3;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel9.Height += 20;
                if (panel9.Size == panel9.MaximumSize)
                {
                    timer8.Stop();
                    isCollapsed = false;
                    panel9.AutoScroll = true;
                }
            }
            else
            {
                panel9.Height -= 100;
                if (panel9.Size == panel9.MinimumSize)
                {
                    timer8.Stop();
                    isCollapsed = true;
                    panel9.AutoScroll = false;
                }
            }
        }

        private void furnituresBTN_Click(object sender, EventArgs e)
        {
            timer8.Start();
            furnituresBTN.BackgroundImage = CBP_Manila.Properties.Resources._2;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel10.Height += 20;
                if (panel10.Size == panel10.MaximumSize)
                {
                    timer9.Stop();
                    isCollapsed= false;
                    panel10.AutoScroll = true;
                }
            }
            else
            {
                panel10.Height -= 100;
                if (panel10.Size == panel10.MinimumSize)
                {
                    timer9.Stop();
                    isCollapsed = true;
                    panel10.AutoScroll = false;
                }
            }
        }
        
        private void waterstationsBTN_Click(object sender, EventArgs e)
        {
            timer9.Start();
            waterstationsBTN.BackgroundImage = CBP_Manila.Properties.Resources._1;
        }

        // Dropdown Options -- END

        // Business Form/Closing form -- start

        private void viewAllForm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void businessForm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Business Form -- end

        // Change button Color -- start

        private void button1_MouseHover(object sender, EventArgs e)
        {
            hardware1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            hardware1.BackColor = Color.Orange;
        }
    
        private void hardware2_MouseHover(object sender, EventArgs e)
        {
            hardware2.BackColor = Color.Green;
        }

        private void hardware2_MouseLeave(object sender, EventArgs e)
        {
            hardware2.BackColor = Color.Orange;
        }

        private void hardware3_MouseHover(object sender, EventArgs e)
        {
            hardware3.BackColor = Color.Green;
        }

        private void hardware3_MouseLeave(object sender, EventArgs e)
        {
            hardware3.BackColor = Color.Orange;
        }

        private void hardware4_MouseHover(object sender, EventArgs e)
        {
            hardware4.BackColor = Color.Green;
        }

        private void hardware4_MouseLeave(object sender, EventArgs e)
        {
            hardware4.BackColor = Color.Orange;
        }

        private void hardware5_MouseHover(object sender, EventArgs e)
        {
            hardware5.BackColor = Color.Green;
        }

        private void hardware5_MouseLeave(object sender, EventArgs e)
        {
            hardware5.BackColor = Color.Orange;
        }

        private void hardware6_MouseHover(object sender, EventArgs e)
        {
            hardware6.BackColor = Color.Green;
        }

        private void hardware6_MouseLeave(object sender, EventArgs e)
        {
            hardware6.BackColor = Color.Orange;
        }

        private void hardware7_MouseHover(object sender, EventArgs e)
        {
            hardware7.BackColor = Color.Green;
        }

        private void hardware7_MouseLeave(object sender, EventArgs e)
        {
            hardware7.BackColor = Color.Orange;
        }

        private void hardware8_MouseHover(object sender, EventArgs e)
        {
            hardware8.BackColor = Color.Green;
        }

        private void hardware8_MouseLeave(object sender, EventArgs e)
        {
            hardware8.BackColor = Color.Orange;
        }

        private void mall1_MouseHover(object sender, EventArgs e)
        {
            mall1.BackColor = Color.Green;
        }

        private void mall1_MouseLeave(object sender, EventArgs e)
        {
            mall1.BackColor = Color.Orange;
        }

        private void mall2_MouseHover(object sender, EventArgs e)
        {
            mall2.BackColor = Color.Green;
        }

        private void mall2_MouseLeave(object sender, EventArgs e)
        {
            mall2.BackColor = Color.Orange;
        }

        private void mall3_MouseHover(object sender, EventArgs e)
        {
            mall3.BackColor = Color.Green;
        }

        private void mall3_MouseLeave(object sender, EventArgs e)
        {
            mall3.BackColor = Color.Orange;
        }

        private void mall4_MouseHover(object sender, EventArgs e)
        {
            mall4.BackColor = Color.Green;
        }

        private void mall4_MouseLeave(object sender, EventArgs e)
        {
            mall4.BackColor = Color.Orange;
        }

        private void mall5_MouseHover(object sender, EventArgs e)
        {
            mall5.BackColor = Color.Green;
        }

        private void mall5_MouseLeave(object sender, EventArgs e)
        {
            mall5.BackColor = Color.Orange;
        }

        private void mall6_MouseHover(object sender, EventArgs e)
        {
            mall6.BackColor = Color.Green;
        }

        private void mall6_MouseLeave(object sender, EventArgs e)
        {
            mall6.BackColor = Color.Orange;
        }

        private void mall7_MouseHover(object sender, EventArgs e)
        {
            mall7.BackColor = Color.Green;
        }

        private void mall7_MouseLeave(object sender, EventArgs e)
        {
            mall7.BackColor = Color.Orange;
        }

        private void mall8_MouseHover(object sender, EventArgs e)
        {
            mall8.BackColor = Color.Green;
        }

        private void mall8_MouseLeave(object sender, EventArgs e)
        {
            mall8.BackColor = Color.Orange;
        }

        private void petshop1_MouseHover(object sender, EventArgs e)
        {
            petshop1.BackColor = Color.Green;
        }

        private void petshop1_MouseLeave(object sender, EventArgs e)
        {
            petshop1.BackColor = Color.Orange;
        }

        private void petshop2_MouseHover(object sender, EventArgs e)
        {
            petshop2.BackColor = Color.Green;
        }

        private void petshop2_MouseLeave(object sender, EventArgs e)
        {
            petshop2.BackColor = Color.Orange;
        }

        private void petshop3_MouseHover(object sender, EventArgs e)
        {
            petshop3.BackColor = Color.Green;
        }

        private void petshop3_MouseLeave(object sender, EventArgs e)
        {
            petshop3.BackColor = Color.Orange;
        }

        private void petshop4_MouseHover(object sender, EventArgs e)
        {
            petshop4.BackColor = Color.Green;
        }

        private void petshop4_MouseLeave(object sender, EventArgs e)
        {
            petshop4.BackColor = Color.Orange;
        }

        private void petshop5_MouseHover(object sender, EventArgs e)
        {
            petshop5.BackColor = Color.Green;
        }

        private void petshop5_MouseLeave(object sender, EventArgs e)
        {
            petshop5.BackColor = Color.Orange;
        }

        private void petshop6_MouseHover(object sender, EventArgs e)
        {
            petshop6.BackColor = Color.Green;
        }

        private void petshop6_MouseLeave(object sender, EventArgs e)
        {
            petshop6.BackColor = Color.Orange;
        }

        private void petshop7_MouseHover(object sender, EventArgs e)
        {
            petshop7.BackColor = Color.Green;
        }

        private void petshop7_MouseLeave(object sender, EventArgs e)
        {
            petshop7.BackColor = Color.Orange;
        }

        private void petshop8_MouseHover(object sender, EventArgs e)
        {
            petshop8.BackColor = Color.Green;
        }

        private void petshop8_MouseLeave(object sender, EventArgs e)
        {
            petshop8.BackColor = Color.Orange;
        }

        private void businessForm_MouseHover(object sender, EventArgs e)
        {
            businessForm.BackColor = Color.Green;
        }

        private void businessForm_MouseLeave(object sender, EventArgs e)
        {
            businessForm.BackColor = Color.Yellow;
        }

        private void aboutForm_MouseHover(object sender, EventArgs e)
        {
            aboutForm.BackColor = Color.Green;
        }

        private void aboutForm_MouseLeave(object sender, EventArgs e)
        {
            aboutForm.BackColor = Color.Yellow;
        }

        private void salon1_MouseHover(object sender, EventArgs e)
        {
            salon1.BackColor = Color.Green;
        }

        private void salon1_MouseLeave(object sender, EventArgs e)
        {
            salon1.BackColor = Color.Orange;
        }

        private void salon2_MouseHover(object sender, EventArgs e)
        {
            salon2.BackColor = Color.Green;
        }

        private void salon2_MouseLeave(object sender, EventArgs e)
        {
            salon2.BackColor = Color.Orange;
        }

        private void salon3_MouseHover(object sender, EventArgs e)
        {
            salon3.BackColor = Color.Green;
        }

        private void salon3_MouseLeave(object sender, EventArgs e)
        {
            salon3.BackColor = Color.Orange;
        }

        private void salon4_MouseHover(object sender, EventArgs e)
        {
            salon4.BackColor = Color.Green;
        }

        private void salon4_MouseLeave(object sender, EventArgs e)
        {
            salon4.BackColor = Color.Orange;
        }

        private void salon5_MouseHover(object sender, EventArgs e)
        {
            salon5.BackColor = Color.Green;
        }

        private void salon5_MouseLeave(object sender, EventArgs e)
        {
            salon5.BackColor = Color.Orange;
        }

        private void salon6_MouseHover(object sender, EventArgs e)
        {
            salon6.BackColor = Color.Green;
        }

        private void salon6_MouseLeave(object sender, EventArgs e)
        {
            salon6.BackColor = Color.Orange;
        }

        private void salon7_MouseHover(object sender, EventArgs e)
        {
            salon7.BackColor = Color.Green;
        }

        private void salon7_MouseLeave(object sender, EventArgs e)
        {
            salon7.BackColor = Color.Orange;
        }

        private void salon8_MouseHover(object sender, EventArgs e)
        {
            salon8.BackColor = Color.Green;
        }

        private void salon8_MouseLeave(object sender, EventArgs e)
        {
            salon8.BackColor = Color.Orange;
        }

        private void stores1_MouseHover(object sender, EventArgs e)
        {
            stores1.BackColor = Color.Green;
        }

        private void stores1_MouseLeave(object sender, EventArgs e)
        {
            stores1.BackColor = Color.Orange;
        }

        private void stores2_MouseHover(object sender, EventArgs e)
        {
            stores2.BackColor = Color.Green;
        }

        private void stores2_MouseLeave(object sender, EventArgs e)
        {
            stores2.BackColor = Color.Orange;
        }

        private void stores3_MouseHover(object sender, EventArgs e)
        {
            stores3.BackColor = Color.Green;
        }

        private void stores3_MouseLeave(object sender, EventArgs e)
        {
            stores3.BackColor = Color.Orange;
        }

        private void stores4_MouseHover(object sender, EventArgs e)
        {
            stores4.BackColor = Color.Green;
        }

        private void stores4_MouseLeave(object sender, EventArgs e)
        {
            stores4.BackColor = Color.Orange;
        }

        private void stores5_MouseHover(object sender, EventArgs e)
        {
            stores5.BackColor = Color.Green;
        }

        private void stores5_MouseLeave(object sender, EventArgs e)
        {
            stores5.BackColor = Color.Orange;
        }

        private void stores6_MouseHover(object sender, EventArgs e)
        {
            stores6.BackColor = Color.Green;
        }

        private void stores6_MouseLeave(object sender, EventArgs e)
        {
            stores6.BackColor = Color.Orange;
        }

        private void stores7_MouseHover(object sender, EventArgs e)
        {
            stores7.BackColor = Color.Green;
        }

        private void stores7_MouseLeave(object sender, EventArgs e)
        {
            stores7.BackColor = Color.Orange;
        }

        private void stores8_MouseHover(object sender, EventArgs e)
        {
            stores8.BackColor = Color.Green;
        }

        private void stores8_MouseLeave(object sender, EventArgs e)
        {
            stores8.BackColor = Color.Orange;
        }

        private void foods1_MouseHover(object sender, EventArgs e)
        {
            foods1.BackColor = Color.Green;
        }

        private void foods1_MouseLeave(object sender, EventArgs e)
        {
            foods1.BackColor = Color.Orange;
        }

        private void foods2_MouseHover(object sender, EventArgs e)
        {
            foods2.BackColor = Color.Green;
        }

        private void foods2_MouseLeave(object sender, EventArgs e)
        {
            foods2.BackColor = Color.Orange;
        }

        private void foods3_MouseHover(object sender, EventArgs e)
        {
            foods3.BackColor = Color.Green;
        }

        private void foods3_MouseLeave(object sender, EventArgs e)
        {
            foods3.BackColor = Color.Orange;
        }

        private void foods4_MouseHover(object sender, EventArgs e)
        {
            foods4.BackColor = Color.Green;
        }

        private void foods4_MouseLeave(object sender, EventArgs e)
        {
            foods4.BackColor = Color.Orange;
        }

        private void foods5_MouseHover(object sender, EventArgs e)
        {
            foods5.BackColor = Color.Green;
        }

        private void foods5_MouseLeave(object sender, EventArgs e)
        {
            foods5.BackColor = Color.Orange;
        }

        private void foods6_MouseHover(object sender, EventArgs e)
        {
            foods6.BackColor = Color.Green;
        }

        private void foods6_MouseLeave(object sender, EventArgs e)
        {
            foods6.BackColor = Color.Orange;
        }

        private void foods7_MouseHover(object sender, EventArgs e)
        {
            foods7.BackColor = Color.Green;
        }

        private void foods7_MouseLeave(object sender, EventArgs e)
        {
            foods7.BackColor = Color.Orange;
        }

        private void foods8_MouseHover(object sender, EventArgs e)
        {
            foods8.BackColor = Color.Green;
        }

        private void foods8_MouseLeave(object sender, EventArgs e)
        {
            foods8.BackColor = Color.Orange;
        }

        private void commercial1_MouseHover(object sender, EventArgs e)
        {
            commercial1.BackColor = Color.Green;
        }

        private void commercial1_MouseLeave(object sender, EventArgs e)
        {
            commercial1.BackColor = Color.Orange;
        }

        private void commercial2_MouseHover(object sender, EventArgs e)
        {
            commercial2.BackColor = Color.Green;
        }

        private void commercial2_MouseLeave(object sender, EventArgs e)
        {
            commercial2.BackColor = Color.Orange;
        }

        private void commercial3_MouseHover(object sender, EventArgs e)
        {
            commercial3.BackColor = Color.Green;
        }

        private void commercial3_MouseLeave(object sender, EventArgs e)
        {
            commercial3.BackColor = Color.Orange;
        }

        private void commercial4_MouseHover(object sender, EventArgs e)
        {
            commercial4.BackColor = Color.Green;
        }

        private void commercial4_MouseLeave(object sender, EventArgs e)
        {
            commercial4.BackColor = Color.Orange;
        }

        private void commercial5_MouseHover(object sender, EventArgs e)
        {
            commercial5.BackColor = Color.Green;
        }

        private void commercial5_MouseLeave(object sender, EventArgs e)
        {
            commercial5.BackColor = Color.Orange;
        }

        private void commercial6_MouseHover(object sender, EventArgs e)
        {
            commercial6.BackColor = Color.Green;
        }

        private void commercial6_MouseLeave(object sender, EventArgs e)
        {
            commercial6.BackColor = Color.Orange;
        }

        private void commercial7_MouseHover(object sender, EventArgs e)
        {
            commercial7.BackColor = Color.Green;
        }

        private void commercial7_MouseLeave(object sender, EventArgs e)
        {
            commercial7.BackColor = Color.Orange;
        }

        private void commercial8_MouseHover(object sender, EventArgs e)
        {
            commercial8.BackColor = Color.Green;
        }

        private void commercial8_MouseLeave(object sender, EventArgs e)
        {
            commercial8.BackColor = Color.Orange;
        }

        private void furniture1_MouseHover(object sender, EventArgs e)
        {
            furniture1.BackColor = Color.Green;
        }

        private void furniture1_MouseLeave(object sender, EventArgs e)
        {
            furniture1.BackColor = Color.Orange;
        }

        private void furniture2_MouseHover(object sender, EventArgs e)
        {
            furniture2.BackColor = Color.Green;
        }

        private void furniture2_MouseLeave(object sender, EventArgs e)
        {
            furniture2.BackColor = Color.Orange;
        }

        private void furniture3_MouseHover(object sender, EventArgs e)
        {
            furniture3.BackColor = Color.Green;
        }

        private void furniture3_MouseLeave(object sender, EventArgs e)
        {
            furniture3.BackColor = Color.Orange;
        }

        private void furniture4_MouseHover(object sender, EventArgs e)
        {
            furniture4.BackColor = Color.Green;
        }

        private void furniture4_MouseLeave(object sender, EventArgs e)
        {
            furniture4.BackColor = Color.Orange;
        }

        private void furniture5_MouseHover(object sender, EventArgs e)
        {
            furniture5.BackColor = Color.Green;
        }

        private void furniture5_MouseLeave(object sender, EventArgs e)
        {
            furniture5.BackColor = Color.Orange;
        }

        private void furniture6_MouseHover(object sender, EventArgs e)
        {
            furniture6.BackColor = Color.Green;
        }

        private void furniture6_MouseLeave(object sender, EventArgs e)
        {
            furniture6.BackColor = Color.Orange;
        }

        private void furniture7_MouseHover(object sender, EventArgs e)
        {
            furniture7.BackColor = Color.Green;
        }

        private void furniture7_MouseLeave(object sender, EventArgs e)
        {
            furniture7.BackColor = Color.Orange;
        }

        private void furniture8_MouseHover(object sender, EventArgs e)
        {
            furniture8.BackColor = Color.Green;
        }

        private void furniture8_MouseLeave(object sender, EventArgs e)
        {
            furniture8.BackColor = Color.Orange;
        }

        private void water1_MouseHover(object sender, EventArgs e)
        {
            water1.BackColor = Color.Green;
        }

        private void water1_MouseLeave(object sender, EventArgs e)
        {
            water1.BackColor = Color.Orange;
        }

        private void water2_MouseHover(object sender, EventArgs e)
        {
            water2.BackColor = Color.Green;
        }

        private void water2_MouseLeave(object sender, EventArgs e)
        {
            water2.BackColor = Color.Orange;
        }

        private void water3_MouseHover(object sender, EventArgs e)
        {
            water3.BackColor = Color.Green;
        }

        private void water3_MouseLeave(object sender, EventArgs e)
        {
            water3.BackColor = Color.Orange;
        }

        private void water4_MouseHover(object sender, EventArgs e)
        {
            water4.BackColor = Color.Green;
        }

        private void water4_MouseLeave(object sender, EventArgs e)
        {
            water4.BackColor = Color.Orange;
        }

        private void water5_MouseHover(object sender, EventArgs e)
        {
            water5.BackColor = Color.Green;
        }

        private void water5_MouseLeave(object sender, EventArgs e)
        {
            water5.BackColor = Color.Orange;
        }

        private void water6_MouseHover(object sender, EventArgs e)
        {
            water6.BackColor = Color.Green;
        }

        private void water6_MouseLeave(object sender, EventArgs e)
        {
            water6.BackColor = Color.Orange;
        }

        private void water7_MouseHover(object sender, EventArgs e)
        {
            water7.BackColor = Color.Green;
        }

        private void water7_MouseLeave(object sender, EventArgs e)
        {
            water7.BackColor = Color.Orange;
        }

        private void water8_MouseHover(object sender, EventArgs e)
        {
            water8.BackColor = Color.Green;
        }

        private void water8_MouseLeave(object sender, EventArgs e)
        {
            water8.BackColor = Color.Orange;
        }

        // Change button Color -- end

        // Change button Picture -- Start

        private void hardwareBTN_MouseHover(object sender, EventArgs e)
        {
            hardwareBTN.BackgroundImage = CBP_Manila.Properties.Resources._9_1;
        }

        private void hardwareBTN_MouseLeave(object sender, EventArgs e)
        {
            hardwareBTN.BackgroundImage = CBP_Manila.Properties.Resources._9;
        }

        private void mallsBTN_MouseHover(object sender, EventArgs e)
        {
            mallsBTN.BackgroundImage = CBP_Manila.Properties.Resources._8_1;
        }

        private void mallsBTN_MouseLeave(object sender, EventArgs e)
        {
            mallsBTN.BackgroundImage = CBP_Manila.Properties.Resources._8;
        }

        private void petshopBTN_MouseHover(object sender, EventArgs e)
        {
            petshopBTN.BackgroundImage = CBP_Manila.Properties.Resources._7_1;
        }

        private void petshopBTN_MouseLeave(object sender, EventArgs e)
        {
            petshopBTN.BackgroundImage = CBP_Manila.Properties.Resources._7;
        }

        private void salonBTN_MouseHover(object sender, EventArgs e)
        {
            salonBTN.BackgroundImage = CBP_Manila.Properties.Resources._6_1;
        }

        private void salonBTN_MouseLeave(object sender, EventArgs e)
        {
            salonBTN.BackgroundImage = CBP_Manila.Properties.Resources._6;
        }

        private void storeBTN_MouseHover(object sender, EventArgs e)
        {
            storeBTN.BackgroundImage = CBP_Manila.Properties.Resources._5_1;
        }

        private void storeBTN_MouseLeave(object sender, EventArgs e)
        {
            storeBTN.BackgroundImage = CBP_Manila.Properties.Resources._5;
        }

        private void foodsBTN_MouseHover(object sender, EventArgs e)
        {
            foodsBTN.BackgroundImage = CBP_Manila.Properties.Resources._4_1;
        }

        private void foodsBTN_MouseLeave(object sender, EventArgs e)
        {
            foodsBTN.BackgroundImage = CBP_Manila.Properties.Resources._4;
        }

        private void commercialBTN_MouseHover(object sender, EventArgs e)
        {
            commercialBTN.BackgroundImage = CBP_Manila.Properties.Resources._3_1;
        }

        private void commercialBTN_MouseLeave(object sender, EventArgs e)
        {
            commercialBTN.BackgroundImage = CBP_Manila.Properties.Resources._3;
        }

        private void furnituresBTN_MouseHover(object sender, EventArgs e)
        {
            furnituresBTN.BackgroundImage = CBP_Manila.Properties.Resources._2_1;
        }

        private void furnituresBTN_MouseLeave(object sender, EventArgs e)
        {
            furnituresBTN.BackgroundImage = CBP_Manila.Properties.Resources._2;
        }

        private void waterstationsBTN_MouseHover(object sender, EventArgs e)
        {
            waterstationsBTN.BackgroundImage = CBP_Manila.Properties.Resources._1_1;
        }

        private void waterstationsBTN_MouseLeave(object sender, EventArgs e)
        {
            waterstationsBTN.BackgroundImage = CBP_Manila.Properties.Resources._1;
        }
        // Change button Picture -- end

        private void aboutForm_Click(object sender, EventArgs e)
        {
            // ABOUT
            Form4 f4 = new Form4();
            f4.TopMost = true;
            f4.ShowDialog();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {

        }

        private void srcBTN_Click(object sender, EventArgs e)
        {
            currentUser.Text = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = textBox1.Text;

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into logbook ([User], [BusinessName], [DateTimeAccessed]) values ('" + currentUser.Text + "', '" + searchValueUser + "', '" + currentTimeDate + "')";
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

        public void quickAccessSelected(string selected)
        {
            searchValue.search = selected;

            //New Form
            Form3 f3 = new Form3();
            f3.TopMost = true;
            f3.ShowDialog();
        }

        public void quickAccessSelected_log(string user, string business, string time)
        {          
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jeff Catulay\source\repos\CBP-Manila\CBP-Manila\logIn.accdb");
                con.Open();
                OleDbCommand cmd;
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into logbook ([User], [BusinessName], [DateTimeAccessed]) values ('" + user + "', '" + business + "', '" + time + "')";
                cmd.ExecuteNonQuery();
                con.Close();           
            }
            catch (Exception except)
            {
                MessageBox.Show("Error " + except);
            }
        }

        private void hardware1_Click(object sender, EventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Rufino Hardware Intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Rex Hardware Binondo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "JBBC Hardware & General Merchandise Pandacan";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Hzkia Hardware Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Sta. Mesa Hardware Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "New Paco Hardware Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Luzon Sales Co Inc Quiapo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void hardware8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jpl Hardware Lumber";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Xentro Mall Sta  Ana";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Tayuman Center Mall  Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Decal Mall Tondo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Divisoria Mall San Nicolas";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "University Mall Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Robinsons Otis Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "SM City Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void mall8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Isetann Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Oro Cargo Movers Incorporated Intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Pet+plus Binondo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Dogs and the City Ermita";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Pet Central Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Pets & Vets Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Cats Collection San Nicolas";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Kimtins Pet Shop Sta  Ana";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void petshop8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Happymeal Raw Dogfood Sta  Ana";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Salon De Manila  Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Bangs  Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Ystilo Salon  Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Princess Cut Salon Quiapo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "F Salon Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Nailflix Spa Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Davids Salon Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void salon8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Premium CUT Salon Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Wellcome Supermarket Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "GJRELX Pandacan Pandacan";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Hilton Mart Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Savemore SMDC Green Residences Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "All Day Convenience Store Vista Taft Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jerome Store";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Junoesque & Co. San Miguel";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void stores8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Danny Store San Andres";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "McDonald Intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Moonleaf Tea Shop intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jollibee Binondo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Popeyes Louisiana Kitchen ErmitaTapsilogan Food House Pandacan";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Tapsilogan Food House Pandacan";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Chowking Espana Blvd Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Sabroso Comfort Food Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void foods8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jose Fastfood Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "UnionBank of the Philippines Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Shell Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Watsons Isetann Cinerama (Click & Collect) Quiapo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Land Bank ATM Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Cebuana Lhuillier Pawnshop 1571 Pedro Gil St. Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Ersao San Miguel";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Security Bank Mendiola";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void commercial8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Philippine National Bank Sta  Ana";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Dispatching Office Intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Decena Invention Technologies Pandacan";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "FB Furnitures and Home Improvements Sampaloc";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Storage Cabinet Manufacturer Santa Mesa";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Bonny Furniture Paco";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jeamm Commercial San Nicolas";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Mega Office Furniture Tondo";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void furniture8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Silahis Center Intramuros";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water1_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Mv Water Station Ermita";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water2_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Venice Water Station Sampaloc ";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water3_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Aqua 300 Water Refilling Station Malate";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water4_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Agua De Magdala Water Refilling Station";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water5_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Natures Flow Water Station San Andres";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water6_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Sebastian Water Station Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water7_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Qualibest Water Refilling Station  Sta Cruz";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }

        private void water8_MouseClick(object sender, MouseEventArgs e)
        {
            currentUser.Text = userLog.var;
            string user = userLog.var;
            String currentTimeDate = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
            String searchValueUser = "Jaybeth Water Refilling Station Sta  Ana";

            quickAccessSelected_log(user, searchValueUser, currentTimeDate);
            quickAccessSelected(searchValueUser);
        }
    }
}
