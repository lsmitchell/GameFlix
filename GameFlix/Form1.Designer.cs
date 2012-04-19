namespace GameFlix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.userTypeBox = new System.Windows.Forms.Label();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.itemIdBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.summaryBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.queueLabel = new System.Windows.Forms.Label();
            this.addToQueueButton = new System.Windows.Forms.Button();
            this.removeFromQueueButton = new System.Windows.Forms.Button();
            this.inventoryBox = new System.Windows.Forms.ListBox();
            this.queueBox = new System.Windows.Forms.ListBox();
            this.fnBox = new System.Windows.Forms.TextBox();
            this.lnBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailChangeBox = new System.Windows.Forms.TextBox();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.fnLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailChangeLabel = new System.Windows.Forms.Label();
            this.customersButton = new System.Windows.Forms.RadioButton();
            this.employeeButton = new System.Windows.Forms.RadioButton();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.introLabel = new System.Windows.Forms.Label();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.inventoryLabel.Location = new System.Drawing.Point(13, 13);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(94, 23);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "Inventory:";
            this.inventoryLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(526, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(486, 43);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(160, 20);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(486, 79);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(160, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(414, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(384, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Orange;
            this.loginButton.Location = new System.Drawing.Point(486, 117);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.userTypeLabel.Location = new System.Drawing.Point(464, 152);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(93, 21);
            this.userTypeLabel.TabIndex = 8;
            this.userTypeLabel.Text = "User Type:";
            this.userTypeLabel.Visible = false;
            // 
            // userTypeBox
            // 
            this.userTypeBox.AutoSize = true;
            this.userTypeBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.userTypeBox.Location = new System.Drawing.Point(563, 152);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(83, 21);
            this.userTypeBox.TabIndex = 9;
            this.userTypeBox.Text = "Customer";
            this.userTypeBox.Visible = false;
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.itemIdLabel.Location = new System.Drawing.Point(68, 289);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(71, 21);
            this.itemIdLabel.TabIndex = 10;
            this.itemIdLabel.Text = "Item ID:";
            this.itemIdLabel.Visible = false;
            this.itemIdLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // itemIdBox
            // 
            this.itemIdBox.Location = new System.Drawing.Point(12, 313);
            this.itemIdBox.Name = "itemIdBox";
            this.itemIdBox.Size = new System.Drawing.Size(187, 20);
            this.itemIdBox.TabIndex = 11;
            this.itemIdBox.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Orange;
            this.returnButton.Location = new System.Drawing.Point(12, 339);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(187, 23);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Return Item";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.titleLabel.Location = new System.Drawing.Point(8, 374);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(47, 21);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Title:";
            this.titleLabel.Visible = false;
            this.titleLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 398);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(245, 20);
            this.titleBox.TabIndex = 14;
            this.titleBox.Visible = false;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(12, 450);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(52, 20);
            this.ratingBox.TabIndex = 15;
            this.ratingBox.Visible = false;
            // 
            // platformBox
            // 
            this.platformBox.Location = new System.Drawing.Point(89, 450);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(168, 20);
            this.platformBox.TabIndex = 16;
            this.platformBox.Visible = false;
            // 
            // summaryBox
            // 
            this.summaryBox.Location = new System.Drawing.Point(12, 500);
            this.summaryBox.Multiline = true;
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(245, 88);
            this.summaryBox.TabIndex = 17;
            this.summaryBox.Visible = false;
            this.summaryBox.TextChanged += new System.EventHandler(this.summaryBox_TextChanged);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.ratingLabel.Location = new System.Drawing.Point(8, 426);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(62, 21);
            this.ratingLabel.TabIndex = 19;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.Visible = false;
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.platformLabel.Location = new System.Drawing.Point(85, 426);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(127, 21);
            this.platformLabel.TabIndex = 20;
            this.platformLabel.Text = "Game Platform:";
            this.platformLabel.Visible = false;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.summaryLabel.Location = new System.Drawing.Point(8, 476);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(85, 21);
            this.summaryLabel.TabIndex = 21;
            this.summaryLabel.Text = "Summary:";
            this.summaryLabel.Visible = false;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.Orange;
            this.addItemButton.Location = new System.Drawing.Point(12, 594);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(114, 23);
            this.addItemButton.TabIndex = 22;
            this.addItemButton.Text = "Add/Save Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Visible = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.Orange;
            this.removeItemButton.Location = new System.Drawing.Point(132, 594);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(125, 23);
            this.removeItemButton.TabIndex = 23;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Visible = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.queueLabel.Location = new System.Drawing.Point(12, 279);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(62, 21);
            this.queueLabel.TabIndex = 24;
            this.queueLabel.Text = "Queue:";
            this.queueLabel.Visible = false;
            // 
            // addToQueueButton
            // 
            this.addToQueueButton.BackColor = System.Drawing.Color.Orange;
            this.addToQueueButton.Location = new System.Drawing.Point(205, 144);
            this.addToQueueButton.Name = "addToQueueButton";
            this.addToQueueButton.Size = new System.Drawing.Size(108, 38);
            this.addToQueueButton.TabIndex = 26;
            this.addToQueueButton.Text = "Add to Queue";
            this.addToQueueButton.UseVisualStyleBackColor = false;
            this.addToQueueButton.Visible = false;
            this.addToQueueButton.Click += new System.EventHandler(this.addToQueueButton_Click);
            // 
            // removeFromQueueButton
            // 
            this.removeFromQueueButton.BackColor = System.Drawing.Color.DarkOrange;
            this.removeFromQueueButton.Location = new System.Drawing.Point(205, 409);
            this.removeFromQueueButton.Name = "removeFromQueueButton";
            this.removeFromQueueButton.Size = new System.Drawing.Size(108, 38);
            this.removeFromQueueButton.TabIndex = 27;
            this.removeFromQueueButton.Text = "Remove from Queue";
            this.removeFromQueueButton.UseVisualStyleBackColor = false;
            this.removeFromQueueButton.Visible = false;
            this.removeFromQueueButton.Click += new System.EventHandler(this.removeFromQueueButton_Click);
            // 
            // inventoryBox
            // 
            this.inventoryBox.FormattingEnabled = true;
            this.inventoryBox.Location = new System.Drawing.Point(16, 43);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(183, 225);
            this.inventoryBox.TabIndex = 28;
            this.inventoryBox.Visible = false;
            this.inventoryBox.SelectedIndexChanged += new System.EventHandler(this.inventoryBox_SelectedIndexChanged);
            // 
            // queueBox
            // 
            this.queueBox.FormattingEnabled = true;
            this.queueBox.Location = new System.Drawing.Point(17, 302);
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(182, 225);
            this.queueBox.TabIndex = 29;
            this.queueBox.Visible = false;
            this.queueBox.SelectedIndexChanged += new System.EventHandler(this.queueBox_SelectedIndexChanged);
            // 
            // fnBox
            // 
            this.fnBox.Location = new System.Drawing.Point(316, 362);
            this.fnBox.Name = "fnBox";
            this.fnBox.Size = new System.Drawing.Size(164, 20);
            this.fnBox.TabIndex = 30;
            this.fnBox.Visible = false;
            // 
            // lnBox
            // 
            this.lnBox.Location = new System.Drawing.Point(489, 362);
            this.lnBox.Name = "lnBox";
            this.lnBox.Size = new System.Drawing.Size(164, 20);
            this.lnBox.TabIndex = 31;
            this.lnBox.Visible = false;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(316, 419);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(337, 20);
            this.addressBox.TabIndex = 32;
            this.addressBox.Visible = false;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(316, 478);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(117, 20);
            this.cityBox.TabIndex = 33;
            this.cityBox.Visible = false;
            // 
            // stateBox
            // 
            this.stateBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stateBox.Location = new System.Drawing.Point(452, 478);
            this.stateBox.MaxLength = 2;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(42, 20);
            this.stateBox.TabIndex = 34;
            this.stateBox.Visible = false;
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(514, 478);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(132, 20);
            this.zipBox.TabIndex = 35;
            this.zipBox.Visible = false;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(316, 536);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(164, 20);
            this.phoneBox.TabIndex = 36;
            this.phoneBox.Visible = false;
            // 
            // emailChangeBox
            // 
            this.emailChangeBox.Location = new System.Drawing.Point(316, 594);
            this.emailChangeBox.Name = "emailChangeBox";
            this.emailChangeBox.Size = new System.Drawing.Size(164, 20);
            this.emailChangeBox.TabIndex = 37;
            this.emailChangeBox.Visible = false;
            // 
            // saveUserButton
            // 
            this.saveUserButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveUserButton.Location = new System.Drawing.Point(514, 526);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(132, 30);
            this.saveUserButton.TabIndex = 38;
            this.saveUserButton.Text = "Save Info";
            this.saveUserButton.UseVisualStyleBackColor = false;
            this.saveUserButton.Visible = false;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addUserButton.Location = new System.Drawing.Point(514, 562);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(132, 30);
            this.addUserButton.TabIndex = 39;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Visible = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteUserButton.Location = new System.Drawing.Point(514, 598);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(132, 30);
            this.deleteUserButton.TabIndex = 40;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Visible = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.fnLabel.Location = new System.Drawing.Point(312, 338);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(96, 21);
            this.fnLabel.TabIndex = 41;
            this.fnLabel.Text = "First Name:";
            this.fnLabel.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.addressLabel.Location = new System.Drawing.Point(312, 395);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(77, 21);
            this.addressLabel.TabIndex = 42;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Visible = false;
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lnLabel.Location = new System.Drawing.Point(486, 338);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(94, 21);
            this.lnLabel.TabIndex = 43;
            this.lnLabel.Text = "Last Name:";
            this.lnLabel.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.cityLabel.Location = new System.Drawing.Point(312, 454);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(45, 21);
            this.cityLabel.TabIndex = 44;
            this.cityLabel.Text = "City:";
            this.cityLabel.Visible = false;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.stateLabel.Location = new System.Drawing.Point(448, 454);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(51, 21);
            this.stateLabel.TabIndex = 45;
            this.stateLabel.Text = "State:";
            this.stateLabel.Visible = false;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.zipLabel.Location = new System.Drawing.Point(510, 454);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(85, 21);
            this.zipLabel.TabIndex = 46;
            this.zipLabel.Text = "Zip Code:";
            this.zipLabel.Visible = false;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.phoneLabel.Location = new System.Drawing.Point(312, 512);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(126, 21);
            this.phoneLabel.TabIndex = 47;
            this.phoneLabel.Text = "Phone Number:";
            this.phoneLabel.Visible = false;
            // 
            // emailChangeLabel
            // 
            this.emailChangeLabel.AutoSize = true;
            this.emailChangeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailChangeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.emailChangeLabel.Location = new System.Drawing.Point(312, 570);
            this.emailChangeLabel.Name = "emailChangeLabel";
            this.emailChangeLabel.Size = new System.Drawing.Size(55, 21);
            this.emailChangeLabel.TabIndex = 48;
            this.emailChangeLabel.Text = "Email:";
            this.emailChangeLabel.Visible = false;
            // 
            // customersButton
            // 
            this.customersButton.AutoSize = true;
            this.customersButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.customersButton.Location = new System.Drawing.Point(346, 277);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(92, 23);
            this.customersButton.TabIndex = 49;
            this.customersButton.TabStop = true;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Visible = false;
            this.customersButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // employeeButton
            // 
            this.employeeButton.AutoSize = true;
            this.employeeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.employeeButton.Location = new System.Drawing.Point(346, 302);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(93, 23);
            this.employeeButton.TabIndex = 50;
            this.employeeButton.TabStop = true;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Visible = false;
            this.employeeButton.CheckedChanged += new System.EventHandler(this.employeeButton_CheckedChanged);
            // 
            // selectBox
            // 
            this.selectBox.BackColor = System.Drawing.Color.LightCoral;
            this.selectBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Location = new System.Drawing.Point(486, 289);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(155, 21);
            this.selectBox.TabIndex = 51;
            this.selectBox.Text = "Select";
            this.selectBox.Visible = false;
            this.selectBox.SelectedIndexChanged += new System.EventHandler(this.selectBox_SelectedIndexChanged);
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.introLabel.Location = new System.Drawing.Point(8, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(412, 23);
            this.introLabel.TabIndex = 52;
            this.introLabel.Text = "Welcome to the GameFlix Experience Software!";
            // 
            // introLabel2
            // 
            this.introLabel2.AutoSize = true;
            this.introLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.introLabel2.Location = new System.Drawing.Point(8, 32);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(158, 19);
            this.introLabel2.TabIndex = 53;
            this.introLabel2.Text = "Please log in to continue.";
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Orange;
            this.infoButton.Location = new System.Drawing.Point(205, 43);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(108, 38);
            this.infoButton.TabIndex = 54;
            this.infoButton.Text = "Information";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Visible = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(665, 651);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.introLabel2);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.emailChangeLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.emailChangeBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lnBox);
            this.Controls.Add(this.fnBox);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.removeFromQueueButton);
            this.Controls.Add(this.addToQueueButton);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.platformLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.itemIdBox);
            this.Controls.Add(this.itemIdLabel);
            this.Controls.Add(this.userTypeBox);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inventoryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GameFlix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label userTypeBox;
        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.TextBox itemIdBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.TextBox summaryBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Button addToQueueButton;
        private System.Windows.Forms.Button removeFromQueueButton;
        private System.Windows.Forms.ListBox inventoryBox;
        private System.Windows.Forms.ListBox queueBox;
        private System.Windows.Forms.TextBox fnBox;
        private System.Windows.Forms.TextBox lnBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailChangeBox;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailChangeLabel;
        private System.Windows.Forms.RadioButton customersButton;
        private System.Windows.Forms.RadioButton employeeButton;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.Button infoButton;
    }
}

