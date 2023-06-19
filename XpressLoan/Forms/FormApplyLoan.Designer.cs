namespace XpressLoan.Forms
{
    partial class FormApplyLoan
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
            System.Windows.Forms.Label loanIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label purposeLabel;
            System.Windows.Forms.Label termsLabel;
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label applicationDateLabel;
            System.Windows.Forms.Label cashoutDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label firstRepDateLabel;
            System.Windows.Forms.Label guarantorLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProcessing = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.firstRepDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cashoutDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.applicationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termsComboBox = new System.Windows.Forms.ComboBox();
            this.txtPurposeTextCount = new System.Windows.Forms.TextBox();
            this.loanIDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.guarantorTextBox = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.purposeTextBox = new System.Windows.Forms.TextBox();
            this.txtProcessing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTakeHome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            loanIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            purposeLabel = new System.Windows.Forms.Label();
            termsLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            applicationDateLabel = new System.Windows.Forms.Label();
            cashoutDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            firstRepDateLabel = new System.Windows.Forms.Label();
            guarantorLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loanIDLabel.Location = new System.Drawing.Point(19, 76);
            loanIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(94, 25);
            loanIDLabel.TabIndex = 38;
            loanIDLabel.Text = "Loan ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(16, 29);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(174, 25);
            customerIDLabel.TabIndex = 42;
            customerIDLabel.Text = "Customer Name:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amountLabel.Location = new System.Drawing.Point(14, 126);
            amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(93, 25);
            amountLabel.TabIndex = 44;
            amountLabel.Text = "Amount:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purposeLabel.Location = new System.Drawing.Point(13, 177);
            purposeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new System.Drawing.Size(99, 25);
            purposeLabel.TabIndex = 46;
            purposeLabel.Text = "Purpose:";
            // 
            // termsLabel
            // 
            termsLabel.AutoSize = true;
            termsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            termsLabel.Location = new System.Drawing.Point(13, 219);
            termsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            termsLabel.Name = "termsLabel";
            termsLabel.Size = new System.Drawing.Size(80, 25);
            termsLabel.TabIndex = 48;
            termsLabel.Text = "Terms:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rateLabel.Location = new System.Drawing.Point(15, 264);
            rateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(63, 25);
            rateLabel.TabIndex = 50;
            rateLabel.Text = "Rate:";
            // 
            // applicationDateLabel
            // 
            applicationDateLabel.AutoSize = true;
            applicationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            applicationDateLabel.Location = new System.Drawing.Point(13, 308);
            applicationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            applicationDateLabel.Name = "applicationDateLabel";
            applicationDateLabel.Size = new System.Drawing.Size(177, 25);
            applicationDateLabel.TabIndex = 52;
            applicationDateLabel.Text = "Application Date:";
            // 
            // cashoutDateLabel
            // 
            cashoutDateLabel.AutoSize = true;
            cashoutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashoutDateLabel.Location = new System.Drawing.Point(15, 359);
            cashoutDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cashoutDateLabel.Name = "cashoutDateLabel";
            cashoutDateLabel.Size = new System.Drawing.Size(151, 25);
            cashoutDateLabel.TabIndex = 54;
            cashoutDateLabel.Text = "Cashout Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(29, 426);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 56;
            label1.Text = "(Months)";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            durationLabel.Location = new System.Drawing.Point(15, 401);
            durationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(100, 25);
            durationLabel.TabIndex = 57;
            durationLabel.Text = "Duration:";
            // 
            // firstRepDateLabel
            // 
            firstRepDateLabel.AutoSize = true;
            firstRepDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstRepDateLabel.Location = new System.Drawing.Point(15, 456);
            firstRepDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstRepDateLabel.Name = "firstRepDateLabel";
            firstRepDateLabel.Size = new System.Drawing.Size(156, 25);
            firstRepDateLabel.TabIndex = 59;
            firstRepDateLabel.Text = "First Rep Date:";
            // 
            // guarantorLabel
            // 
            guarantorLabel.AutoSize = true;
            guarantorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guarantorLabel.Location = new System.Drawing.Point(14, 502);
            guarantorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            guarantorLabel.Name = "guarantorLabel";
            guarantorLabel.Size = new System.Drawing.Size(115, 25);
            guarantorLabel.TabIndex = 61;
            guarantorLabel.Text = "Guarantor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(19, 556);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 25);
            label4.TabIndex = 63;
            label4.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(294, 268);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 25);
            label2.TabIndex = 50;
            label2.Text = "%";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnCalculator);
            this.panel2.Controls.Add(this.txtNotice);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.firstRepDateDateTimePicker);
            this.panel2.Controls.Add(this.cashoutDateDateTimePicker);
            this.panel2.Controls.Add(this.applicationDateDateTimePicker);
            this.panel2.Controls.Add(this.termsComboBox);
            this.panel2.Controls.Add(loanIDLabel);
            this.panel2.Controls.Add(this.txtPurposeTextCount);
            this.panel2.Controls.Add(this.loanIDTextBox);
            this.panel2.Controls.Add(customerIDLabel);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(amountLabel);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Controls.Add(purposeLabel);
            this.panel2.Controls.Add(termsLabel);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(rateLabel);
            this.panel2.Controls.Add(this.rateTextBox);
            this.panel2.Controls.Add(applicationDateLabel);
            this.panel2.Controls.Add(cashoutDateLabel);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(durationLabel);
            this.panel2.Controls.Add(this.durationTextBox);
            this.panel2.Controls.Add(firstRepDateLabel);
            this.panel2.Controls.Add(guarantorLabel);
            this.panel2.Controls.Add(this.guarantorTextBox);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.btnApply);
            this.panel2.Controls.Add(this.purposeTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 724);
            this.panel2.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txtTakeHome);
            this.groupBox1.Controls.Add(this.txtProcessing);
            this.groupBox1.Controls.Add(this.cbxProcessing);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(861, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 510);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // cbxProcessing
            // 
            this.cbxProcessing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProcessing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxProcessing.FormattingEnabled = true;
            this.cbxProcessing.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%"});
            this.cbxProcessing.Location = new System.Drawing.Point(114, 119);
            this.cbxProcessing.Name = "cbxProcessing";
            this.cbxProcessing.Size = new System.Drawing.Size(94, 33);
            this.cbxProcessing.TabIndex = 10;
            this.cbxProcessing.SelectedIndexChanged += new System.EventHandler(this.cbxProcessing_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(35, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Processing Fees";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalculator.Image = global::XpressLoan.Properties.Resources.ic_calculator30;
            this.btnCalculator.Location = new System.Drawing.Point(588, 610);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCalculator.Size = new System.Drawing.Size(175, 60);
            this.btnCalculator.TabIndex = 72;
            this.btnCalculator.Text = "   Calculator";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtNotice
            // 
            this.txtNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotice.ForeColor = System.Drawing.Color.Red;
            this.txtNotice.Location = new System.Drawing.Point(435, 408);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(184, 23);
            this.txtNotice.TabIndex = 71;
            this.txtNotice.Text = "# Max. 72 months.";
            this.txtNotice.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(205, 556);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(233, 30);
            this.txtStatus.TabIndex = 64;
            this.txtStatus.Text = "PENDING";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstRepDateDateTimePicker
            // 
            this.firstRepDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.firstRepDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRepDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.firstRepDateDateTimePicker.Location = new System.Drawing.Point(204, 443);
            this.firstRepDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.firstRepDateDateTimePicker.Name = "firstRepDateDateTimePicker";
            this.firstRepDateDateTimePicker.Size = new System.Drawing.Size(223, 30);
            this.firstRepDateDateTimePicker.TabIndex = 70;
            // 
            // cashoutDateDateTimePicker
            // 
            this.cashoutDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.cashoutDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashoutDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cashoutDateDateTimePicker.Location = new System.Drawing.Point(205, 359);
            this.cashoutDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.cashoutDateDateTimePicker.Name = "cashoutDateDateTimePicker";
            this.cashoutDateDateTimePicker.Size = new System.Drawing.Size(223, 30);
            this.cashoutDateDateTimePicker.TabIndex = 69;
            // 
            // applicationDateDateTimePicker
            // 
            this.applicationDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.applicationDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.applicationDateDateTimePicker.Location = new System.Drawing.Point(204, 312);
            this.applicationDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.applicationDateDateTimePicker.Name = "applicationDateDateTimePicker";
            this.applicationDateDateTimePicker.Size = new System.Drawing.Size(224, 30);
            this.applicationDateDateTimePicker.TabIndex = 68;
            // 
            // termsComboBox
            // 
            this.termsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsComboBox.FormattingEnabled = true;
            this.termsComboBox.Items.AddRange(new object[] {
            "WEEKLY",
            "BI-WEEKLY",
            "MONTHLY"});
            this.termsComboBox.Location = new System.Drawing.Point(205, 217);
            this.termsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.termsComboBox.Name = "termsComboBox";
            this.termsComboBox.Size = new System.Drawing.Size(218, 33);
            this.termsComboBox.TabIndex = 67;
            this.termsComboBox.SelectedIndexChanged += new System.EventHandler(this.termsComboBox_SelectedIndexChanged);
            // 
            // txtPurposeTextCount
            // 
            this.txtPurposeTextCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPurposeTextCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurposeTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeTextCount.ForeColor = System.Drawing.Color.Red;
            this.txtPurposeTextCount.Location = new System.Drawing.Point(671, 174);
            this.txtPurposeTextCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurposeTextCount.Name = "txtPurposeTextCount";
            this.txtPurposeTextCount.ReadOnly = true;
            this.txtPurposeTextCount.Size = new System.Drawing.Size(79, 23);
            this.txtPurposeTextCount.TabIndex = 41;
            this.txtPurposeTextCount.Text = "0/20";
            this.txtPurposeTextCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // loanIDTextBox
            // 
            this.loanIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanIDTextBox.Location = new System.Drawing.Point(205, 76);
            this.loanIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.ReadOnly = true;
            this.loanIDTextBox.Size = new System.Drawing.Size(222, 30);
            this.loanIDTextBox.TabIndex = 41;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(207, 29);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(556, 30);
            this.NameTextBox.TabIndex = 43;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(204, 121);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(552, 30);
            this.amountTextBox.TabIndex = 45;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // rateTextBox
            // 
            this.rateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.Location = new System.Drawing.Point(204, 265);
            this.rateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(122, 30);
            this.rateTextBox.TabIndex = 51;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTextBox.Location = new System.Drawing.Point(204, 405);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.durationTextBox.MaxLength = 2;
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(224, 30);
            this.durationTextBox.TabIndex = 58;
            this.durationTextBox.TextChanged += new System.EventHandler(this.durationTextBox_TextChanged);
            // 
            // guarantorTextBox
            // 
            this.guarantorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guarantorTextBox.Location = new System.Drawing.Point(205, 496);
            this.guarantorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guarantorTextBox.Name = "guarantorTextBox";
            this.guarantorTextBox.ReadOnly = true;
            this.guarantorTextBox.Size = new System.Drawing.Size(558, 30);
            this.guarantorTextBox.TabIndex = 62;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(875, 609);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(216, 60);
            this.btnApply.TabIndex = 40;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // purposeTextBox
            // 
            this.purposeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposeTextBox.Location = new System.Drawing.Point(204, 171);
            this.purposeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.purposeTextBox.MaxLength = 20;
            this.purposeTextBox.Name = "purposeTextBox";
            this.purposeTextBox.Size = new System.Drawing.Size(552, 30);
            this.purposeTextBox.TabIndex = 47;
            this.purposeTextBox.TextChanged += new System.EventHandler(this.purposeTextBox_TextChanged);
            // 
            // txtProcessing
            // 
            this.txtProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessing.Location = new System.Drawing.Point(40, 239);
            this.txtProcessing.Name = "txtProcessing";
            this.txtProcessing.Size = new System.Drawing.Size(180, 30);
            this.txtProcessing.TabIndex = 11;
            this.txtProcessing.TextChanged += new System.EventHandler(this.txtProcessing_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(35, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Take Home";
            // 
            // txtTakeHome
            // 
            this.txtTakeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeHome.Location = new System.Drawing.Point(40, 401);
            this.txtTakeHome.Name = "txtTakeHome";
            this.txtTakeHome.ReadOnly = true;
            this.txtTakeHome.Size = new System.Drawing.Size(180, 30);
            this.txtTakeHome.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(35, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rate";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(40, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fees";
            // 
            // FormApplyLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 804);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplyLoan";
            this.ShowInTaskbar = false;
            this.Text = "Loan Application Form";
            this.Load += new System.EventHandler(this.FormApplyLoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker firstRepDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker cashoutDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker applicationDateDateTimePicker;
        private System.Windows.Forms.ComboBox termsComboBox;
        private System.Windows.Forms.TextBox loanIDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox purposeTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox guarantorTextBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtPurposeTextCount;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxProcessing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcessing;
        private System.Windows.Forms.TextBox txtTakeHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}