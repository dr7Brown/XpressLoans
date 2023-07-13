namespace XpressLoan.Forms
{
    partial class FormAddRepayment
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
            System.Windows.Forms.Label repaymentIDLabel;
            System.Windows.Forms.Label loanIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRepayment));
            this.panelCol2 = new System.Windows.Forms.Panel();
            this.dgRepayments = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtPurposeTextCount = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCoName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblContact2 = new System.Windows.Forms.Label();
            this.lblContact1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.repaymentIDTextBox = new System.Windows.Forms.TextBox();
            this.loanIDTextBox = new System.Windows.Forms.TextBox();
            this.datePaidDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBalance = new System.Windows.Forms.TextBox();
            repaymentIDLabel = new System.Windows.Forms.Label();
            loanIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panelCol2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepayments)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // repaymentIDLabel
            // 
            repaymentIDLabel.AutoSize = true;
            repaymentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            repaymentIDLabel.Location = new System.Drawing.Point(19, 170);
            repaymentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            repaymentIDLabel.Name = "repaymentIDLabel";
            repaymentIDLabel.Size = new System.Drawing.Size(40, 25);
            repaymentIDLabel.TabIndex = 14;
            repaymentIDLabel.Text = "ID:";
            // 
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loanIDLabel.Location = new System.Drawing.Point(22, 266);
            loanIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(94, 25);
            loanIDLabel.TabIndex = 16;
            loanIDLabel.Text = "Loan ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(22, 315);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 25);
            label1.TabIndex = 18;
            label1.Text = "Date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amountLabel.Location = new System.Drawing.Point(20, 366);
            amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(90, 25);
            amountLabel.TabIndex = 20;
            amountLabel.Text = "Balance";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(488, 346);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(122, 25);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Comments:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(19, 219);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 25);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(18, 416);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(120, 25);
            label8.TabIndex = 22;
            label8.Text = "Repayment";
            // 
            // panelCol2
            // 
            this.panelCol2.AutoScroll = true;
            this.panelCol2.Controls.Add(this.dgRepayments);
            this.panelCol2.Controls.Add(this.txtAmount);
            this.panelCol2.Controls.Add(this.progressBar1);
            this.panelCol2.Controls.Add(this.txtError);
            this.panelCol2.Controls.Add(this.txtPurposeTextCount);
            this.panelCol2.Controls.Add(this.commentsTextBox);
            this.panelCol2.Controls.Add(this.btnSubmit);
            this.panelCol2.Controls.Add(this.panel1);
            this.panelCol2.Controls.Add(label2);
            this.panelCol2.Controls.Add(repaymentIDLabel);
            this.panelCol2.Controls.Add(this.nameTextBox1);
            this.panelCol2.Controls.Add(this.repaymentIDTextBox);
            this.panelCol2.Controls.Add(loanIDLabel);
            this.panelCol2.Controls.Add(this.loanIDTextBox);
            this.panelCol2.Controls.Add(label1);
            this.panelCol2.Controls.Add(this.datePaidDatePicker);
            this.panelCol2.Controls.Add(amountLabel);
            this.panelCol2.Controls.Add(this.txtBalance);
            this.panelCol2.Controls.Add(label8);
            this.panelCol2.Controls.Add(statusLabel);
            this.panelCol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCol2.Location = new System.Drawing.Point(20, 60);
            this.panelCol2.Margin = new System.Windows.Forms.Padding(4);
            this.panelCol2.Name = "panelCol2";
            this.panelCol2.Size = new System.Drawing.Size(861, 685);
            this.panelCol2.TabIndex = 1;
            // 
            // dgRepayments
            // 
            this.dgRepayments.AllowUserToAddRows = false;
            this.dgRepayments.AllowUserToDeleteRows = false;
            this.dgRepayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRepayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgRepayments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgRepayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepayments.Location = new System.Drawing.Point(422, 145);
            this.dgRepayments.Name = "dgRepayments";
            this.dgRepayments.RowHeadersWidth = 51;
            this.dgRepayments.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgRepayments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRepayments.RowTemplate.Height = 24;
            this.dgRepayments.Size = new System.Drawing.Size(426, 175);
            this.dgRepayments.TabIndex = 47;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(143, 413);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(252, 30);
            this.txtAmount.TabIndex = 46;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(-18, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(887, 11);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 43;
            this.progressBar1.Visible = false;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(167, 447);
            this.txtError.Margin = new System.Windows.Forms.Padding(4);
            this.txtError.MaxLength = 20;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(310, 20);
            this.txtError.TabIndex = 42;
            this.txtError.Visible = false;
            // 
            // txtPurposeTextCount
            // 
            this.txtPurposeTextCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPurposeTextCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurposeTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurposeTextCount.ForeColor = System.Drawing.Color.Red;
            this.txtPurposeTextCount.Location = new System.Drawing.Point(751, 413);
            this.txtPurposeTextCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurposeTextCount.MaxLength = 20;
            this.txtPurposeTextCount.Name = "txtPurposeTextCount";
            this.txtPurposeTextCount.ReadOnly = true;
            this.txtPurposeTextCount.Size = new System.Drawing.Size(79, 23);
            this.txtPurposeTextCount.TabIndex = 42;
            this.txtPurposeTextCount.Text = "0/20";
            this.txtPurposeTextCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(484, 376);
            this.commentsTextBox.MaxLength = 20;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(357, 69);
            this.commentsTextBox.TabIndex = 27;
            this.commentsTextBox.Text = "";
            this.commentsTextBox.TextChanged += new System.EventHandler(this.commentsTextBox_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(587, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(196, 161);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCoName);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblContact2);
            this.panel1.Controls.Add(this.lblContact1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 130);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoName.Location = new System.Drawing.Point(216, 17);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(195, 25);
            this.lblCoName.TabIndex = 10;
            this.lblCoName.Text = "Express Loans Co.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(280, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(223, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "expressloans@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email: ";
            // 
            // lblContact2
            // 
            this.lblContact2.AutoSize = true;
            this.lblContact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact2.Location = new System.Drawing.Point(491, 54);
            this.lblContact2.Name = "lblContact2";
            this.lblContact2.Size = new System.Drawing.Size(109, 20);
            this.lblContact2.TabIndex = 8;
            this.lblContact2.Text = "0240166059";
            // 
            // lblContact1
            // 
            this.lblContact1.AutoSize = true;
            this.lblContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact1.Location = new System.Drawing.Point(323, 54);
            this.lblContact1.Name = "lblContact1";
            this.lblContact1.Size = new System.Drawing.Size(109, 20);
            this.lblContact1.TabIndex = 8;
            this.lblContact1.Text = "0249515365";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact: ";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox1.Location = new System.Drawing.Point(95, 219);
            this.nameTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.ReadOnly = true;
            this.nameTextBox1.Size = new System.Drawing.Size(300, 30);
            this.nameTextBox1.TabIndex = 15;
            // 
            // repaymentIDTextBox
            // 
            this.repaymentIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repaymentIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repaymentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repaymentIDTextBox.Location = new System.Drawing.Point(95, 170);
            this.repaymentIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repaymentIDTextBox.Name = "repaymentIDTextBox";
            this.repaymentIDTextBox.ReadOnly = true;
            this.repaymentIDTextBox.Size = new System.Drawing.Size(162, 30);
            this.repaymentIDTextBox.TabIndex = 15;
            // 
            // loanIDTextBox
            // 
            this.loanIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loanIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanIDTextBox.Location = new System.Drawing.Point(144, 261);
            this.loanIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.ReadOnly = true;
            this.loanIDTextBox.Size = new System.Drawing.Size(214, 30);
            this.loanIDTextBox.TabIndex = 17;
            // 
            // datePaidDatePicker
            // 
            this.datePaidDatePicker.CustomFormat = "yyyy-MM-dd";
            this.datePaidDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePaidDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaidDatePicker.Location = new System.Drawing.Point(142, 310);
            this.datePaidDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePaidDatePicker.Name = "datePaidDatePicker";
            this.datePaidDatePicker.Size = new System.Drawing.Size(252, 30);
            this.datePaidDatePicker.TabIndex = 19;
            this.datePaidDatePicker.ValueChanged += new System.EventHandler(this.repaymentDateTimePicker_ValueChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(143, 361);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(252, 30);
            this.txtBalance.TabIndex = 21;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAddRepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 765);
            this.Controls.Add(this.panelCol2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddRepayment";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Repayment Form";
            this.panelCol2.ResumeLayout(false);
            this.panelCol2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepayments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCol2;
        private System.Windows.Forms.TextBox repaymentIDTextBox;
        private System.Windows.Forms.TextBox loanIDTextBox;
        private System.Windows.Forms.DateTimePicker datePaidDatePicker;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblContact2;
        private System.Windows.Forms.Label lblContact1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.TextBox txtPurposeTextCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgRepayments;
    }
}