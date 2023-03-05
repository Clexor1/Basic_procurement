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
    public partial class FrmLogin : Form
    {
        public static Employe loggedUser { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Korisnički podaci nisu uneseni!!!","Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                loggedUser = EmployeRepository.GetEmploye(username);
                if(loggedUser != null && loggedUser.CheckPassword(password))
                {
                    Hide();
                   
                        if(loggedUser.IsProjectLeader())
                        {
                        
                        if (RequestRepository.GetRequestsForProjectLeader(loggedUser.Id)!=null)
                            {
                                FrmLeaderRequest frmLeaderRequest = new FrmLeaderRequest();
                                frmLeaderRequest.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Ne postoje zahtjevi koje trebate razriješiti!!!", "Informcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else if(loggedUser.IsEmploye())
                        {
                            FrmCreateRequest createRequest = new FrmCreateRequest();
                            createRequest.ShowDialog();
                        }
                        else if(loggedUser.IsCIP())
                        {
                        FrmDisplayRequests frmDisplayRequests = new FrmDisplayRequests();
                        frmDisplayRequests.ShowDialog();
                        }
                        else if(loggedUser.IsAccounting())
                        {
                            FrmAccountingRequests frmAccountingRequests = new FrmAccountingRequests();
                            frmAccountingRequests.ShowDialog();
                            
                        }
                    

                   
                    Close();

                }
                else
                {
                    MessageBox.Show("Korisnički podaci su krivi!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
