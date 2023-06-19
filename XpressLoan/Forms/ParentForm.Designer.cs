namespace XpressLoan
{
    partial class ParentForm
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
            this.panelSidePane = new System.Windows.Forms.Panel();
            this.panelCurrentButton = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRepayments = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.PanelWorkAreaContainer = new System.Windows.Forms.Panel();
            this.PanelChildForms = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxRestore = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelSidePane.SuspendLayout();
            this.userProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.PanelWorkAreaContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidePane
            // 
            this.panelSidePane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panelSidePane.Controls.Add(this.panelCurrentButton);
            this.panelSidePane.Controls.Add(this.btnLogout);
            this.panelSidePane.Controls.Add(this.btnSettings);
            this.panelSidePane.Controls.Add(this.btnReports);
            this.panelSidePane.Controls.Add(this.btnCustomers);
            this.panelSidePane.Controls.Add(this.btnRepayments);
            this.panelSidePane.Controls.Add(this.btnLoans);
            this.panelSidePane.Controls.Add(this.btnHome);
            this.panelSidePane.Controls.Add(this.userProfilePanel);
            this.panelSidePane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidePane.Location = new System.Drawing.Point(3, 2);
            this.panelSidePane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidePane.Name = "panelSidePane";
            this.panelSidePane.Size = new System.Drawing.Size(261, 696);
            this.panelSidePane.TabIndex = 1;
            // 
            // panelCurrentButton
            // 
            this.panelCurrentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelCurrentButton.Location = new System.Drawing.Point(16, 212);
            this.panelCurrentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCurrentButton.Name = "panelCurrentButton";
            this.panelCurrentButton.Size = new System.Drawing.Size(8, 85);
            this.panelCurrentButton.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = global::XpressLoan.Properties.Resources.ic_logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 625);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(261, 71);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.Image = global::XpressLoan.Properties.Resources.ic_settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 561);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(261, 71);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.Image = global::XpressLoan.Properties.Resources.ic_reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 481);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(261, 80);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "    Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomers.Image = global::XpressLoan.Properties.Resources.ic_customers;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 401);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(261, 80);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "    Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRepayments
            // 
            this.btnRepayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnRepayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepayments.FlatAppearance.BorderSize = 0;
            this.btnRepayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepayments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRepayments.Image = global::XpressLoan.Properties.Resources.ic_payment;
            this.btnRepayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepayments.Location = new System.Drawing.Point(0, 321);
            this.btnRepayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRepayments.Name = "btnRepayments";
            this.btnRepayments.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRepayments.Size = new System.Drawing.Size(261, 80);
            this.btnRepayments.TabIndex = 3;
            this.btnRepayments.Text = "   Repayments";
            this.btnRepayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepayments.UseVisualStyleBackColor = false;
            this.btnRepayments.Click += new System.EventHandler(this.btnRepayments_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoans.Image = global::XpressLoan.Properties.Resources.ic_cashout;
            this.btnLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoans.Location = new System.Drawing.Point(0, 241);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLoans.Size = new System.Drawing.Size(261, 80);
            this.btnLoans.TabIndex = 2;
            this.btnLoans.Text = "   Loans";
            this.btnLoans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoans.UseVisualStyleBackColor = false;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = global::XpressLoan.Properties.Resources.ic_home1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 161);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(261, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.userProfilePanel.Controls.Add(this.lblUsername);
            this.userProfilePanel.Controls.Add(this.pictureBox1);
            this.userProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.userProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Size = new System.Drawing.Size(261, 161);
            this.userProfilePanel.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsername.Location = new System.Drawing.Point(61, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XpressLoan.Properties.Resources.ic_user_bss;
            this.pictureBox1.Location = new System.Drawing.Point(76, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelSidePane, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.PanelWorkAreaContainer, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1184, 700);
            this.tableLayoutPanelMain.TabIndex = 7;
            // 
            // PanelWorkAreaContainer
            // 
            this.PanelWorkAreaContainer.BackColor = System.Drawing.SystemColors.GrayText;
            this.PanelWorkAreaContainer.Controls.Add(this.PanelChildForms);
            this.PanelWorkAreaContainer.Controls.Add(this.panelTitleBar);
            this.PanelWorkAreaContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWorkAreaContainer.Location = new System.Drawing.Point(271, 4);
            this.PanelWorkAreaContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelWorkAreaContainer.Name = "PanelWorkAreaContainer";
            this.PanelWorkAreaContainer.Size = new System.Drawing.Size(909, 692);
            this.PanelWorkAreaContainer.TabIndex = 6;
            // 
            // PanelChildForms
            // 
            this.PanelChildForms.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildForms.Location = new System.Drawing.Point(0, 66);
            this.PanelChildForms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelChildForms.Name = "PanelChildForms";
            this.PanelChildForms.Size = new System.Drawing.Size(909, 626);
            this.PanelChildForms.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaxRestore);
            this.panelTitleBar.Controls.Add(this.btnCloseMain);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(909, 66);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseMain.FlatAppearance.BorderSize = 0;
            this.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMain.Image = global::XpressLoan.Properties.Resources.ic_close_r;
            this.btnCloseMain.Location = new System.Drawing.Point(850, 0);
            this.btnCloseMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(59, 66);
            this.btnCloseMain.TabIndex = 3;
            this.btnCloseMain.UseVisualStyleBackColor = true;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(385, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::XpressLoan.Properties.Resources.ic_min;
            this.btnMinimize.Location = new System.Drawing.Point(732, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(59, 66);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxRestore
            // 
            this.btnMaxRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxRestore.FlatAppearance.BorderSize = 0;
            this.btnMaxRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxRestore.Image = global::XpressLoan.Properties.Resources.ic_max;
            this.btnMaxRestore.Location = new System.Drawing.Point(791, 0);
            this.btnMaxRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaxRestore.Name = "btnMaxRestore";
            this.btnMaxRestore.Size = new System.Drawing.Size(59, 66);
            this.btnMaxRestore.TabIndex = 2;
            this.btnMaxRestore.UseVisualStyleBackColor = true;
            this.btnMaxRestore.Click += new System.EventHandler(this.btnMaxRestore_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1187, 675);
            this.Name = "ParentForm";
            this.Text = "Express Loans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidePane.ResumeLayout(false);
            this.userProfilePanel.ResumeLayout(false);
            this.userProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.PanelWorkAreaContainer.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidePane;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel userProfilePanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnRepayments;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panelCurrentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel PanelWorkAreaContainer;
        private System.Windows.Forms.Panel PanelChildForms;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxRestore;
    }
}