namespace CBP_Manila
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.suffixConfirm = new System.Windows.Forms.CheckBox();
            this.suffixName = new System.Windows.Forms.TextBox();
            this.suffixTXT = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_upBTN = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logInDataSet = new CBP_Manila.logInDataSet();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter = new CBP_Manila.logInDataSetTableAdapters.logTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.White;
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lastName.Location = new System.Drawing.Point(850, 289);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(221, 44);
            this.lastName.TabIndex = 1;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_KeyDown);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.White;
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.firstName.Location = new System.Drawing.Point(1079, 289);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(218, 44);
            this.firstName.TabIndex = 2;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstName_KeyDown);
            // 
            // middleName
            // 
            this.middleName.BackColor = System.Drawing.Color.White;
            this.middleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.middleName.Location = new System.Drawing.Point(1304, 289);
            this.middleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(66, 44);
            this.middleName.TabIndex = 3;
            this.middleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.middleName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.middleName_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1122, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1316, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "M,I";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.address.Location = new System.Drawing.Point(854, 390);
            this.address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(600, 44);
            this.address.TabIndex = 7;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1099, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.White;
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.contact.Location = new System.Drawing.Point(854, 489);
            this.contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(203, 44);
            this.contact.TabIndex = 9;
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contact_KeyDown);
            // 
            // suffixConfirm
            // 
            this.suffixConfirm.AutoSize = true;
            this.suffixConfirm.BackColor = System.Drawing.Color.Transparent;
            this.suffixConfirm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suffixConfirm.Location = new System.Drawing.Point(850, 256);
            this.suffixConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suffixConfirm.Name = "suffixConfirm";
            this.suffixConfirm.Size = new System.Drawing.Size(197, 25);
            this.suffixConfirm.TabIndex = 10;
            this.suffixConfirm.Text = "I Have a Suffix Name";
            this.suffixConfirm.UseVisualStyleBackColor = false;
            this.suffixConfirm.CheckedChanged += new System.EventHandler(this.suffixConfirm_CheckedChanged);
            // 
            // suffixName
            // 
            this.suffixName.BackColor = System.Drawing.Color.White;
            this.suffixName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suffixName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.suffixName.Location = new System.Drawing.Point(1377, 289);
            this.suffixName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suffixName.Name = "suffixName";
            this.suffixName.Size = new System.Drawing.Size(82, 44);
            this.suffixName.TabIndex = 11;
            this.suffixName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // suffixTXT
            // 
            this.suffixTXT.BackColor = System.Drawing.Color.Transparent;
            this.suffixTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suffixTXT.Location = new System.Drawing.Point(1385, 340);
            this.suffixTXT.Name = "suffixTXT";
            this.suffixTXT.Size = new System.Drawing.Size(88, 29);
            this.suffixTXT.TabIndex = 12;
            this.suffixTXT.Text = "Suffix";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.age.Location = new System.Drawing.Point(1064, 489);
            this.age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(117, 44);
            this.age.TabIndex = 13;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.age_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(860, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1094, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1271, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "I prefer not to say"});
            this.gender.Location = new System.Drawing.Point(1188, 489);
            this.gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(266, 45);
            this.gender.TabIndex = 17;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.username.Location = new System.Drawing.Point(854, 599);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(600, 44);
            this.username.TabIndex = 18;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.password.Location = new System.Drawing.Point(850, 686);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(604, 44);
            this.password.TabIndex = 19;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1099, 650);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1099, 735);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CBP_Manila.Properties.Resources._1111;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1064, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 182);
            this.panel1.TabIndex = 22;
            // 
            // sign_upBTN
            // 
            this.sign_upBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sign_upBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_upBTN.Location = new System.Drawing.Point(976, 880);
            this.sign_upBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sign_upBTN.Name = "sign_upBTN";
            this.sign_upBTN.Size = new System.Drawing.Size(370, 54);
            this.sign_upBTN.TabIndex = 4;
            this.sign_upBTN.Text = "Sign Up";
            this.sign_upBTN.UseVisualStyleBackColor = false;
            this.sign_upBTN.Click += new System.EventHandler(this.sign_upBTN_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.White;
            this.confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.confirmPassword.Location = new System.Drawing.Point(854, 772);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(600, 44);
            this.confirmPassword.TabIndex = 23;
            this.confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1060, 821);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Confirm Password";
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.Transparent;
            this.logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(1083, 950);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(227, 29);
            this.logIn.TabIndex = 25;
            this.logIn.Text = "Or Log In Now";
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            this.logIn.MouseLeave += new System.EventHandler(this.logIn_MouseLeave);
            this.logIn.MouseHover += new System.EventHandler(this.logIn_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView1.DataSource = this.logBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 821);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(553, 158);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.Visible = false;
            // 
            // logInDataSet
            // 
            this.logInDataSet.DataSetName = "logInDataSet";
            this.logInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "log";
            this.logBindingSource.DataSource = this.logInDataSet;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fistname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fistname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Middle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Middle";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Suffix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Suffix";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn8.HeaderText = "Age";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn10.HeaderText = "Username";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn11.HeaderText = "Password";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CBP_Manila.Properties.Resources.Sign_Up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1526, 1016);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.sign_upBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age);
            this.Controls.Add(this.suffixTXT);
            this.Controls.Add(this.suffixName);
            this.Controls.Add(this.suffixConfirm);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.CheckBox suffixConfirm;
        private System.Windows.Forms.TextBox suffixName;
        private System.Windows.Forms.Label suffixTXT;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sign_upBTN;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fistnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private logInDataSet logInDataSet;
        private System.Windows.Forms.BindingSource logBindingSource;
        private logInDataSetTableAdapters.logTableAdapter logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}