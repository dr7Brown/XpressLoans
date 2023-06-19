namespace XpressLoan.Forms
{
    partial class FormLoans
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCol1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavRow = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.tblLoansDataGridView = new System.Windows.Forms.DataGridView();
            this.tblLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpressLoanDBDataSet = new XpressLoan.XpressLoanDBDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxDateType = new System.Windows.Forms.ComboBox();
            this.tblLoansTableAdapter = new XpressLoan.XpressLoanDBDataSetTableAdapters.tblLoansTableAdapter();
            this.tableAdapterManager = new XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelCol1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelNavRow.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(450, 23);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 25);
            label3.TabIndex = 38;
            label3.Text = "Loan Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(14, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 42;
            label1.Text = "Sort By";
            // 
            // panelCol1
            // 
            this.panelCol1.Controls.Add(this.tableLayoutPanel3);
            this.panelCol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCol1.Location = new System.Drawing.Point(4, 4);
            this.panelCol1.Margin = new System.Windows.Forms.Padding(4);
            this.panelCol1.Name = "panelCol1";
            this.panelCol1.Size = new System.Drawing.Size(1113, 717);
            this.panelCol1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelNavRow, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tblLoansDataGridView, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1113, 717);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panelNavRow
            // 
            this.panelNavRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNavRow.Controls.Add(this.tableLayoutPanel4);
            this.panelNavRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavRow.Location = new System.Drawing.Point(4, 4);
            this.panelNavRow.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavRow.Name = "panelNavRow";
            this.panelNavRow.Size = new System.Drawing.Size(1105, 42);
            this.panelNavRow.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnArrowLeft, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnArrowRight, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1101, 38);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLeft.Image = global::XpressLoan.Properties.Resources.ic_arrow_left2;
            this.btnArrowLeft.Location = new System.Drawing.Point(4, 4);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(359, 30);
            this.btnArrowLeft.TabIndex = 16;
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(371, 4);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(359, 30);
            this.txtDate.TabIndex = 15;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowRight.Image = global::XpressLoan.Properties.Resources.ic_arrow_right2;
            this.btnArrowRight.Location = new System.Drawing.Point(738, 4);
            this.btnArrowRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(359, 30);
            this.btnArrowRight.TabIndex = 16;
            this.btnArrowRight.UseVisualStyleBackColor = true;
            this.btnArrowRight.Click += new System.EventHandler(this.btnArrowRight_Click);
            // 
            // tblLoansDataGridView
            // 
            this.tblLoansDataGridView.AllowUserToAddRows = false;
            this.tblLoansDataGridView.AllowUserToDeleteRows = false;
            this.tblLoansDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblLoansDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblLoansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLoansDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLoansDataGridView.Location = new System.Drawing.Point(3, 73);
            this.tblLoansDataGridView.Name = "tblLoansDataGridView";
            this.tblLoansDataGridView.ReadOnly = true;
            this.tblLoansDataGridView.RowHeadersWidth = 51;
            this.tblLoansDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tblLoansDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLoansDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLoansDataGridView.RowTemplate.Height = 24;
            this.tblLoansDataGridView.Size = new System.Drawing.Size(1107, 641);
            this.tblLoansDataGridView.TabIndex = 6;
            this.tblLoansDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLoansDataGridView_CellClick_1);
            this.tblLoansDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tblLoansDataGridView_RowPostPaint_1);
            // 
            // tblLoansBindingSource
            // 
            this.tblLoansBindingSource.DataMember = "tblLoans";
            this.tblLoansBindingSource.DataSource = this.xpressLoanDBDataSet;
            // 
            // xpressLoanDBDataSet
            // 
            this.xpressLoanDBDataSet.DataSetName = "XpressLoanDBDataSet";
            this.xpressLoanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 846);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 725);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panelCol1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1121, 725);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(label1);
            this.panel4.Controls.Add(this.cbxStatus);
            this.panel4.Controls.Add(this.cbxDateType);
            this.panel4.Controls.Add(label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1121, 105);
            this.panel4.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::XpressLoan.Properties.Resources.ic_refresh50;
            this.btnRefresh.Location = new System.Drawing.Point(1018, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 81);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ALL",
            "PENDING",
            "APPROVED",
            "COMPLETED",
            "CANCELLED"});
            this.cbxStatus.Location = new System.Drawing.Point(613, 17);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(216, 37);
            this.cbxStatus.TabIndex = 1;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxLoanType_SelectedIndexChanged);
            // 
            // cbxDateType
            // 
            this.cbxDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDateType.FormattingEnabled = true;
            this.cbxDateType.Items.AddRange(new object[] {
            "DAY",
            "WEEK",
            "MONTH",
            "YEAR"});
            this.cbxDateType.Location = new System.Drawing.Point(139, 16);
            this.cbxDateType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDateType.Name = "cbxDateType";
            this.cbxDateType.Size = new System.Drawing.Size(216, 37);
            this.cbxDateType.TabIndex = 41;
            this.cbxDateType.SelectedIndexChanged += new System.EventHandler(this.cbxDateType_SelectedIndexChanged);
            // 
            // tblLoansTableAdapter
            // 
            this.tblLoansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAccountTableAdapter = null;
            this.tableAdapterManager.tblApplicationsTableAdapter = null;
            this.tableAdapterManager.tblCustomersTableAdapter = null;
            this.tableAdapterManager.tblDepositTableAdapter = null;
            this.tableAdapterManager.tblExpensesTableAdapter = null;
            this.tableAdapterManager.tblLoansTableAdapter = this.tblLoansTableAdapter;
            this.tableAdapterManager.tblRepaymentTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = XpressLoan.XpressLoanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 846);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoans";
            this.ShowInTaskbar = false;
            this.Text = "Loans";
            this.panelCol1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelNavRow.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpressLoanDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCol1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private XpressLoanDBDataSet xpressLoanDBDataSet;
        private System.Windows.Forms.BindingSource tblLoansBindingSource;
        private XpressLoanDBDataSetTableAdapters.tblLoansTableAdapter tblLoansTableAdapter;
        private XpressLoanDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Panel panelNavRow;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cbxDateType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView tblLoansDataGridView;
    }
}