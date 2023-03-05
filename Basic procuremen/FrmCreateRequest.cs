using Basic_procuremen.Models;
using Basic_procuremen.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_procuremen
{
    public partial class FrmCreateRequest : Form
    {   
        public static List<Employe> ProjectLeader { get; set; }

        public static List<FundingSource> fundingSources { get; set; }

        public static List<Request> leadersRequests { get; set; }
        public FrmCreateRequest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCreateRequest_Load(object sender, EventArgs e)
        {
             fundingSources = FundingSourceRepository.GetFundingSources();
            cboFundingSource.DataSource = fundingSources;
            cboFundingSource.Text = "----Izaberi----";

            ProjectLeader = EmployeRepository.GetProjectLeaders();
            cboProjectLeader.DataSource = ProjectLeader;
            cboProjectLeader.Text = "----Izaberi----";

            

            

            txtApplicant.Text = FrmLogin.loggedUser.ToString();

            if(FrmLogin.loggedUser.IsEmploye())
            {   
                
                if (FrmLogin.loggedUser.IsProjectLeader())
                {
                     leadersRequests = RequestRepository.GetRequestsForProjectLeader(FrmLogin.loggedUser.Id);
                   
                }

            }
            
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            int applicant = FrmLogin.loggedUser.Id;
            string description = txtDescription.Text;
            
            int fundingSource = fundingSources[cboFundingSource.SelectedIndex].Id;
            string project = txtProjectName.Text;
            int projectLeader = ProjectLeader[cboProjectLeader.SelectedIndex].Id;
            bool applicantSignature = true;
            
           
            if(description == "" || project=="")
            {
                MessageBox.Show("Nisu svi podaci uneseni!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                FrmLogin.loggedUser.CreateRequest(applicant, description, fundingSource, project, projectLeader, applicantSignature);
                MessageBox.Show("Uspiješan unos!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboProjectLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
