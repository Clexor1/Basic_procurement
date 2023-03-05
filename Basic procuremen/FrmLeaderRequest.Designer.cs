namespace Basic_procuremen
{
    partial class FrmLeaderRequest
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLeadersRequests = new System.Windows.Forms.DataGridView();
            this.cboSelectedRequest = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFundingSource = new System.Windows.Forms.TextBox();
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.txtRefusalReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeadersRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(480, 597);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(213, 72);
            this.btnAccept.TabIndex = 31;
            this.btnAccept.Text = "Odobri zahtjev";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(33, 597);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(177, 72);
            this.btnOdustani.TabIndex = 30;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Naziv projekta:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(302, 228);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(170, 20);
            this.txtProjectName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Izvor financiranja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Opis zahtjeva:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(28, 268);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(687, 113);
            this.txtDescription.TabIndex = 19;
            // 
            // txtApplicant
            // 
            this.txtApplicant.Location = new System.Drawing.Point(28, 228);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.ReadOnly = true;
            this.txtApplicant.Size = new System.Drawing.Size(170, 20);
            this.txtApplicant.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ime i prezime podnositelja zahtjeva:";
            // 
            // dgvLeadersRequests
            // 
            this.dgvLeadersRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeadersRequests.Location = new System.Drawing.Point(28, 6);
            this.dgvLeadersRequests.Name = "dgvLeadersRequests";
            this.dgvLeadersRequests.Size = new System.Drawing.Size(687, 144);
            this.dgvLeadersRequests.TabIndex = 32;
            // 
            // cboSelectedRequest
            // 
            this.cboSelectedRequest.FormattingEnabled = true;
            this.cboSelectedRequest.Location = new System.Drawing.Point(126, 165);
            this.cboSelectedRequest.Name = "cboSelectedRequest";
            this.cboSelectedRequest.Size = new System.Drawing.Size(194, 21);
            this.cboSelectedRequest.TabIndex = 33;
            this.cboSelectedRequest.SelectedIndexChanged += new System.EventHandler(this.cboSelectedRequest_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Odabrani zahtjev:";
            // 
            // txtFundingSource
            // 
            this.txtFundingSource.Location = new System.Drawing.Point(126, 405);
            this.txtFundingSource.Name = "txtFundingSource";
            this.txtFundingSource.ReadOnly = true;
            this.txtFundingSource.Size = new System.Drawing.Size(273, 20);
            this.txtFundingSource.TabIndex = 35;
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.Location = new System.Drawing.Point(242, 597);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(213, 72);
            this.btnRejectRequest.TabIndex = 36;
            this.btnRejectRequest.Text = "Odbi zahtjev";
            this.btnRejectRequest.UseVisualStyleBackColor = true;
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            // 
            // txtRefusalReason
            // 
            this.txtRefusalReason.Location = new System.Drawing.Point(33, 463);
            this.txtRefusalReason.Multiline = true;
            this.txtRefusalReason.Name = "txtRefusalReason";
            this.txtRefusalReason.Size = new System.Drawing.Size(687, 113);
            this.txtRefusalReason.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Razlog odbijanja:";
            // 
            // FrmLeaderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 708);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRefusalReason);
            this.Controls.Add(this.btnRejectRequest);
            this.Controls.Add(this.txtFundingSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSelectedRequest);
            this.Controls.Add(this.dgvLeadersRequests);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtApplicant);
            this.Controls.Add(this.label1);
            this.Name = "FrmLeaderRequest";
            this.Text = "Odobravanje zahtjeva";
            this.Load += new System.EventHandler(this.FrmLeaderRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeadersRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLeadersRequests;
        private System.Windows.Forms.ComboBox cboSelectedRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFundingSource;
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.TextBox txtRefusalReason;
        private System.Windows.Forms.Label label3;
    }
}