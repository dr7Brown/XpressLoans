namespace XpressLoan.Forms
{
    partial class FormReports
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
            System.Windows.Forms.Label depositIDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label expensesIDLabel;
            System.Windows.Forms.Label amountLabel1;
            System.Windows.Forms.Label purposeLabel;
            System.Windows.Forms.Label dateLabel1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tblDepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpressLoanDBDataSet = new XpressLoan.XpressLoanDBDataSet();
            this.btnSaveDeposit = new System.Windows.Forms.Button();
            this.depositIDTextBox = new System.Windows.Forms.TextBox();
            this.depAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.depDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tblDepositDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.expAmountNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tblExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveExpenses = new System.Windows.Forms.Button();
            this.expensesIDTextBox = new System.Windows.Forms.TextBox();
            this.expPurposeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.expDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tblExpensesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDepositTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblDepositTableAdapter();
            this.tableAdapterManager = new XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager();
            this.tblExpensesTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblExpensesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblUsersTableAdapter();
            this.tblUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            depositIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            expensesIDLabel = new System.Windows.Forms.Label();
            amountLabel1 = new System.Windows.Forms.Label();
            purposeLabel = new System.Windows.Forms.Label();
            dateLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depAmountNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositDataGridView)).BeginInit();
            this.tabExpenses.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expAmountNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // depositIDLabel
            // 
            depositIDLabel.AutoSize = true;
            depositIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            depositIDLabel.Location = new System.Drawing.Point(18, 75);
            depositIDLabel.Name = "depositIDLabel";
            depositIDLabel.Size = new System.Drawing.Size(119, 25);
            depositIDLabel.TabIndex = 0;
            depositIDLabel.Text = "Deposit ID:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amountLabel.Location = new System.Drawing.Point(18, 130);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(93, 25);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(18, 202);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(64, 25);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(18, 295);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(127, 25);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description:";
            // 
            // expensesIDLabel
            // 
            expensesIDLabel.AutoSize = true;
            expensesIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expensesIDLabel.Location = new System.Drawing.Point(36, 84);
            expensesIDLabel.Name = "expensesIDLabel";
            expensesIDLabel.Size = new System.Drawing.Size(141, 25);
            expensesIDLabel.TabIndex = 0;
            expensesIDLabel.Text = "Expenses ID:";
            // 
            // amountLabel1
            // 
            amountLabel1.AutoSize = true;
            amountLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amountLabel1.Location = new System.Drawing.Point(36, 139);
            amountLabel1.Name = "amountLabel1";
            amountLabel1.Size = new System.Drawing.Size(93, 25);
            amountLabel1.TabIndex = 2;
            amountLabel1.Text = "Amount:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purposeLabel.Location = new System.Drawing.Point(36, 197);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new System.Drawing.Size(99, 25);
            purposeLabel.TabIndex = 4;
            purposeLabel.Text = "Purpose:";
            // 
            // dateLabel1
            // 
            dateLabel1.AutoSize = true;
            dateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel1.Location = new System.Drawing.Point(36, 315);
            dateLabel1.Name = "dateLabel1";
            dateLabel1.Size = new System.Drawing.Size(64, 25);
            dateLabel1.TabIndex = 6;
            dateLabel1.Text = "Date:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 747);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDeposit);
            this.tabControl1.Controls.Add(this.tabExpenses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 34);
            this.tabControl1.Location = new System.Drawing.Point(3, 203);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 541);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabDeposit
            // 
            this.tabDeposit.Controls.Add(this.tableLayoutPanel2);
            this.tabDeposit.Location = new System.Drawing.Point(4, 38);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(1208, 499);
            this.tabDeposit.TabIndex = 0;
            this.tabDeposit.Text = "Deposit";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1202, 493);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.depDescriptionRichTextBox);
            this.panel1.Controls.Add(this.btnSaveDeposit);
            this.panel1.Controls.Add(this.depositIDTextBox);
            this.panel1.Controls.Add(this.depAmountNumericUpDown);
            this.panel1.Controls.Add(this.depDateTimePicker);
            this.panel1.Controls.Add(depositIDLabel);
            this.panel1.Controls.Add(amountLabel);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(705, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 487);
            this.panel1.TabIndex = 1;
            // 
            // depDescriptionRichTextBox
            // 
            this.depDescriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositBindingSource, "Description", true));
            this.depDescriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDescriptionRichTextBox.Location = new System.Drawing.Point(163, 286);
            this.depDescriptionRichTextBox.Name = "depDescriptionRichTextBox";
            this.depDescriptionRichTextBox.Size = new System.Drawing.Size(272, 96);
            this.depDescriptionRichTextBox.TabIndex = 20;
            this.depDescriptionRichTextBox.Text = "";
            this.depDescriptionRichTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionRichTextBox_Validating);
            // 
            // tblDepositBindingSource
            // 
            this.tblDepositBindingSource.DataMember = "tblDeposit";
            this.tblDepositBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // xpressLoanDBDataSet
            // 
            this.xpressLoanDBDataSet.DataSetName = "XpressLoanDBDataSet";
            this.xpressLoanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveDeposit
            // 
            this.btnSaveDeposit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDeposit.Location = new System.Drawing.Point(293, 416);
            this.btnSaveDeposit.Name = "btnSaveDeposit";
            this.btnSaveDeposit.Size = new System.Drawing.Size(142, 54);
            this.btnSaveDeposit.TabIndex = 18;
            this.btnSaveDeposit.Text = "Save";
            this.btnSaveDeposit.UseVisualStyleBackColor = false;
            this.btnSaveDeposit.Click += new System.EventHandler(this.btnSaveDeposit_Click);
            // 
            // depositIDTextBox
            // 
            this.depositIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositBindingSource, "DepositID", true));
            this.depositIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositIDTextBox.Location = new System.Drawing.Point(163, 72);
            this.depositIDTextBox.Name = "depositIDTextBox";
            this.depositIDTextBox.ReadOnly = true;
            this.depositIDTextBox.Size = new System.Drawing.Size(272, 30);
            this.depositIDTextBox.TabIndex = 9;
            // 
            // depAmountNumericUpDown
            // 
            this.depAmountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDepositBindingSource, "Amount", true));
            this.depAmountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depAmountNumericUpDown.Location = new System.Drawing.Point(163, 127);
            this.depAmountNumericUpDown.Maximum = new decimal(new int[] {
            99989999,
            0,
            0,
            0});
            this.depAmountNumericUpDown.Name = "depAmountNumericUpDown";
            this.depAmountNumericUpDown.Size = new System.Drawing.Size(272, 30);
            this.depAmountNumericUpDown.TabIndex = 11;
            this.depAmountNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.amountNumericUpDown_Validating);
            // 
            // depDateTimePicker
            // 
            this.depDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.depDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDepositBindingSource, "Date", true));
            this.depDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depDateTimePicker.Location = new System.Drawing.Point(163, 199);
            this.depDateTimePicker.Name = "depDateTimePicker";
            this.depDateTimePicker.Size = new System.Drawing.Size(272, 30);
            this.depDateTimePicker.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 487);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tblDepositDataGridView, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(696, 487);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tblDepositDataGridView
            // 
            this.tblDepositDataGridView.AutoGenerateColumns = false;
            this.tblDepositDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDepositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDepositDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tblDepositDataGridView.DataSource = this.tblDepositBindingSource;
            this.tblDepositDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDepositDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tblDepositDataGridView.Name = "tblDepositDataGridView";
            this.tblDepositDataGridView.RowHeadersWidth = 51;
            this.tblDepositDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tblDepositDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDepositDataGridView.RowTemplate.Height = 24;
            this.tblDepositDataGridView.Size = new System.Drawing.Size(690, 481);
            this.tblDepositDataGridView.TabIndex = 0;
            this.tblDepositDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDepositDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepositID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DepositID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.tableLayoutPanel3);
            this.tabExpenses.Location = new System.Drawing.Point(4, 38);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(1208, 499);
            this.tabExpenses.TabIndex = 1;
            this.tabExpenses.Text = "Expenses";
            this.tabExpenses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1202, 493);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.expAmountNumericUpDown1);
            this.panel4.Controls.Add(this.btnSaveExpenses);
            this.panel4.Controls.Add(expensesIDLabel);
            this.panel4.Controls.Add(this.expensesIDTextBox);
            this.panel4.Controls.Add(amountLabel1);
            this.panel4.Controls.Add(purposeLabel);
            this.panel4.Controls.Add(this.expPurposeRichTextBox);
            this.panel4.Controls.Add(dateLabel1);
            this.panel4.Controls.Add(this.expDatePicker);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(705, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 487);
            this.panel4.TabIndex = 1;
            // 
            // expAmountNumericUpDown1
            // 
            this.expAmountNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblExpensesBindingSource, "Amount", true));
            this.expAmountNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAmountNumericUpDown1.Location = new System.Drawing.Point(193, 144);
            this.expAmountNumericUpDown1.Name = "expAmountNumericUpDown1";
            this.expAmountNumericUpDown1.Size = new System.Drawing.Size(273, 30);
            this.expAmountNumericUpDown1.TabIndex = 11;
            // 
            // tblExpensesBindingSource
            // 
            this.tblExpensesBindingSource.DataMember = "tblExpenses";
            this.tblExpensesBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // btnSaveExpenses
            // 
            this.btnSaveExpenses.BackColor = System.Drawing.Color.Salmon;
            this.btnSaveExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveExpenses.Location = new System.Drawing.Point(342, 420);
            this.btnSaveExpenses.Name = "btnSaveExpenses";
            this.btnSaveExpenses.Size = new System.Drawing.Size(124, 58);
            this.btnSaveExpenses.TabIndex = 10;
            this.btnSaveExpenses.Text = "Save";
            this.btnSaveExpenses.UseVisualStyleBackColor = false;
            this.btnSaveExpenses.Click += new System.EventHandler(this.btnSaveExpenses_Click);
            // 
            // expensesIDTextBox
            // 
            this.expensesIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExpensesBindingSource, "ExpensesID", true));
            this.expensesIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesIDTextBox.Location = new System.Drawing.Point(193, 84);
            this.expensesIDTextBox.Name = "expensesIDTextBox";
            this.expensesIDTextBox.ReadOnly = true;
            this.expensesIDTextBox.Size = new System.Drawing.Size(273, 30);
            this.expensesIDTextBox.TabIndex = 1;
            // 
            // expPurposeRichTextBox
            // 
            this.expPurposeRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExpensesBindingSource, "Purpose", true));
            this.expPurposeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expPurposeRichTextBox.Location = new System.Drawing.Point(193, 194);
            this.expPurposeRichTextBox.Name = "expPurposeRichTextBox";
            this.expPurposeRichTextBox.Size = new System.Drawing.Size(273, 96);
            this.expPurposeRichTextBox.TabIndex = 5;
            this.expPurposeRichTextBox.Text = "";
            // 
            // expDatePicker
            // 
            this.expDatePicker.CustomFormat = "yyyy-MM-dd";
            this.expDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblExpensesBindingSource, "Date", true));
            this.expDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expDatePicker.Location = new System.Drawing.Point(193, 315);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(273, 30);
            this.expDatePicker.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 487);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tblExpensesDataGridView, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 487F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(696, 487);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tblExpensesDataGridView
            // 
            this.tblExpensesDataGridView.AutoGenerateColumns = false;
            this.tblExpensesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblExpensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblExpensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tblExpensesDataGridView.DataSource = this.tblExpensesBindingSource;
            this.tblExpensesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExpensesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tblExpensesDataGridView.Name = "tblExpensesDataGridView";
            this.tblExpensesDataGridView.RowHeadersWidth = 51;
            this.tblExpensesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tblExpensesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblExpensesDataGridView.RowTemplate.Height = 24;
            this.tblExpensesDataGridView.Size = new System.Drawing.Size(690, 481);
            this.tblExpensesDataGridView.TabIndex = 0;
            this.tblExpensesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblExpensesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExpensesID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ExpensesID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Purpose";
            this.dataGridViewTextBoxColumn8.HeaderText = "Purpose";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn10.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tblDepositTableAdapter
            // 
            this.tblDepositTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAccountTableAdapter = null;
            this.tableAdapterManager.tblApplicationsTableAdapter = null;
            this.tableAdapterManager.tblCustomersTableAdapter = null;
            this.tableAdapterManager.tblDepositTableAdapter = this.tblDepositTableAdapter;
            this.tableAdapterManager.tblExpensesTableAdapter = this.tblExpensesTableAdapter;
            this.tableAdapterManager.tblLoansTableAdapter = null;
            this.tableAdapterManager.tblRepaymentTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblExpensesTableAdapter
            // 
            this.tblExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersBindingSource1
            // 
            this.tblUsersBindingSource1.DataMember = "tblUsers";
            this.tblUsersBindingSource1.DataSource = this.xpressLoanDBDataSet;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 747);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDeposit.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depAmountNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositDataGridView)).EndInit();
            this.tabExpenses.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expAmountNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabExpenses;
        private XpressLoanDBDataSet xpressLoanDBDataSet;
        private System.Windows.Forms.BindingSource tblDepositBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblDepositTableAdapter tblDepositTableAdapter;
        private XpressLoanDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox depDescriptionRichTextBox;
        private System.Windows.Forms.Button btnSaveDeposit;
        private System.Windows.Forms.TextBox depositIDTextBox;
        private System.Windows.Forms.NumericUpDown depAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker depDateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tblDepositDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private XpressLoanDBDataSetTableAdapters.tblExpensesTableAdapter tblExpensesTableAdapter;
        private System.Windows.Forms.BindingSource tblExpensesBindingSource;
        private System.Windows.Forms.Button btnSaveExpenses;
        private System.Windows.Forms.TextBox expensesIDTextBox;
        private System.Windows.Forms.RichTextBox expPurposeRichTextBox;
        private System.Windows.Forms.DateTimePicker expDatePicker;
        private System.Windows.Forms.DataGridView tblExpensesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown expAmountNumericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource1;
    }
}