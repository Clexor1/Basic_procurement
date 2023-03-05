using Basic_procuremen.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_procuremen.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Work_place { get; set; }

        public override string ToString()
        {
            return First_Name + " " + Last_Name ;
        }

        public bool CheckPassword(string password)
        {

            return Password == password;
        }

        public void CreateRequest(int Applicant, string Description, int FundingSource, string Project, int ProjectLeader, bool ApplicantSignature)
        {

            RequestRepository.InsertData(Applicant, Description,  FundingSource,  Project,  ProjectLeader,  ApplicantSignature);
        }

        public bool IsEmploye()
        {

            return Work_place == "Nastavnik";
        }
        public bool IsAccounting()
        {

            return Work_place == "Racunovodstvo";
        }
        public bool IsViceDean()
        {

            return Work_place == "Prodekanica";
        }
        public bool IsCIP()
        {

            return Work_place == "CIP";
        }
        public bool IsProjectLeader()
        {
            return Work_place == "Voditelj";
        }

        public void AddLeaderSignature(bool leaderSignature,int id,string reason)
        {   
            if(leaderSignature == true)
                RequestRepository.AddLeadersSignature(leaderSignature,id,null);
            else
                RequestRepository.AddLeadersSignature(leaderSignature, id,reason);
        }

        public void AddAccountingSignature(bool accountingSignature, int id, string reason,int offer)
        {
            if (accountingSignature == true)
                RequestRepository.AddAccountingSignature(accountingSignature, id, null,offer);
            else
                RequestRepository.AddAccountingSignature(accountingSignature, id, reason,offer);
        }

        public void DeleteRequest(int id)
        {

            RequestRepository.DelteRequest(id);
        }
    }

    
}
