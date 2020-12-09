namespace Пошив_и_ремонт_одежды
{
    partial class Вход_в_программу
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Вход_в_программу));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Klient = new System.Windows.Forms.TabPage();
            this.clientFilterTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.labelSortingCustomers = new System.Windows.Forms.Label();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пошив_и_ремонт_одеждыDataSet = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet();
            this.Orders = new System.Windows.Forms.TabPage();
            this.readyOrdersFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.orderFilterTextBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderSearchLabel = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.готовыеЗаказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.ПользователиTableAdapter();
            this.заказы_с_клиентамиTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.вид_работTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter();
            this.тип_одеждыTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter();
            this.Email = new System.Windows.Forms.TabPage();
            this.tabControlEmail = new System.Windows.Forms.TabControl();
            this.Incoming = new System.Windows.Forms.TabPage();
            this.Outgoing = new System.Windows.Forms.TabPage();
            this.Sent = new System.Windows.Forms.TabPage();
            this.Basket = new System.Windows.Forms.TabPage();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.textBoxWhom = new System.Windows.Forms.TextBox();
            this.labelWhom = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAttachFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Klient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеЗаказыСКлиентамиBindingSource)).BeginInit();
            this.Email.SuspendLayout();
            this.tabControlEmail.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Klient);
            this.tabControl.Controls.Add(this.Orders);
            this.tabControl.Controls.Add(this.Email);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(659, 649);
            this.tabControl.TabIndex = 0;
            // 
            // Klient
            // 
            this.Klient.Controls.Add(this.clientFilterTextBox);
            this.Klient.Controls.Add(this.addClientButton);
            this.Klient.Controls.Add(this.labelSortingCustomers);
            this.Klient.Controls.Add(this.dataGridViewClient);
            this.Klient.Location = new System.Drawing.Point(4, 22);
            this.Klient.Name = "Klient";
            this.Klient.Padding = new System.Windows.Forms.Padding(3);
            this.Klient.Size = new System.Drawing.Size(651, 623);
            this.Klient.TabIndex = 0;
            this.Klient.Text = "Клиент";
            this.Klient.UseVisualStyleBackColor = true;
            // 
            // clientFilterTextBox
            // 
            this.clientFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientFilterTextBox.Location = new System.Drawing.Point(0, 19);
            this.clientFilterTextBox.Multiline = true;
            this.clientFilterTextBox.Name = "clientFilterTextBox";
            this.clientFilterTextBox.Size = new System.Drawing.Size(648, 38);
            this.clientFilterTextBox.TabIndex = 1;
            this.clientFilterTextBox.TextChanged += new System.EventHandler(this.clientFilterTextBox_TextChanged);
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientButton.Location = new System.Drawing.Point(44, 63);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(567, 39);
            this.addClientButton.TabIndex = 4;
            this.addClientButton.Text = "Добавить нового клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSortingCustomers
            // 
            this.labelSortingCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingCustomers.Location = new System.Drawing.Point(3, 3);
            this.labelSortingCustomers.Name = "labelSortingCustomers";
            this.labelSortingCustomers.Size = new System.Drawing.Size(134, 23);
            this.labelSortingCustomers.TabIndex = 3;
            this.labelSortingCustomers.Text = "Поиск клиентов";
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.пользователиBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(3, 108);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(645, 512);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellEndEdit);
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пошив_и_ремонт_одеждыDataSet
            // 
            this.пошив_и_ремонт_одеждыDataSet.DataSetName = "пошив_и_ремонт_одеждыDataSet";
            this.пошив_и_ремонт_одеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.readyOrdersFilterCheckBox);
            this.Orders.Controls.Add(this.orderFilterTextBox);
            this.Orders.Controls.Add(this.addOrderButton);
            this.Orders.Controls.Add(this.orderSearchLabel);
            this.Orders.Controls.Add(this.dataGridViewOrder);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(651, 623);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // readyOrdersFilterCheckBox
            // 
            this.readyOrdersFilterCheckBox.AutoSize = true;
            this.readyOrdersFilterCheckBox.Checked = true;
            this.readyOrdersFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.readyOrdersFilterCheckBox.Location = new System.Drawing.Point(8, 55);
            this.readyOrdersFilterCheckBox.Name = "readyOrdersFilterCheckBox";
            this.readyOrdersFilterCheckBox.Size = new System.Drawing.Size(164, 17);
            this.readyOrdersFilterCheckBox.TabIndex = 7;
            this.readyOrdersFilterCheckBox.Text = "Отображаются все заказы";
            this.readyOrdersFilterCheckBox.ThreeState = true;
            this.readyOrdersFilterCheckBox.UseVisualStyleBackColor = true;
            this.readyOrdersFilterCheckBox.CheckStateChanged += new System.EventHandler(this.readyOrdersFilterCheckBox_CheckStateChanged);
            // 
            // orderFilterTextBox
            // 
            this.orderFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFilterTextBox.Location = new System.Drawing.Point(5, 19);
            this.orderFilterTextBox.Name = "orderFilterTextBox";
            this.orderFilterTextBox.Size = new System.Drawing.Size(643, 30);
            this.orderFilterTextBox.TabIndex = 4;
            this.orderFilterTextBox.TextChanged += new System.EventHandler(this.orderFilterTextBox_TextChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(42, 78);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(567, 34);
            this.addOrderButton.TabIndex = 6;
            this.addOrderButton.Text = "Добавить новый заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // orderSearchLabel
            // 
            this.orderSearchLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSearchLabel.Location = new System.Drawing.Point(8, 3);
            this.orderSearchLabel.Name = "orderSearchLabel";
            this.orderSearchLabel.Size = new System.Drawing.Size(129, 23);
            this.orderSearchLabel.TabIndex = 5;
            this.orderSearchLabel.Text = "Поиск заказов";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.workKindDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ценаDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridViewOrder.DataSource = this.заказыСКлиентамиBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 118);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(645, 502);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReadyOrders_CellEndEdit);
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.FillWeight = 200F;
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workKindDataGridViewTextBoxColumn
            // 
            this.workKindDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.workKindDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.workKindDataGridViewTextBoxColumn.Name = "workKindDataGridViewTextBoxColumn";
            this.workKindDataGridViewTextBoxColumn.ReadOnly = true;
            this.workKindDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип одежды";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип одежды";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Заказ готов";
            this.dataGridViewCheckBoxColumn1.FillWeight = 90F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Заказ готов";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // заказыСКлиентамиBindingSource
            // 
            this.заказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.заказыСКлиентамиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // видРаботBindingSource
            // 
            this.видРаботBindingSource.DataMember = "Вид работ";
            this.видРаботBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // типОдеждыBindingSource
            // 
            this.типОдеждыBindingSource.DataMember = "Тип одежды";
            this.типОдеждыBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // готовыеЗаказыСКлиентамиBindingSource
            // 
            this.готовыеЗаказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.готовыеЗаказыСКлиентамиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // заказы_с_клиентамиTableAdapter
            // 
            this.заказы_с_клиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // вид_работTableAdapter
            // 
            this.вид_работTableAdapter.ClearBeforeFill = true;
            // 
            // тип_одеждыTableAdapter
            // 
            this.тип_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // Email
            // 
            this.Email.Controls.Add(this.tabControlEmail);
            this.Email.Location = new System.Drawing.Point(4, 22);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(651, 623);
            this.Email.TabIndex = 2;
            this.Email.Text = "Почта";
            this.Email.UseVisualStyleBackColor = true;
            // 
            // tabControlEmail
            // 
            this.tabControlEmail.Controls.Add(this.WriteLetter);
            this.tabControlEmail.Controls.Add(this.Incoming);
            this.tabControlEmail.Controls.Add(this.Outgoing);
            this.tabControlEmail.Controls.Add(this.Sent);
            this.tabControlEmail.Controls.Add(this.Basket);
            this.tabControlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmail.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmail.Name = "tabControlEmail";
            this.tabControlEmail.SelectedIndex = 0;
            this.tabControlEmail.Size = new System.Drawing.Size(651, 623);
            this.tabControlEmail.TabIndex = 0;
            // 
            // Incoming
            // 
            this.Incoming.Location = new System.Drawing.Point(4, 22);
            this.Incoming.Name = "Incoming";
            this.Incoming.Padding = new System.Windows.Forms.Padding(3);
            this.Incoming.Size = new System.Drawing.Size(643, 597);
            this.Incoming.TabIndex = 0;
            this.Incoming.Text = "Входящие";
            this.Incoming.UseVisualStyleBackColor = true;
            // 
            // Outgoing
            // 
            this.Outgoing.Location = new System.Drawing.Point(4, 22);
            this.Outgoing.Name = "Outgoing";
            this.Outgoing.Padding = new System.Windows.Forms.Padding(3);
            this.Outgoing.Size = new System.Drawing.Size(643, 597);
            this.Outgoing.TabIndex = 1;
            this.Outgoing.Text = "Исходящие";
            this.Outgoing.UseVisualStyleBackColor = true;
            // 
            // Sent
            // 
            this.Sent.Location = new System.Drawing.Point(4, 22);
            this.Sent.Name = "Sent";
            this.Sent.Size = new System.Drawing.Size(643, 597);
            this.Sent.TabIndex = 2;
            this.Sent.Text = "Отправленные";
            this.Sent.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(4, 22);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(643, 597);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.button1);
            this.WriteLetter.Controls.Add(this.textBoxLetter);
            this.WriteLetter.Controls.Add(this.label1);
            this.WriteLetter.Controls.Add(this.labelSubject);
            this.WriteLetter.Controls.Add(this.labelWhom);
            this.WriteLetter.Controls.Add(this.textBoxAttachFile);
            this.WriteLetter.Controls.Add(this.textBoxSubject);
            this.WriteLetter.Controls.Add(this.textBoxWhom);
            this.WriteLetter.Location = new System.Drawing.Point(4, 22);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(643, 597);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // textBoxWhom
            // 
            this.textBoxWhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWhom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWhom.Location = new System.Drawing.Point(3, 16);
            this.textBoxWhom.Multiline = true;
            this.textBoxWhom.Name = "textBoxWhom";
            this.textBoxWhom.Size = new System.Drawing.Size(636, 27);
            this.textBoxWhom.TabIndex = 0;
            // 
            // labelWhom
            // 
            this.labelWhom.AutoSize = true;
            this.labelWhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(4, 0);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(39, 13);
            this.labelWhom.TabIndex = 1;
            this.labelWhom.Text = "Кому:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSubject.Location = new System.Drawing.Point(4, 66);
            this.textBoxSubject.Multiline = true;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(636, 27);
            this.textBoxSubject.TabIndex = 0;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(5, 50);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(39, 13);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Тема:";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLetter.Location = new System.Drawing.Point(8, 160);
            this.textBoxLetter.Multiline = true;
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(631, 383);
            this.textBoxLetter.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(260, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxAttachFile
            // 
            this.textBoxAttachFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAttachFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAttachFile.Location = new System.Drawing.Point(4, 115);
            this.textBoxAttachFile.Multiline = true;
            this.textBoxAttachFile.Name = "textBoxAttachFile";
            this.textBoxAttachFile.Size = new System.Drawing.Size(636, 27);
            this.textBoxAttachFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прикрепить файл:";
            // 
            // Вход_в_программу
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 649);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Вход_в_программу";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в программу";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Вход_в_программу_Load);
            this.tabControl.ResumeLayout(false);
            this.Klient.ResumeLayout(false);
            this.Klient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеЗаказыСКлиентамиBindingSource)).EndInit();
            this.Email.ResumeLayout(false);
            this.tabControlEmail.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Klient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TabPage Orders;
        private пошив_и_ремонт_одеждыDataSet пошив_и_ремонт_одеждыDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private System.Windows.Forms.TextBox clientFilterTextBox;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelSortingCustomers;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox orderFilterTextBox;
        private System.Windows.Forms.Label orderSearchLabel;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.BindingSource заказыСКлиентамиBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.BindingSource готовыеЗаказыСКлиентамиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource видРаботBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter вид_работTableAdapter;
        private System.Windows.Forms.BindingSource типОдеждыBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter тип_одеждыTableAdapter;
        private System.Windows.Forms.CheckBox readyOrdersFilterCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage Email;
        private System.Windows.Forms.TabControl tabControlEmail;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.TextBox textBoxAttachFile;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxWhom;
        private System.Windows.Forms.TabPage Incoming;
        private System.Windows.Forms.TabPage Outgoing;
        private System.Windows.Forms.TabPage Sent;
        private System.Windows.Forms.TabPage Basket;
    }
}