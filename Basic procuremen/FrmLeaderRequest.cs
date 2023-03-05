using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic_procuremen.Models;
using Basic_procuremen.Repositories;

namespace Basic_procuremen
{
    public partial class FrmLeaderRequest : Form
    {
        private static List<Request> requests {get;set;}
        public FrmLeaderRequest()
        {
            InitializeComponent();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClearUI()
        {

            txtApplicant.Text = "";
            txtDescription.Text = "";
            txtProjectName.Text = "";
            txtFundingSource.Text = "";
            cboSelectedRequest.Text = "Izaberi zahtjev";
        }
        private void FrmLeaderRequest_Load(object sender, EventArgs e)
        {
            requests =   RequestRepository.GetRequestsForProjectLeader(FrmLogin.loggedUser.Id);
            dgvLeadersRequests.DataSource = requests;

            dgvLeadersRequests.Columns["Id"].DisplayIndex = 0;
            dgvLeadersRequests.Columns["Applicant"].DisplayIndex = 1;
            dgvLeadersRequests.Columns["Description"].DisplayIndex = 2;
            dgvLeadersRequests.Columns["FundingSource"].DisplayIndex = 3;
            dgvLeadersRequests.Columns["Project"].DisplayIndex = 4;
            dgvLeadersRequests.Columns["ProjectLeader"].DisplayIndex = 5;
            dgvLeadersRequests.Columns["ApplicantSignature"].DisplayIndex = 6;

            cboSelectedRequest.DataSource = requests;
            
            ClearUI();

        }

        private void ShowData(int selectedItem)
        {   
            Request current = requests[selectedItem];
            txtApplicant.Text = current.Applicant.ToString();
            txtDescription.Text = current.Description;
            txtProjectName.Text = current.Project;
            txtFundingSource.Text = current.FundingSource.ToString();
        }

        

        private void cboSelectedRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData(cboSelectedRequest.SelectedIndex);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FrmLogin.loggedUser.AddLeaderSignature(true, requests[cboSelectedRequest.SelectedIndex].Id, txtRefusalReason.Text);
            FrmLeaderRequest frmLeaderRequest = new FrmLeaderRequest();
            requests = RequestRepository.GetRequestsForProjectLeader(FrmLogin.loggedUser.Id);
            dgvLeadersRequests.DataSource = requests;
            //cboSelectedRequest.DataSource = requests;
            MessageBox.Show("Zahtjev je uspješno odobren!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (requests == null)
            {
                Hide();
                Close();
            }

        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {   
            if(txtRefusalReason.Text=="")
            {
                MessageBox.Show("Razlog za odbijanje zahtjeva nije naveden!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmLogin.loggedUser.AddLeaderSignature(false, requests[cboSelectedRequest.SelectedIndex].Id, txtRefusalReason.Text);
                FrmLeaderRequest frmLeaderRequest = new FrmLeaderRequest();
                requests = RequestRepository.GetRequestsForProjectLeader(FrmLogin.loggedUser.Id);
                dgvLeadersRequests.DataSource = requests;
                cboSelectedRequest.DataSource = requests;
                ClearUI();
                MessageBox.Show("Zahtjev je uspješno odbijen!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            


        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {

        }
    }
}
 