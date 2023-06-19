namespace XpressLoan.Forms
{
    partial class FormSettings
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtContact2 = new System.Windows.Forms.TextBox();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtSuccess = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtbMd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSuccess2 = new System.Windows.Forms.TextBox();
            this.txtError2 = new System.Windows.Forms.TextBox();
            amountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amountLabel.Location = new System.Drawing.Point(47, 109);
            amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(111, 25);
            amountLabel.TabIndex = 46;
            amountLabel.Text = "Edit Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(47, 165);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 25);
            label1.TabIndex = 46;
            label1.Text = "Contact 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(47, 228);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 25);
            label2.TabIndex = 46;
            label2.Text = "Contact 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            label3.Location = new System.Drawing.Point(25, 37);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 25);
            label3.TabIndex = 46;
            label3.Text = "MD File";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(47, 285);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 25);
            label4.TabIndex = 46;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            label5.Location = new System.Drawing.Point(22, 156);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 25);
            label5.TabIndex = 46;
            label5.Text = "Log File";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(395, 21);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 53);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "Save Changes";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(235, 109);
            this.txtName.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(394, 30);
            this.txtName.TabIndex = 47;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(this.txtContact2);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.txtContact1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(28, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 349);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logo";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(235, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 30);
            this.txtEmail.TabIndex = 53;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 10);
            this.progressBar1.TabIndex = 52;
            // 
            // txtContact2
            // 
            this.txtContact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact2.Location = new System.Drawing.Point(235, 228);
            this.txtContact2.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtContact2.Name = "txtContact2";
            this.txtContact2.Size = new System.Drawing.Size(394, 30);
            this.txtContact2.TabIndex = 47;
            this.txtContact2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContact2.Leave += new System.EventHandler(this.txtContact2_Leave);
            // 
            // txtContact1
            // 
            this.txtContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact1.Location = new System.Drawing.Point(235, 165);
            this.txtContact1.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(394, 30);
            this.txtContact1.TabIndex = 47;
            this.txtContact1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContact1.Leave += new System.EventHandler(this.txtContact1_Leave);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(378, 374);
            this.txtError.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(323, 23);
            this.txtError.TabIndex = 47;
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtError.Visible = false;
            // 
            // txtSuccess
            // 
            this.txtSuccess.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSuccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccess.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtSuccess.Location = new System.Drawing.Point(29, 374);
            this.txtSuccess.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtSuccess.Name = "txtSuccess";
            this.txtSuccess.ReadOnly = true;
            this.txtSuccess.Size = new System.Drawing.Size(323, 23);
            this.txtSuccess.TabIndex = 47;
            this.txtSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuccess.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Controls.Add(this.txtbMd);
            this.groupBox1.Location = new System.Drawing.Point(29, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(673, 300);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 290);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(673, 10);
            this.progressBar2.TabIndex = 54;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(408, 16);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(128, 250);
            this.btnRestore.TabIndex = 51;
            this.btnRestore.Text = "Restore Backup";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(542, 16);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 250);
            this.btnBackup.TabIndex = 51;
            this.btnBackup.Text = "Create Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Olive;
            this.txtLog.Location = new System.Drawing.Point(24, 185);
            this.txtLog.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(323, 70);
            this.txtLog.TabIndex = 47;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbMd
            // 
            this.txtbMd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbMd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMd.ForeColor = System.Drawing.Color.Olive;
            this.txtbMd.Location = new System.Drawing.Point(24, 66);
            this.txtbMd.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtbMd.Multiline = true;
            this.txtbMd.Name = "txtbMd";
            this.txtbMd.ReadOnly = true;
            this.txtbMd.Size = new System.Drawing.Size(323, 67);
            this.txtbMd.TabIndex = 47;
            this.txtbMd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtError2);
            this.panel1.Controls.Add(this.txtError);
            this.panel1.Controls.Add(this.txtSuccess2);
            this.panel1.Controls.Add(this.txtSuccess);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 760);
            this.panel1.TabIndex = 54;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(767, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 349);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "RESET APP";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSuccess2
            // 
            this.txtSuccess2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSuccess2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuccess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccess2.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtSuccess2.Location = new System.Drawing.Point(28, 711);
            this.txtSuccess2.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtSuccess2.Name = "txtSuccess2";
            this.txtSuccess2.ReadOnly = true;
            this.txtSuccess2.Size = new System.Drawing.Size(323, 23);
            this.txtSuccess2.TabIndex = 47;
            this.txtSuccess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuccess2.Visible = false;
            // 
            // txtError2
            // 
            this.txtError2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtError2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError2.ForeColor = System.Drawing.Color.Red;
            this.txtError2.Location = new System.Drawing.Point(379, 712);
            this.txtError2.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtError2.Name = "txtError2";
            this.txtError2.ReadOnly = true;
            this.txtError2.Size = new System.Drawing.Size(323, 23);
            this.txtError2.TabIndex = 47;
            this.txtError2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtError2.Visible = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 802);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContact2;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtSuccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtbMd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox txtError2;
        private System.Windows.Forms.TextBox txtSuccess2;
    }
}