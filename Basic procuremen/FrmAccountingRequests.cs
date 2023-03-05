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
    public partial class FrmAccountingRequests : Form
    {
        private static List<Request> requests { get; set; }
        private static List<Offer> offers { get; set; }
        
        public FrmAccountingRequests()
        {
            InitializeComponent();
        }

        private void ClearUI()
        {

            txtApplicant.Text = "";
            txtDescription.Text = "";
            txtProjectName.Text = "";
            txtFundingSource.Text = "";
            cboSelectedRequest.Text = "Izaberi zahtjev";
            cboSelectedOffer.Text = "Izaberi ponudu";
        }

        private void FrmAccountingRequests_Load(object sender, EventArgs e)
        {
            requests = RequestRepository.GetRequestsForAccounting();
            dgvAccountingRequests.DataSource = requests;

            /*dgvLeadersRequests.Columns["Id"].DisplayIndex = 0;
            dgvLeadersRequests.Columns["Applicant"].DisplayIndex = 1;
            dgvLeadersRequests.Columns["Description"].DisplayIndex = 2;
            dgvLeadersRequests.Columns["FundingSource"].DisplayIndex = 3;
            dgvLeadersRequests.Columns["Project"].DisplayIndex = 4;
            dgvLeadersRequests.Columns["ProjectLeader"].DisplayIndex = 5;
            dgvLeadersRequests.Columns["ApplicantSignature"].DisplayIndex = 6;*/

            cboSelectedRequest.DataSource = requests;

            offers = OfferRepository.GetOffers();
            dgvOffers.DataSource = offers;
            cboSelectedOffer.DataSource = offers;

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

        private void cboSelectedRequest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowData(cboSelectedRequest.SelectedIndex);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FrmLogin.loggedUser.AddAccountingSignature(true, requests[cboSelectedRequest.SelectedIndex].Id, txtRefusalReason.Text, offers[cboSelectedRequest.SelectedIndex].Id);
            requests = RequestRepository.GetRequestsForAccounting();
            dgvAccountingRequests.DataSource = requests;
            //cboSelectedRequest.DataSource = requests;
            MessageBox.Show("Zahtjev je uspješno odobren!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (requests == null)
            {
                Hide();
                Close();
            }
        }

        private void txtRejectReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            if (txtRefusalReason.Text == "")
            {
                MessageBox.Show("Razlog za odbijanje zahtjeva nije naveden!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmLogin.loggedUser.AddAccountingSignature(false, requests[cboSelectedRequest.SelectedIndex].Id, txtRefusalReason.Text, offers[cboSelectedRequest.SelectedIndex].Id);
                requests = RequestRepository.GetRequestsForAccounting();
                dgvAccountingRequests.DataSource = requests;
                cboSelectedRequest.DataSource = requests;
                ClearUI();
                MessageBox.Show("Zahtjev je uspješno odbijen!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
