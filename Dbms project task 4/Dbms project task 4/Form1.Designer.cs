namespace Dbms_project_task_4
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new Dbms_project_task_4.RestaurantDataSet();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRestaurant = new System.Windows.Forms.TabPage();
            this.cbRestaurant = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteRestaurant = new System.Windows.Forms.Button();
            this.btnSearchRestaurant = new System.Windows.Forms.Button();
            this.btnUpdateRestaurant = new System.Windows.Forms.Button();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.txtRestaurantEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.dataGridViewRestaurant = new System.Windows.Forms.DataGridView();
            this.restaurantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnSearchMenu = new System.Windows.Forms.Button();
            this.btnUpdateMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtRestaurantIDinput = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderRestaurantID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMenuItem = new System.Windows.Forms.TabPage();
            this.cbMenuItem = new System.Windows.Forms.ComboBox();
            this.btnDeleteMenuItem = new System.Windows.Forms.Button();
            this.btnUpdateMenuItem = new System.Windows.Forms.Button();
            this.btnSearchMenuItem = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtMenuID = new System.Windows.Forms.TextBox();
            this.dataGridViewMenuItem = new System.Windows.Forms.DataGridView();
            this.tabOrderItem = new System.Windows.Forms.TabPage();
            this.cbOrderItem = new System.Windows.Forms.ComboBox();
            this.btnSearchOrderItem = new System.Windows.Forms.Button();
            this.btnDeleteOrderItem = new System.Windows.Forms.Button();
            this.btnUpdateOrderItem = new System.Windows.Forms.Button();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMenuItemID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderItem = new System.Windows.Forms.DataGridView();
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.RestaurantTableAdapter();
            this.customerTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.CustomerTableAdapter();
            this.orderTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.OrderTableAdapter();
            this.orderItemTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.OrderItemTableAdapter();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.MenuTableAdapter();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemTableAdapter = new Dbms_project_task_4.RestaurantDataSetTableAdapters.MenuItemTableAdapter();
            this.menuItemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabRestaurant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).BeginInit();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItem)).BeginInit();
            this.tabOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCustomer);
            this.tabControlMain.Controls.Add(this.tabRestaurant);
            this.tabControlMain.Controls.Add(this.tabMenu);
            this.tabControlMain.Controls.Add(this.tabOrder);
            this.tabControlMain.Controls.Add(this.tabMenuItem);
            this.tabControlMain.Controls.Add(this.tabOrderItem);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.cbCustomer);
            this.tabCustomer.Controls.Add(this.btnSearchCustomer);
            this.tabCustomer.Controls.Add(this.btnDeleteCustomer);
            this.tabCustomer.Controls.Add(this.btnUpdateCustomer);
            this.tabCustomer.Controls.Add(this.btnAddCustomer);
            this.tabCustomer.Controls.Add(this.txtAddress);
            this.tabCustomer.Controls.Add(this.txtPhoneNumber);
            this.tabCustomer.Controls.Add(this.txtEmail);
            this.tabCustomer.Controls.Add(this.txtLastName);
            this.tabCustomer.Controls.Add(this.txtFirstName);
            this.tabCustomer.Controls.Add(this.dataGridViewCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(768, 400);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "tabCustomer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.customerBindingSource;
            this.cbCustomer.DisplayMember = "CustomerID";
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(287, 263);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 10;
            this.cbCustomer.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(178, 289);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomer.TabIndex = 9;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(414, 292);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 8;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(414, 263);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 7;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(178, 263);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(7, 370);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(7, 343);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 289);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 263);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(759, 251);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabRestaurant
            // 
            this.tabRestaurant.Controls.Add(this.cbRestaurant);
            this.tabRestaurant.Controls.Add(this.btnDeleteRestaurant);
            this.tabRestaurant.Controls.Add(this.btnSearchRestaurant);
            this.tabRestaurant.Controls.Add(this.btnUpdateRestaurant);
            this.tabRestaurant.Controls.Add(this.btnAddRestaurant);
            this.tabRestaurant.Controls.Add(this.txtRestaurantEmail);
            this.tabRestaurant.Controls.Add(this.txtContactNumber);
            this.tabRestaurant.Controls.Add(this.txtLocation);
            this.tabRestaurant.Controls.Add(this.txtRestaurantName);
            this.tabRestaurant.Controls.Add(this.dataGridViewRestaurant);
            this.tabRestaurant.Location = new System.Drawing.Point(4, 22);
            this.tabRestaurant.Name = "tabRestaurant";
            this.tabRestaurant.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestaurant.Size = new System.Drawing.Size(768, 400);
            this.tabRestaurant.TabIndex = 1;
            this.tabRestaurant.Text = "tabRestaurant";
            this.tabRestaurant.UseVisualStyleBackColor = true;
            // 
            // cbRestaurant
            // 
            this.cbRestaurant.DataSource = this.restaurantBindingSource;
            this.cbRestaurant.DisplayMember = "RestaurantID";
            this.cbRestaurant.FormattingEnabled = true;
            this.cbRestaurant.Location = new System.Drawing.Point(275, 250);
            this.cbRestaurant.Name = "cbRestaurant";
            this.cbRestaurant.Size = new System.Drawing.Size(121, 21);
            this.cbRestaurant.TabIndex = 9;
            this.cbRestaurant.ValueMember = "RestaurantID";
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataMember = "Restaurant";
            this.restaurantBindingSource.DataSource = this.restaurantDataSet;
            // 
            // btnDeleteRestaurant
            // 
            this.btnDeleteRestaurant.Location = new System.Drawing.Point(402, 278);
            this.btnDeleteRestaurant.Name = "btnDeleteRestaurant";
            this.btnDeleteRestaurant.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRestaurant.TabIndex = 8;
            this.btnDeleteRestaurant.Text = "Delete";
            this.btnDeleteRestaurant.UseVisualStyleBackColor = true;
            this.btnDeleteRestaurant.Click += new System.EventHandler(this.btnDeleteRestaurant_Click);
            // 
            // btnSearchRestaurant
            // 
            this.btnSearchRestaurant.Location = new System.Drawing.Point(169, 274);
            this.btnSearchRestaurant.Name = "btnSearchRestaurant";
            this.btnSearchRestaurant.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRestaurant.TabIndex = 7;
            this.btnSearchRestaurant.Text = "Search ";
            this.btnSearchRestaurant.UseVisualStyleBackColor = true;
            this.btnSearchRestaurant.Click += new System.EventHandler(this.btnSearchRestaurant_Click);
            // 
            // btnUpdateRestaurant
            // 
            this.btnUpdateRestaurant.Location = new System.Drawing.Point(402, 249);
            this.btnUpdateRestaurant.Name = "btnUpdateRestaurant";
            this.btnUpdateRestaurant.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRestaurant.TabIndex = 6;
            this.btnUpdateRestaurant.Text = "Update";
            this.btnUpdateRestaurant.UseVisualStyleBackColor = true;
            this.btnUpdateRestaurant.Click += new System.EventHandler(this.btnUpdateRestaurant_Click);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.Location = new System.Drawing.Point(169, 250);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(75, 23);
            this.btnAddRestaurant.TabIndex = 5;
            this.btnAddRestaurant.Text = "Add";
            this.btnAddRestaurant.UseVisualStyleBackColor = true;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
            // 
            // txtRestaurantEmail
            // 
            this.txtRestaurantEmail.Location = new System.Drawing.Point(7, 331);
            this.txtRestaurantEmail.Name = "txtRestaurantEmail";
            this.txtRestaurantEmail.Size = new System.Drawing.Size(156, 20);
            this.txtRestaurantEmail.TabIndex = 4;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(7, 304);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(156, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(7, 277);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(156, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(7, 250);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(156, 20);
            this.txtRestaurantName.TabIndex = 1;
            // 
            // dataGridViewRestaurant
            // 
            this.dataGridViewRestaurant.AllowUserToAddRows = false;
            this.dataGridViewRestaurant.AllowUserToDeleteRows = false;
            this.dataGridViewRestaurant.AutoGenerateColumns = false;
            this.dataGridViewRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantIDDataGridViewTextBoxColumn,
            this.restaurantNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewRestaurant.DataSource = this.restaurantBindingSource;
            this.dataGridViewRestaurant.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            this.dataGridViewRestaurant.ReadOnly = true;
            this.dataGridViewRestaurant.Size = new System.Drawing.Size(756, 237);
            this.dataGridViewRestaurant.TabIndex = 0;
            this.dataGridViewRestaurant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRestaurant_CellContentClick);
            // 
            // restaurantIDDataGridViewTextBoxColumn
            // 
            this.restaurantIDDataGridViewTextBoxColumn.DataPropertyName = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn.HeaderText = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn.Name = "restaurantIDDataGridViewTextBoxColumn";
            this.restaurantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restaurantNameDataGridViewTextBoxColumn
            // 
            this.restaurantNameDataGridViewTextBoxColumn.DataPropertyName = "RestaurantName";
            this.restaurantNameDataGridViewTextBoxColumn.HeaderText = "RestaurantName";
            this.restaurantNameDataGridViewTextBoxColumn.Name = "restaurantNameDataGridViewTextBoxColumn";
            this.restaurantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.cbMenu);
            this.tabMenu.Controls.Add(this.btnDeleteMenu);
            this.tabMenu.Controls.Add(this.btnSearchMenu);
            this.tabMenu.Controls.Add(this.btnUpdateMenu);
            this.tabMenu.Controls.Add(this.btnAddMenu);
            this.tabMenu.Controls.Add(this.txtMenuName);
            this.tabMenu.Controls.Add(this.txtRestaurantIDinput);
            this.tabMenu.Controls.Add(this.dataGridViewMenu);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(768, 400);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.Text = "tabMenu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // cbMenu
            // 
            this.cbMenu.DataSource = this.menuBindingSource;
            this.cbMenu.DisplayMember = "MenuID";
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(281, 241);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(121, 21);
            this.cbMenu.TabIndex = 7;
            this.cbMenu.ValueMember = "MenuID";
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(408, 270);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMenu.TabIndex = 6;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnSearchMenu
            // 
            this.btnSearchMenu.Location = new System.Drawing.Point(110, 265);
            this.btnSearchMenu.Name = "btnSearchMenu";
            this.btnSearchMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMenu.TabIndex = 5;
            this.btnSearchMenu.Text = "Search ";
            this.btnSearchMenu.UseVisualStyleBackColor = true;
            this.btnSearchMenu.Click += new System.EventHandler(this.btnSearchMenu_Click);
            // 
            // btnUpdateMenu
            // 
            this.btnUpdateMenu.Location = new System.Drawing.Point(408, 241);
            this.btnUpdateMenu.Name = "btnUpdateMenu";
            this.btnUpdateMenu.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMenu.TabIndex = 4;
            this.btnUpdateMenu.Text = "Update";
            this.btnUpdateMenu.UseVisualStyleBackColor = true;
            this.btnUpdateMenu.Click += new System.EventHandler(this.btnUpdateMenu_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(110, 240);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 3;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(4, 268);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(100, 20);
            this.txtMenuName.TabIndex = 2;
            this.txtMenuName.TextChanged += new System.EventHandler(this.txtMenuName_TextChanged);
            // 
            // txtRestaurantIDinput
            // 
            this.txtRestaurantIDinput.Location = new System.Drawing.Point(4, 242);
            this.txtRestaurantIDinput.Name = "txtRestaurantIDinput";
            this.txtRestaurantIDinput.Size = new System.Drawing.Size(100, 20);
            this.txtRestaurantIDinput.TabIndex = 1;
            this.txtRestaurantIDinput.TextChanged += new System.EventHandler(this.txtRestaurantID_TextChanged);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.AutoGenerateColumns = false;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.restaurantIDDataGridViewTextBoxColumn3,
            this.menuNameDataGridViewTextBoxColumn});
            this.dataGridViewMenu.DataSource = this.menuBindingSource;
            this.dataGridViewMenu.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.Size = new System.Drawing.Size(762, 232);
            this.dataGridViewMenu.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.cbOrder);
            this.tabOrder.Controls.Add(this.btnSearchOrder);
            this.tabOrder.Controls.Add(this.btnDeleteOrder);
            this.tabOrder.Controls.Add(this.btnUpdateOrder);
            this.tabOrder.Controls.Add(this.btnAddOrder);
            this.tabOrder.Controls.Add(this.txtOrderStatus);
            this.tabOrder.Controls.Add(this.txtTotalAmount);
            this.tabOrder.Controls.Add(this.txtOrderDate);
            this.tabOrder.Controls.Add(this.txtOrderRestaurantID);
            this.tabOrder.Controls.Add(this.txtCustomerID);
            this.tabOrder.Controls.Add(this.dataGridViewOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(768, 400);
            this.tabOrder.TabIndex = 3;
            this.tabOrder.Text = "tabOrder";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // cbOrder
            // 
            this.cbOrder.DataSource = this.orderBindingSource;
            this.cbOrder.DisplayMember = "OrderID";
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(315, 238);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(121, 21);
            this.cbOrder.TabIndex = 10;
            this.cbOrder.ValueMember = "OrderID";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.restaurantDataSet;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(139, 267);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrder.TabIndex = 9;
            this.btnSearchOrder.Text = "Search ";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(442, 267);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(442, 237);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrder.TabIndex = 7;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(139, 238);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(3, 344);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(130, 20);
            this.txtOrderStatus.TabIndex = 5;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(3, 318);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(130, 20);
            this.txtTotalAmount.TabIndex = 4;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(3, 292);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(130, 20);
            this.txtOrderDate.TabIndex = 3;
            // 
            // txtOrderRestaurantID
            // 
            this.txtOrderRestaurantID.Location = new System.Drawing.Point(3, 266);
            this.txtOrderRestaurantID.Name = "txtOrderRestaurantID";
            this.txtOrderRestaurantID.Size = new System.Drawing.Size(130, 20);
            this.txtOrderRestaurantID.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(3, 240);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(130, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn1,
            this.restaurantIDDataGridViewTextBoxColumn2,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(762, 229);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // restaurantIDDataGridViewTextBoxColumn2
            // 
            this.restaurantIDDataGridViewTextBoxColumn2.DataPropertyName = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn2.HeaderText = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn2.Name = "restaurantIDDataGridViewTextBoxColumn2";
            this.restaurantIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabMenuItem
            // 
            this.tabMenuItem.Controls.Add(this.cbMenuItem);
            this.tabMenuItem.Controls.Add(this.btnDeleteMenuItem);
            this.tabMenuItem.Controls.Add(this.btnUpdateMenuItem);
            this.tabMenuItem.Controls.Add(this.btnSearchMenuItem);
            this.tabMenuItem.Controls.Add(this.btnAddMenuItem);
            this.tabMenuItem.Controls.Add(this.txtPrice);
            this.tabMenuItem.Controls.Add(this.txtDescription);
            this.tabMenuItem.Controls.Add(this.txtItemName);
            this.tabMenuItem.Controls.Add(this.txtMenuID);
            this.tabMenuItem.Controls.Add(this.dataGridViewMenuItem);
            this.tabMenuItem.Location = new System.Drawing.Point(4, 22);
            this.tabMenuItem.Name = "tabMenuItem";
            this.tabMenuItem.Size = new System.Drawing.Size(768, 400);
            this.tabMenuItem.TabIndex = 5;
            this.tabMenuItem.Text = "tabMenuItem";
            this.tabMenuItem.UseVisualStyleBackColor = true;
            // 
            // cbMenuItem
            // 
            this.cbMenuItem.DataSource = this.menuItemBindingSource;
            this.cbMenuItem.DisplayMember = "MenuItemID";
            this.cbMenuItem.FormattingEnabled = true;
            this.cbMenuItem.Location = new System.Drawing.Point(346, 221);
            this.cbMenuItem.Name = "cbMenuItem";
            this.cbMenuItem.Size = new System.Drawing.Size(121, 21);
            this.cbMenuItem.TabIndex = 9;
            this.cbMenuItem.ValueMember = "MenuItemID";
            // 
            // btnDeleteMenuItem
            // 
            this.btnDeleteMenuItem.Location = new System.Drawing.Point(473, 248);
            this.btnDeleteMenuItem.Name = "btnDeleteMenuItem";
            this.btnDeleteMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMenuItem.TabIndex = 8;
            this.btnDeleteMenuItem.Text = "Delete";
            this.btnDeleteMenuItem.UseVisualStyleBackColor = true;
            this.btnDeleteMenuItem.Click += new System.EventHandler(this.btnDeleteMenuItem_Click);
            // 
            // btnUpdateMenuItem
            // 
            this.btnUpdateMenuItem.Location = new System.Drawing.Point(473, 219);
            this.btnUpdateMenuItem.Name = "btnUpdateMenuItem";
            this.btnUpdateMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMenuItem.TabIndex = 7;
            this.btnUpdateMenuItem.Text = "Update";
            this.btnUpdateMenuItem.UseVisualStyleBackColor = true;
            this.btnUpdateMenuItem.Click += new System.EventHandler(this.btnUpdateMenuItem_Click);
            // 
            // btnSearchMenuItem
            // 
            this.btnSearchMenuItem.Location = new System.Drawing.Point(145, 248);
            this.btnSearchMenuItem.Name = "btnSearchMenuItem";
            this.btnSearchMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMenuItem.TabIndex = 6;
            this.btnSearchMenuItem.Text = "Search";
            this.btnSearchMenuItem.UseVisualStyleBackColor = true;
            this.btnSearchMenuItem.Click += new System.EventHandler(this.btnSearchMenuItem_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(145, 219);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenuItem.TabIndex = 5;
            this.btnAddMenuItem.Text = "Add";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(4, 297);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(4, 271);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(135, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(4, 245);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(135, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // txtMenuID
            // 
            this.txtMenuID.Location = new System.Drawing.Point(4, 219);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(135, 20);
            this.txtMenuID.TabIndex = 1;
            // 
            // dataGridViewMenuItem
            // 
            this.dataGridViewMenuItem.AllowUserToAddRows = false;
            this.dataGridViewMenuItem.AllowUserToDeleteRows = false;
            this.dataGridViewMenuItem.AutoGenerateColumns = false;
            this.dataGridViewMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemIDDataGridViewTextBoxColumn1,
            this.menuIDDataGridViewTextBoxColumn1,
            this.itemNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewMenuItem.DataSource = this.menuItemBindingSource;
            this.dataGridViewMenuItem.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewMenuItem.Name = "dataGridViewMenuItem";
            this.dataGridViewMenuItem.ReadOnly = true;
            this.dataGridViewMenuItem.Size = new System.Drawing.Size(761, 209);
            this.dataGridViewMenuItem.TabIndex = 0;
            // 
            // tabOrderItem
            // 
            this.tabOrderItem.Controls.Add(this.cbOrderItem);
            this.tabOrderItem.Controls.Add(this.btnSearchOrderItem);
            this.tabOrderItem.Controls.Add(this.btnDeleteOrderItem);
            this.tabOrderItem.Controls.Add(this.btnUpdateOrderItem);
            this.tabOrderItem.Controls.Add(this.btnAddOrderItem);
            this.tabOrderItem.Controls.Add(this.txtItemPrice);
            this.tabOrderItem.Controls.Add(this.txtQuantity);
            this.tabOrderItem.Controls.Add(this.txtMenuItemID);
            this.tabOrderItem.Controls.Add(this.txtOrderID);
            this.tabOrderItem.Controls.Add(this.dataGridViewOrderItem);
            this.tabOrderItem.Location = new System.Drawing.Point(4, 22);
            this.tabOrderItem.Name = "tabOrderItem";
            this.tabOrderItem.Size = new System.Drawing.Size(768, 400);
            this.tabOrderItem.TabIndex = 4;
            this.tabOrderItem.Text = "tabOrderItem";
            this.tabOrderItem.UseVisualStyleBackColor = true;
            // 
            // cbOrderItem
            // 
            this.cbOrderItem.DataSource = this.orderItemBindingSource;
            this.cbOrderItem.DisplayMember = "OrderItemID";
            this.cbOrderItem.FormattingEnabled = true;
            this.cbOrderItem.Location = new System.Drawing.Point(288, 249);
            this.cbOrderItem.Name = "cbOrderItem";
            this.cbOrderItem.Size = new System.Drawing.Size(121, 21);
            this.cbOrderItem.TabIndex = 9;
            this.cbOrderItem.ValueMember = "OrderItemID";
            // 
            // btnSearchOrderItem
            // 
            this.btnSearchOrderItem.Location = new System.Drawing.Point(161, 273);
            this.btnSearchOrderItem.Name = "btnSearchOrderItem";
            this.btnSearchOrderItem.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrderItem.TabIndex = 8;
            this.btnSearchOrderItem.Text = "Search ";
            this.btnSearchOrderItem.UseVisualStyleBackColor = true;
            this.btnSearchOrderItem.Click += new System.EventHandler(this.btnSearchOrderItem_Click);
            // 
            // btnDeleteOrderItem
            // 
            this.btnDeleteOrderItem.Location = new System.Drawing.Point(415, 276);
            this.btnDeleteOrderItem.Name = "btnDeleteOrderItem";
            this.btnDeleteOrderItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrderItem.TabIndex = 7;
            this.btnDeleteOrderItem.Text = "Delete";
            this.btnDeleteOrderItem.UseVisualStyleBackColor = true;
            this.btnDeleteOrderItem.Click += new System.EventHandler(this.btnDeleteOrderItem_Click);
            // 
            // btnUpdateOrderItem
            // 
            this.btnUpdateOrderItem.Location = new System.Drawing.Point(415, 247);
            this.btnUpdateOrderItem.Name = "btnUpdateOrderItem";
            this.btnUpdateOrderItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrderItem.TabIndex = 6;
            this.btnUpdateOrderItem.Text = "Update";
            this.btnUpdateOrderItem.UseVisualStyleBackColor = true;
            this.btnUpdateOrderItem.Click += new System.EventHandler(this.btnUpdateOrderItem_Click);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Location = new System.Drawing.Point(161, 247);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrderItem.TabIndex = 5;
            this.btnAddOrderItem.Text = "Add";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(3, 325);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(152, 20);
            this.txtItemPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(3, 299);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(152, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtMenuItemID
            // 
            this.txtMenuItemID.Location = new System.Drawing.Point(3, 273);
            this.txtMenuItemID.Name = "txtMenuItemID";
            this.txtMenuItemID.Size = new System.Drawing.Size(152, 20);
            this.txtMenuItemID.TabIndex = 2;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(3, 247);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(152, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // dataGridViewOrderItem
            // 
            this.dataGridViewOrderItem.AllowUserToAddRows = false;
            this.dataGridViewOrderItem.AllowUserToDeleteRows = false;
            this.dataGridViewOrderItem.AutoGenerateColumns = false;
            this.dataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn1,
            this.menuItemIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrderItem.DataSource = this.orderItemBindingSource;
            this.dataGridViewOrderItem.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrderItem.Name = "dataGridViewOrderItem";
            this.dataGridViewOrderItem.ReadOnly = true;
            this.dataGridViewOrderItem.Size = new System.Drawing.Size(762, 238);
            this.dataGridViewOrderItem.TabIndex = 0;
            // 
            // orderItemIDDataGridViewTextBoxColumn
            // 
            this.orderItemIDDataGridViewTextBoxColumn.DataPropertyName = "OrderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.HeaderText = "OrderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.Name = "orderItemIDDataGridViewTextBoxColumn";
            this.orderItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // menuItemIDDataGridViewTextBoxColumn
            // 
            this.menuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.Name = "menuItemIDDataGridViewTextBoxColumn";
            this.menuItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "OrderItem";
            this.orderItemBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantTableAdapter
            // 
            this.restaurantTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.restaurantDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restaurantIDDataGridViewTextBoxColumn3
            // 
            this.restaurantIDDataGridViewTextBoxColumn3.DataPropertyName = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn3.HeaderText = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn3.Name = "restaurantIDDataGridViewTextBoxColumn3";
            this.restaurantIDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            this.menuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.HeaderText = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            this.menuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuItemBindingSource
            // 
            this.menuItemBindingSource.DataMember = "MenuItem";
            this.menuItemBindingSource.DataSource = this.restaurantDataSet;
            // 
            // menuItemTableAdapter
            // 
            this.menuItemTableAdapter.ClearBeforeFill = true;
            // 
            // menuItemIDDataGridViewTextBoxColumn1
            // 
            this.menuItemIDDataGridViewTextBoxColumn1.DataPropertyName = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn1.HeaderText = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn1.Name = "menuItemIDDataGridViewTextBoxColumn1";
            this.menuItemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // menuIDDataGridViewTextBoxColumn1
            // 
            this.menuIDDataGridViewTextBoxColumn1.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn1.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn1.Name = "menuIDDataGridViewTextBoxColumn1";
            this.menuIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabRestaurant.ResumeLayout(false);
            this.tabRestaurant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.tabMenuItem.ResumeLayout(false);
            this.tabMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItem)).EndInit();
            this.tabOrderItem.ResumeLayout(false);
            this.tabOrderItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabRestaurant;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dataGridViewRestaurant;
        private System.Windows.Forms.TextBox txtRestaurantEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.Button btnDeleteRestaurant;
        private System.Windows.Forms.Button btnSearchRestaurant;
        private System.Windows.Forms.Button btnUpdateRestaurant;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtRestaurantIDinput;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnSearchMenu;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderRestaurantID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TabPage tabOrderItem;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtMenuItemID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridView dataGridViewOrderItem;
        private System.Windows.Forms.Button btnSearchOrderItem;
        private System.Windows.Forms.Button btnDeleteOrderItem;
        private System.Windows.Forms.Button btnUpdateOrderItem;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantIDDataGridViewTextBoxColumn1;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private RestaurantDataSetTableAdapters.RestaurantTableAdapter restaurantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private RestaurantDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RestaurantDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private RestaurantDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbRestaurant;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.ComboBox cbOrderItem;
        private System.Windows.Forms.TabPage tabMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMenuItem;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtMenuID;
        private System.Windows.Forms.ComboBox cbMenuItem;
        private System.Windows.Forms.Button btnDeleteMenuItem;
        private System.Windows.Forms.Button btnUpdateMenuItem;
        private System.Windows.Forms.Button btnSearchMenuItem;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private RestaurantDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource menuItemBindingSource;
        private RestaurantDataSetTableAdapters.MenuItemTableAdapter menuItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

