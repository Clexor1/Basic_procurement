namespace Basic_procuremen
{
    partial class FrmCreateRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFundingSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProjectLeader = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime podnositelja zahtjeva:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApplicant
            // 
            this.txtApplicant.Location = new System.Drawing.Point(28, 44);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.ReadOnly = true;
            this.txtApplicant.Size = new System.Drawing.Size(170, 20);
            this.txtApplicant.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(28, 84);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(311, 113);
            this.txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis zahtjeva:";
            // 
            // cboFundingSource
            // 
            this.cboFundingSource.FormattingEnabled = true;
            this.cboFundingSource.Location = new System.Drawing.Point(132, 299);
            this.cboFundingSource.Name = "cboFundingSource";
            this.cboFundingSource.Size = new System.Drawing.Size(207, 21);
            this.cboFundingSource.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izvor financiranja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Naziv projekta:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(117, 216);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(170, 20);
            this.txtProjectName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ime voditelja:";
            // 
            // cboProjectLeader
            // 
            this.cboProjectLeader.FormattingEnabled = true;
            this.cboProjectLeader.Location = new System.Drawing.Point(108, 258);
            this.cboProjectLeader.Name = "cboProjectLeader";
            this.cboProjectLeader.Size = new System.Drawing.Size(132, 21);
            this.cboProjectLeader.TabIndex = 13;
            this.cboProjectLeader.SelectedIndexChanged += new System.EventHandler(this.cboProjectLeader_SelectedIndexChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(28, 348);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 72);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(172, 348);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(167, 72);
            this.btnSendRequest.TabIndex = 15;
            this.btnSendRequest.Text = "Podnesi zahtjev";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // FrmCreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 446);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cboProjectLeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.cboFundingSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtApplicant);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateRequest";
            this.Text = "Kreiraj zahtjev";
            this.Load += new System.EventHandler(this.FrmCreateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFundingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProjectLeader;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSendRequest;
    }
}