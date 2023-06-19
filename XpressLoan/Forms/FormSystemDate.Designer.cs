namespace XpressLoan.Forms
{
    partial class FormSystemDate
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
            this.txtError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtError
            // 
            this.txtError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(255, 348);
            this.txtError.Margin = new System.Windows.Forms.Padding(100, 4, 4, 4);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(744, 74);
            this.txtError.TabIndex = 53;
            this.txtError.Text = "Wrong system Date.  Check date settings";
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtError.TextChanged += new System.EventHandler(this.txtError_TextChanged);
            // 
            // FormSystemDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 745);
            this.Controls.Add(this.txtError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSystemDate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtError;
    }
}