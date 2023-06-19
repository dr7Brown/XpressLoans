using System.Windows.Forms;

namespace XpressLoan.Forms
{
    partial class FormUserDetails
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label idNumberLabel;
            System.Windows.Forms.Label idTypeLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRw = new System.Windows.Forms.Panel();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.txtTextCount = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnEdit = new System.Windows.Forms.Button();
            this.idTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tblCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpressLoanDBDataSet = new XpressLoan.XpressLoanDBDataSet();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.btnRequestLoan = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.txtAccounNum = new System.Windows.Forms.TextBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.loanMetroTab = new MetroFramework.Controls.MetroTabPage();
            this.tblLoansDataGridView = new System.Windows.Forms.DataGridView();
            this.repaymentMetroTab = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintSchedule = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxLoans = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblRepaymentDataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxTransLoans = new System.Windows.Forms.ComboBox();
            this.btnPrintStmt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repaymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repaymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRepaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRepaymentTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblRepaymentTableAdapter();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager();
            this.tblCustomersTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblCustomersTableAdapter();
            this.tblLoansTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblLoansTableAdapter();
            this.tblRepaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.ckbxEnableStatus = new System.Windows.Forms.CheckBox();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            idNumberLabel = new System.Windows.Forms.Label();
            idTypeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelTopRw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.loanMetroTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansDataGridView)).BeginInit();
            this.repaymentMetroTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentDataGridView1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(228, 61);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(40, 25);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(224, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(624, 82);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(90, 25);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(227, 103);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(81, 25);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // idNumberLabel
            // 
            idNumberLabel.AutoSize = true;
            idNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNumberLabel.Location = new System.Drawing.Point(625, 183);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new System.Drawing.Size(121, 25);
            idNumberLabel.TabIndex = 8;
            idNumberLabel.Text = "ID Number:";
            // 
            // idTypeLabel
            // 
            idTypeLabel.AutoSize = true;
            idTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTypeLabel.Location = new System.Drawing.Point(623, 127);
            idTypeLabel.Name = "idTypeLabel";
            idTypeLabel.Size = new System.Drawing.Size(95, 25);
            idTypeLabel.TabIndex = 10;
            idTypeLabel.Text = "ID Type:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(222, 155);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(99, 25);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 25);
            label2.TabIndex = 12;
            label2.Text = "Select Loan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(625, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 25);
            label1.TabIndex = 4;
            label1.Text = "Account No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 25);
            label3.TabIndex = 12;
            label3.Text = "Select Loan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1295, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelTopRw, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1289, 243);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panelTopRw
            // 
            this.panelTopRw.AutoScroll = true;
            this.panelTopRw.Controls.Add(this.pbProfile);
            this.panelTopRw.Controls.Add(this.txtTextCount);
            this.panelTopRw.Controls.Add(this.progressBar1);
            this.panelTopRw.Controls.Add(this.btnEdit);
            this.panelTopRw.Controls.Add(this.idTypeComboBox);
            this.panelTopRw.Controls.Add(idTypeLabel);
            this.panelTopRw.Controls.Add(this.addressTextBox);
            this.panelTopRw.Controls.Add(this.btnRequestLoan);
            this.panelTopRw.Controls.Add(this.genderComboBox);
            this.panelTopRw.Controls.Add(customerIDLabel);
            this.panelTopRw.Controls.Add(this.customerIDTextBox);
            this.panelTopRw.Controls.Add(nameLabel);
            this.panelTopRw.Controls.Add(this.nameTextBox);
            this.panelTopRw.Controls.Add(label1);
            this.panelTopRw.Controls.Add(genderLabel);
            this.panelTopRw.Controls.Add(phoneLabel);
            this.panelTopRw.Controls.Add(this.phoneTextBox);
            this.panelTopRw.Controls.Add(idNumberLabel);
            this.panelTopRw.Controls.Add(this.txtAccounNum);
            this.panelTopRw.Controls.Add(this.idNumberTextBox);
            this.panelTopRw.Controls.Add(addressLabel);
            this.panelTopRw.Controls.Add(this.btnSave);
            this.panelTopRw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRw.Location = new System.Drawing.Point(4, 4);
            this.panelTopRw.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopRw.Name = "panelTopRw";
            this.panelTopRw.Size = new System.Drawing.Size(1281, 235);
            this.panelTopRw.TabIndex = 0;
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::XpressLoan.Properties.Resources.ic_user_bss;
            this.pbProfile.Location = new System.Drawing.Point(30, 19);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(177, 188);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 44;
            this.pbProfile.TabStop = false;
            // 
            // txtTextCount
            // 
            this.txtTextCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTextCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextCount.ForeColor = System.Drawing.Color.Red;
            this.txtTextCount.Location = new System.Drawing.Point(495, 184);
            this.txtTextCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextCount.MaxLength = 20;
            this.txtTextCount.Name = "txtTextCount";
            this.txtTextCount.ReadOnly = true;
            this.txtTextCount.Size = new System.Drawing.Size(79, 23);
            this.txtTextCount.TabIndex = 43;
            this.txtTextCount.Text = "0/20";
            this.txtTextCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTextCount.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(997, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdit.Location = new System.Drawing.Point(997, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 99);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // idTypeComboBox
            // 
            this.idTypeComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.idTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "IdType", true));
            this.idTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idTypeComboBox.Enabled = false;
            this.idTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTypeComboBox.FormattingEnabled = true;
            this.idTypeComboBox.Items.AddRange(new object[] {
            "GHANA CARD",
            "VOTER"});
            this.idTypeComboBox.Location = new System.Drawing.Point(768, 125);
            this.idTypeComboBox.Name = "idTypeComboBox";
            this.idTypeComboBox.Size = new System.Drawing.Size(204, 33);
            this.idTypeComboBox.TabIndex = 11;
            this.idTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.idTypeComboBox_SelectedIndexChanged);
            // 
            // tblCustomersBindingSource
            // 
            this.tblCustomersBindingSource.DataMember = "tblCustomers";
            this.tblCustomersBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // xpressLoanDBDataSet
            // 
            this.xpressLoanDBDataSet.DataSetName = "XpressLoanDBDataSet";
            this.xpressLoanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(352, 151);
            this.addressTextBox.MaxLength = 20;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(223, 59);
            this.addressTextBox.TabIndex = 17;
            this.addressTextBox.Text = "";
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // btnRequestLoan
            // 
            this.btnRequestLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(149)))), ((int)(((byte)(229)))));
            this.btnRequestLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRequestLoan.Location = new System.Drawing.Point(1110, 8);
            this.btnRequestLoan.Name = "btnRequestLoan";
            this.btnRequestLoan.Size = new System.Drawing.Size(158, 202);
            this.btnRequestLoan.TabIndex = 1;
            this.btnRequestLoan.Text = "Request Loan";
            this.btnRequestLoan.UseVisualStyleBackColor = false;
            this.btnRequestLoan.Click += new System.EventHandler(this.btnRequestLoan_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Enabled = false;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.genderComboBox.Location = new System.Drawing.Point(768, 78);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(204, 33);
            this.genderComboBox.TabIndex = 14;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(320, 58);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(188, 27);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(314, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(313, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(320, 101);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(193, 27);
            this.phoneTextBox.TabIndex = 7;
            // 
            // txtAccounNum
            // 
            this.txtAccounNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAccounNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccounNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounNum.Location = new System.Drawing.Point(768, 20);
            this.txtAccounNum.Name = "txtAccounNum";
            this.txtAccounNum.ReadOnly = true;
            this.txtAccounNum.Size = new System.Drawing.Size(204, 27);
            this.txtAccounNum.TabIndex = 9;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "IdNumber", true));
            this.idNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(768, 184);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.ReadOnly = true;
            this.idNumberTextBox.Size = new System.Drawing.Size(204, 27);
            this.idNumberTextBox.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(997, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 94);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 252);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1289, 348);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.loanMetroTab);
            this.metroTabControl1.Controls.Add(this.repaymentMetroTab);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(210, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(1289, 348);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // loanMetroTab
            // 
            this.loanMetroTab.AutoScroll = true;
            this.loanMetroTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanMetroTab.Controls.Add(this.tblLoansDataGridView);
            this.loanMetroTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanMetroTab.HorizontalScrollbar = true;
            this.loanMetroTab.HorizontalScrollbarBarColor = true;
            this.loanMetroTab.HorizontalScrollbarHighlightOnWheel = false;
            this.loanMetroTab.HorizontalScrollbarSize = 10;
            this.loanMetroTab.Location = new System.Drawing.Point(4, 38);
            this.loanMetroTab.Name = "loanMetroTab";
            this.loanMetroTab.Padding = new System.Windows.Forms.Padding(10);
            this.loanMetroTab.Size = new System.Drawing.Size(1281, 306);
            this.loanMetroTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.loanMetroTab.TabIndex = 0;
            this.loanMetroTab.Text = "Loans";
            this.loanMetroTab.VerticalScrollbar = true;
            this.loanMetroTab.VerticalScrollbarBarColor = true;
            this.loanMetroTab.VerticalScrollbarHighlightOnWheel = false;
            this.loanMetroTab.VerticalScrollbarSize = 10;
            // 
            // tblLoansDataGridView
            // 
            this.tblLoansDataGridView.AllowUserToAddRows = false;
            this.tblLoansDataGridView.AllowUserToDeleteRows = false;
            this.tblLoansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tblLoansDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLoansDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblLoansDataGridView.ColumnHeadersHeight = 32;
            this.tblLoansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLoansDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.tblLoansDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLoansDataGridView.Location = new System.Drawing.Point(10, 10);
            this.tblLoansDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tblLoansDataGridView.Name = "tblLoansDataGridView";
            this.tblLoansDataGridView.ReadOnly = true;
            this.tblLoansDataGridView.RowHeadersWidth = 51;
            this.tblLoansDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLoansDataGridView.RowTemplate.Height = 32;
            this.tblLoansDataGridView.Size = new System.Drawing.Size(1259, 284);
            this.tblLoansDataGridView.TabIndex = 0;
            this.tblLoansDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLoansDataGridView_CellContentClick);
            this.tblLoansDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblLoansDataGridView_RowPostPaint);
            // 
            // repaymentMetroTab
            // 
            this.repaymentMetroTab.Controls.Add(this.tableLayoutPanel3);
            this.repaymentMetroTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repaymentMetroTab.HorizontalScrollbarBarColor = true;
            this.repaymentMetroTab.HorizontalScrollbarHighlightOnWheel = false;
            this.repaymentMetroTab.HorizontalScrollbarSize = 10;
            this.repaymentMetroTab.Location = new System.Drawing.Point(4, 38);
            this.repaymentMetroTab.Name = "repaymentMetroTab";
            this.repaymentMetroTab.Padding = new System.Windows.Forms.Padding(10);
            this.repaymentMetroTab.Size = new System.Drawing.Size(1281, 306);
            this.repaymentMetroTab.TabIndex = 1;
            this.repaymentMetroTab.Text = "Repayments";
            this.repaymentMetroTab.VerticalScrollbarBarColor = true;
            this.repaymentMetroTab.VerticalScrollbarHighlightOnWheel = false;
            this.repaymentMetroTab.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1261, 286);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbxEnableStatus);
            this.panel1.Controls.Add(this.btnPrintSchedule);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.cbxLoans);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintSchedule
            // 
            this.btnPrintSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSchedule.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrintSchedule.FlatAppearance.BorderSize = 0;
            this.btnPrintSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSchedule.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintSchedule.Image = global::XpressLoan.Properties.Resources.ic_print20;
            this.btnPrintSchedule.Location = new System.Drawing.Point(899, 4);
            this.btnPrintSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintSchedule.Name = "btnPrintSchedule";
            this.btnPrintSchedule.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrintSchedule.Size = new System.Drawing.Size(247, 48);
            this.btnPrintSchedule.TabIndex = 73;
            this.btnPrintSchedule.Text = "  Print Schedule";
            this.btnPrintSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintSchedule.UseVisualStyleBackColor = false;
            this.btnPrintSchedule.Click += new System.EventHandler(this.btnPrintSchedule_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::XpressLoan.Properties.Resources.ic_refresh30;
            this.btnRefresh.Location = new System.Drawing.Point(1176, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 48);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxLoans
            // 
            this.cbxLoans.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxLoans.DropDownHeight = 100;
            this.cbxLoans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoans.DropDownWidth = 30;
            this.cbxLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoans.FormattingEnabled = true;
            this.cbxLoans.IntegralHeight = false;
            this.cbxLoans.Location = new System.Drawing.Point(163, 11);
            this.cbxLoans.Name = "cbxLoans";
            this.cbxLoans.Size = new System.Drawing.Size(304, 33);
            this.cbxLoans.TabIndex = 11;
            this.cbxLoans.SelectedIndexChanged += new System.EventHandler(this.cbxLoans_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblRepaymentDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 220);
            this.panel2.TabIndex = 0;
            // 
            // tblRepaymentDataGridView1
            // 
            this.tblRepaymentDataGridView1.AllowUserToAddRows = false;
            this.tblRepaymentDataGridView1.AllowUserToDeleteRows = false;
            this.tblRepaymentDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRepaymentDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRepaymentDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tblRepaymentDataGridView1.ColumnHeadersHeight = 32;
            this.tblRepaymentDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRepaymentDataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.tblRepaymentDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRepaymentDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.tblRepaymentDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.tblRepaymentDataGridView1.Name = "tblRepaymentDataGridView1";
            this.tblRepaymentDataGridView1.ReadOnly = true;
            this.tblRepaymentDataGridView1.RowHeadersWidth = 51;
            this.tblRepaymentDataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRepaymentDataGridView1.RowTemplate.Height = 32;
            this.tblRepaymentDataGridView1.Size = new System.Drawing.Size(1255, 220);
            this.tblRepaymentDataGridView1.TabIndex = 3;
            this.tblRepaymentDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRepaymentDataGridView1_CellClick);
            this.tblRepaymentDataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblRepaymentDataGridView1_RowPostPaint);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel4);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1281, 306);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Transactions";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1281, 306);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxTransLoans);
            this.panel3.Controls.Add(this.btnPrintStmt);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 54);
            this.panel3.TabIndex = 0;
            // 
            // cbxTransLoans
            // 
            this.cbxTransLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTransLoans.FormattingEnabled = true;
            this.cbxTransLoans.Location = new System.Drawing.Point(167, 14);
            this.cbxTransLoans.Name = "cbxTransLoans";
            this.cbxTransLoans.Size = new System.Drawing.Size(188, 30);
            this.cbxTransLoans.TabIndex = 74;
            this.cbxTransLoans.SelectedIndexChanged += new System.EventHandler(this.cbxTransLoans_SelectedIndexChanged);
            // 
            // btnPrintStmt
            // 
            this.btnPrintStmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintStmt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrintStmt.FlatAppearance.BorderSize = 0;
            this.btnPrintStmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintStmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintStmt.Image = global::XpressLoan.Properties.Resources.ic_print20;
            this.btnPrintStmt.Location = new System.Drawing.Point(919, 4);
            this.btnPrintStmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintStmt.Name = "btnPrintStmt";
            this.btnPrintStmt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrintStmt.Size = new System.Drawing.Size(247, 48);
            this.btnPrintStmt.TabIndex = 73;
            this.btnPrintStmt.Text = "  Print Statement";
            this.btnPrintStmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintStmt.UseVisualStyleBackColor = false;
            this.btnPrintStmt.Click += new System.EventHandler(this.btnPrintStmt_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::XpressLoan.Properties.Resources.ic_refresh30;
            this.button2.Location = new System.Drawing.Point(1196, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 48);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvTransactions);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1275, 240);
            this.panel4.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTransactions.ColumnHeadersHeight = 32;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 0);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.RowTemplate.Height = 32;
            this.dgvTransactions.Size = new System.Drawing.Size(1275, 240);
            this.dgvTransactions.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LoanID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LoanID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 116;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 161;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Purpose";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purpose";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 127;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Terms";
            this.dataGridViewTextBoxColumn5.HeaderText = "Terms";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 91;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ApplicationDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "ApplicationDate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 199;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CashoutDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "CashoutDate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 173;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn9.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 128;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FirstRepDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "FirstRepDate";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 172;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Guarantor";
            this.dataGridViewTextBoxColumn11.HeaderText = "Guarantor";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 143;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn12.HeaderText = "Status";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 109;
            // 
            // tblLoansBindingSource
            // 
            this.tblLoansBindingSource.DataMember = "tblLoans";
            this.tblLoansBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // repaymentIDDataGridViewTextBoxColumn
            // 
            this.repaymentIDDataGridViewTextBoxColumn.DataPropertyName = "RepaymentID";
            this.repaymentIDDataGridViewTextBoxColumn.HeaderText = "RepaymentID";
            this.repaymentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repaymentIDDataGridViewTextBoxColumn.Name = "repaymentIDDataGridViewTextBoxColumn";
            this.repaymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.repaymentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // repaymentDateDataGridViewTextBoxColumn
            // 
            this.repaymentDateDataGridViewTextBoxColumn.DataPropertyName = "RepaymentDate";
            this.repaymentDateDataGridViewTextBoxColumn.HeaderText = "RepaymentDate";
            this.repaymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repaymentDateDataGridViewTextBoxColumn.Name = "repaymentDateDataGridViewTextBoxColumn";
            this.repaymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.repaymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblRepaymentBindingSource
            // 
            this.tblRepaymentBindingSource.DataMember = "tblRepayment";
            this.tblRepaymentBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // tblRepaymentTableAdapter
            // 
            this.tblRepaymentTableAdapter.ClearBeforeFill = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAccountTableAdapter = null;
            this.tableAdapterManager.tblApplicationsTableAdapter = null;
            this.tableAdapterManager.tblCustomersTableAdapter = this.tblCustomersTableAdapter;
            this.tableAdapterManager.tblDepositTableAdapter = null;
            this.tableAdapterManager.tblExpensesTableAdapter = null;
            this.tableAdapterManager.tblLoansTableAdapter = null;
            this.tableAdapterManager.tblRepaymentTableAdapter = this.tblRepaymentTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCustomersTableAdapter
            // 
            this.tblCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tblLoansTableAdapter
            // 
            this.tblLoansTableAdapter.ClearBeforeFill = true;
            // 
            // tblRepaymentBindingSource1
            // 
            this.tblRepaymentBindingSource1.DataMember = "tblRepayment";
            this.tblRepaymentBindingSource1.DataSource = this.xpressLoanDBDataSet;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // ckbxEnableStatus
            // 
            this.ckbxEnableStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxEnableStatus.AutoSize = true;
            this.ckbxEnableStatus.Location = new System.Drawing.Point(728, 15);
            this.ckbxEnableStatus.Name = "ckbxEnableStatus";
            this.ckbxEnableStatus.Size = new System.Drawing.Size(156, 29);
            this.ckbxEnableStatus.TabIndex = 74;
            this.ckbxEnableStatus.Text = "Enable Status";
            this.ckbxEnableStatus.UseVisualStyleBackColor = true;
            this.ckbxEnableStatus.CheckedChanged += new System.EventHandler(this.ckbxEnableStatus_CheckedChanged);
            // 
            // FormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1335, 683);
            this.Name = "FormUserDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "UserDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelTopRw.ResumeLayout(false);
            this.panelTopRw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.loanMetroTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansDataGridView)).EndInit();
            this.repaymentMetroTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentDataGridView1)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepaymentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRw;
        private XpressLoanDBDataSet xpressLoanDBDataSet;
        private System.Windows.Forms.BindingSource tblRepaymentBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblRepaymentTableAdapter tblRepaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private XpressLoanDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private XpressLoanDBDataSetTableAdapters.tblCustomersTableAdapter tblCustomersTableAdapter;
        private System.Windows.Forms.BindingSource tblCustomersBindingSource;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.ComboBox idTypeComboBox;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.Button btnRequestLoan;
        private System.Windows.Forms.BindingSource tblLoansBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblLoansTableAdapter tblLoansTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Button btnEdit;
        private Button btnSave;
        private ProgressBar progressBar1;
        private BindingSource tblRepaymentBindingSource1;
        private TextBox txtTextCount;
        private PictureBox pbProfile;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage loanMetroTab;
        private DataGridView tblLoansDataGridView;
        private MetroFramework.Controls.MetroTabPage repaymentMetroTab;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Button btnPrintSchedule;
        private Button btnRefresh;
        private ComboBox cbxLoans;
        private Panel panel2;
        private DataGridView tblRepaymentDataGridView1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox txtAccounNum;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Button btnPrintStmt;
        private Button button2;
        private Panel panel4;
        private DataGridView dgvTransactions;
        private ComboBox cbxTransLoans;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private CheckBox ckbxEnableStatus;
    }
}