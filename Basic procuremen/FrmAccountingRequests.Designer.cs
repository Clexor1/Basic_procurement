namespace Basic_procuremen
{
    partial class FrmAccountingRequests
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
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.txtFundingSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSelectedRequest = new System.Windows.Forms.ComboBox();
            this.dgvAccountingRequests = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOffers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSelectedOffer = new System.Windows.Forms.ComboBox();
            this.txtRefusalReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountingRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.Location = new System.Drawing.Point(283, 761);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(213, 72);
            this.btnRejectRequest.TabIndex = 52;
            this.btnRejectRequest.Text = "Odbi zahtjev";
            this.btnRejectRequest.UseVisualStyleBackColor = true;
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            // 
            // txtFundingSource
            // 
            this.txtFundingSource.Location = new System.Drawing.Point(156, 411);
            this.txtFundingSource.Name = "txtFundingSource";
            this.txtFundingSource.ReadOnly = true;
            this.txtFundingSource.Size = new System.Drawing.Size(273, 20);
            this.txtFundingSource.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Odabrani zahtjev:";
            // 
            // cboSelectedRequest
            // 
            this.cboSelectedRequest.FormattingEnabled = true;
            this.cboSelectedRequest.Location = new System.Drawing.Point(156, 171);
            this.cboSelectedRequest.Name = "cboSelectedRequest";
            this.cboSelectedRequest.Size = new System.Drawing.Size(194, 21);
            this.cboSelectedRequest.TabIndex = 49;
            this.cboSelectedRequest.SelectedIndexChanged += new System.EventHandler(this.cboSelectedRequest_SelectedIndexChanged_1);
            // 
            // dgvAccountingRequests
            // 
            this.dgvAccountingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountingRequests.Location = new System.Drawing.Point(58, 12);
            this.dgvAccountingRequests.Name = "dgvAccountingRequests";
            this.dgvAccountingRequests.Size = new System.Drawing.Size(687, 144);
            this.dgvAccountingRequests.TabIndex = 48;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(521, 761);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(213, 72);
            this.btnAccept.TabIndex = 47;
            this.btnAccept.Text = "Odobri zahtjev";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(74, 761);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(177, 72);
            this.btnOdustani.TabIndex = 46;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Naziv projekta:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(332, 234);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(170, 20);
            this.txtProjectName.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Izvor financiranja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Opis zahtjeva:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(58, 274);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(687, 113);
            this.txtDescription.TabIndex = 41;
            // 
            // txtApplicant
            // 
            this.txtApplicant.Location = new System.Drawing.Point(58, 234);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.ReadOnly = true;
            this.txtApplicant.Size = new System.Drawing.Size(170, 20);
            this.txtApplicant.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ime i prezime podnositelja zahtjeva:";
            // 
            // dgvOffers
            // 
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.Location = new System.Drawing.Point(58, 456);
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.Size = new System.Drawing.Size(687, 120);
            this.dgvOffers.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Odabrana ponuda:";
            // 
            // cboSelectedOffer
            // 
            this.cboSelectedOffer.FormattingEnabled = true;
            this.cboSelectedOffer.Location = new System.Drawing.Point(156, 594);
            this.cboSelectedOffer.Name = "cboSelectedOffer";
            this.cboSelectedOffer.Size = new System.Drawing.Size(118, 21);
            this.cboSelectedOffer.TabIndex = 54;
            // 
            // txtRefusalReason
            // 
            this.txtRefusalReason.Location = new System.Drawing.Point(62, 642);
            this.txtRefusalReason.Multiline = true;
            this.txtRefusalReason.Name = "txtRefusalReason";
            this.txtRefusalReason.Size = new System.Drawing.Size(687, 113);
            this.txtRefusalReason.TabIndex = 56;
            this.txtRefusalReason.TextChanged += new System.EventHandler(this.txtRejectReason_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Razlog za odbijanje zahtjeva:";
            // 
            // FrmAccountingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 860);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRefusalReason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSelectedOffer);
            this.Controls.Add(this.dgvOffers);
            this.Controls.Add(this.btnRejectRequest);
            this.Controls.Add(this.txtFundingSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSelectedRequest);
            this.Controls.Add(this.dgvAccountingRequests);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtApplicant);
            this.Controls.Add(this.label1);
            this.Name = "FrmAccountingRequests";
            this.Text = "Odobravanje zahtjeva -računovostvo";
            this.Load += new System.EventHandler(this.FrmAccountingRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountingRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.TextBox txtFundingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSelectedRequest;
        private System.Windows.Forms.DataGridView dgvAccountingRequests;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOffers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSelectedOffer;
        private System.Windows.Forms.TextBox txtRefusalReason;
        private System.Windows.Forms.Label label7;
    }
}