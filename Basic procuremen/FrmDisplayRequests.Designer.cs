namespace Basic_procuremen
{
    partial class FrmDisplayRequests
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
            this.dgvApprovedRequests = new System.Windows.Forms.DataGridView();
            this.cboRequest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApprovedRequests
            // 
            this.dgvApprovedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprovedRequests.Location = new System.Drawing.Point(16, 19);
            this.dgvApprovedRequests.Name = "dgvApprovedRequests";
            this.dgvApprovedRequests.Size = new System.Drawing.Size(775, 283);
            this.dgvApprovedRequests.TabIndex = 0;
            // 
            // cboRequest
            // 
            this.cboRequest.FormattingEnabled = true;
            this.cboRequest.Location = new System.Drawing.Point(177, 318);
            this.cboRequest.Name = "cboRequest";
            this.cboRequest.Size = new System.Drawing.Size(170, 21);
            this.cboRequest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi zahtjev koji želiš izbrisat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Izbriši zahtjev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDisplayRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRequest);
            this.Controls.Add(this.dgvApprovedRequests);
            this.Name = "FrmDisplayRequests";
            this.Text = "FrmDisplayRequests";
            this.Load += new System.EventHandler(this.FrmDisplayRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprovedRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApprovedRequests;
        private System.Windows.Forms.ComboBox cboRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}