namespace XpressLoan.Forms
{
    partial class FormAddCustomer
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
            System.Windows.Forms.Label label1;
            this.panelCol2 = new System.Windows.Forms.Panel();
            this.cx = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenAccNum = new System.Windows.Forms.Button();
            this.genAccNumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddressCount = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.idTypeComboBox = new System.Windows.Forms.ComboBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            idNumberLabel = new System.Windows.Forms.Label();
            idTypeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelCol2.SuspendLayout();
            this.cx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(24, 41);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(47, 31);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(21, 91);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(91, 31);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(21, 135);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(109, 31);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(21, 180);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(97, 31);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // idNumberLabel
            // 
            idNumberLabel.AutoSize = true;
            idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNumberLabel.Location = new System.Drawing.Point(21, 219);
            idNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new System.Drawing.Size(147, 31);
            idNumberLabel.TabIndex = 8;
            idNumberLabel.Text = "ID Number:";
            // 
            // idTypeLabel
            // 
            idTypeLabel.AutoSize = true;
            idTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            idTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTypeLabel.Location = new System.Drawing.Point(23, 263);
            idTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idTypeLabel.Name = "idTypeLabel";
            idTypeLabel.Size = new System.Drawing.Size(113, 31);
            idTypeLabel.TabIndex = 10;
            idTypeLabel.Text = "ID Type:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(23, 330);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(118, 31);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(15, 287);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "File Path:";
            // 
            // panelCol2
            // 
            this.panelCol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCol2.Controls.Add(this.cx);
            this.panelCol2.Controls.Add(this.panel3);
            this.panelCol2.Controls.Add(this.groupBox1);
            this.panelCol2.Controls.Add(this.btnAddCustomer);
            this.panelCol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCol2.Location = new System.Drawing.Point(20, 60);
            this.panelCol2.Margin = new System.Windows.Forms.Padding(4);
            this.panelCol2.Name = "panelCol2";
            this.panelCol2.Size = new System.Drawing.Size(1076, 841);
            this.panelCol2.TabIndex = 1;
            // 
            // cx
            // 
            this.cx.BackColor = System.Drawing.Color.MistyRose;
            this.cx.Controls.Add(this.txtPath);
            this.cx.Controls.Add(this.btnBrowse);
            this.cx.Controls.Add(this.pbProfile);
            this.cx.Controls.Add(label1);
            this.cx.Location = new System.Drawing.Point(710, 16);
            this.cx.Name = "cx";
            this.cx.Size = new System.Drawing.Size(335, 427);
            this.cx.TabIndex = 69;
            this.cx.TabStop = false;
            this.cx.Text = "Profile Picture";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(8, 321);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(321, 26);
            this.txtPath.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightCoral;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(215, 362);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 40);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.Silver;
            this.pbProfile.Location = new System.Drawing.Point(51, 21);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(249, 229);
            this.pbProfile.TabIndex = 15;
            this.pbProfile.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnGenAccNum);
            this.panel3.Controls.Add(this.genAccNumTextBox);
            this.panel3.Location = new System.Drawing.Point(219, 492);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 153);
            this.panel3.TabIndex = 67;
            // 
            // btnGenAccNum
            // 
            this.btnGenAccNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(131)))));
            this.btnGenAccNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenAccNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenAccNum.Location = new System.Drawing.Point(52, 90);
            this.btnGenAccNum.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenAccNum.Name = "btnGenAccNum";
            this.btnGenAccNum.Size = new System.Drawing.Size(320, 46);
            this.btnGenAccNum.TabIndex = 39;
            this.btnGenAccNum.Text = "Generate Account Number";
            this.btnGenAccNum.UseVisualStyleBackColor = false;
            this.btnGenAccNum.Click += new System.EventHandler(this.btnGenAccNum_Click);
            // 
            // genAccNumTextBox
            // 
            this.genAccNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genAccNumTextBox.Location = new System.Drawing.Point(53, 24);
            this.genAccNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.genAccNumTextBox.Name = "genAccNumTextBox";
            this.genAccNumTextBox.ReadOnly = true;
            this.genAccNumTextBox.Size = new System.Drawing.Size(319, 30);
            this.genAccNumTextBox.TabIndex = 64;
            this.genAccNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtAddressCount);
            this.groupBox1.Controls.Add(this.customerIDTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(customerIDLabel);
            this.groupBox1.Controls.Add(this.idTypeComboBox);
            this.groupBox1.Controls.Add(idTypeLabel);
            this.groupBox1.Controls.Add(this.idNumberTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(idNumberLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 674);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // txtAddressCount
            // 
            this.txtAddressCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAddressCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressCount.ForeColor = System.Drawing.Color.Red;
            this.txtAddressCount.Location = new System.Drawing.Point(521, 388);
            this.txtAddressCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressCount.MaxLength = 15;
            this.txtAddressCount.Name = "txtAddressCount";
            this.txtAddressCount.ReadOnly = true;
            this.txtAddressCount.Size = new System.Drawing.Size(101, 27);
            this.txtAddressCount.TabIndex = 1;
            this.txtAddressCount.Text = "0/30";
            this.txtAddressCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(188, 38);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(263, 34);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(188, 304);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.MaxLength = 30;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(443, 123);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // idTypeComboBox
            // 
            this.idTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTypeComboBox.FormattingEnabled = true;
            this.idTypeComboBox.Items.AddRange(new object[] {
            "GHANA CARD",
            "VOTER"});
            this.idTypeComboBox.Location = new System.Drawing.Point(188, 259);
            this.idTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTypeComboBox.Name = "idTypeComboBox";
            this.idTypeComboBox.Size = new System.Drawing.Size(263, 37);
            this.idTypeComboBox.TabIndex = 11;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(188, 217);
            this.idNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(443, 34);
            this.idNumberTextBox.TabIndex = 9;
            this.idNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.idNumberTextBox_Validating);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(188, 88);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(443, 34);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating_1);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(188, 175);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(443, 34);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.genderComboBox.Location = new System.Drawing.Point(188, 130);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(263, 37);
            this.genderComboBox.TabIndex = 5;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(774, 519);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(243, 142);
            this.btnAddCustomer.TabIndex = 14;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 921);
            this.Controls.Add(this.panelCol2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCustomer";
            this.ShowInTaskbar = false;
            this.Text = "Add Customer Form";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.panelCol2.ResumeLayout(false);
            this.cx.ResumeLayout(false);
            this.cx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCol2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenAccNum;
        private System.Windows.Forms.TextBox genAccNumTextBox;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.ComboBox idTypeComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox txtAddressCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cx;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
    }
}