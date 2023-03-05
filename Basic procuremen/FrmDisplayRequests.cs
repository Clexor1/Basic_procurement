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
    public partial class FrmDisplayRequests : Form
    {
        public static List<Request> approveRequests {get; set;}
        public FrmDisplayRequests()
        {
            InitializeComponent();
        }

        private void FrmDisplayRequests_Load(object sender, EventArgs e)
        {
            approveRequests = RequestRepository.GetApprovedRequests();
            dgvApprovedRequests.DataSource = approveRequests;
            cboRequest.DataSource= approveRequests;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin.loggedUser.DeleteRequest(approveRequests[cboRequest.SelectedIndex].Id);
            approveRequests = RequestRepository.GetApprovedRequests();
            dgvApprovedRequests.DataSource = approveRequests;
            cboRequest.DataSource = approveRequests;
            MessageBox.Show("Zahtjev je uspješno izbrisan!!!", "Inforamcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (approveRequests==null)
            {
                Hide();
                Close();
            }
        }
    }
}
