using Basic_procuremen.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_procuremen.Repositories
{
    public class RequestRepository
    {
        public static void InsertData(int Applicant,string Description, int FundingSource, string Project, int ProjectLeader, bool ApplicantSignature)
        {
            string sql = $"INSERT INTO Requests (Applicant,Description,FundingSource,Project,ProjectLeader,ApplicantSignature) VALUES ('{Applicant}','{Description}','{FundingSource}','{Project}','{ProjectLeader}','{ApplicantSignature}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }

        public static List<Request> GetRequestsForProjectLeader(int projectLeader)
        {

            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            List < Request > requests;
            
            string sql = $"SELECT * FROM Requests WHERE ProjectLeader = '{projectLeader}' AND ((LeaderSignature = '0' AND AccountingSignature IS NULL) OR LeaderSignature IS NULL)";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows)
            {
                requests = new List < Request >();
            }
            else
            { requests = null; }
            while (reader.Read())
            {
                
                Request request = CreateObject(reader);
                requests.Add(request);
            }
            reader.Close();
            DB.CloseConnection();

            return requests;
        }


        public static List<Request> GetRequestsForAccounting()
        {

            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            List<Request> requests;

            string sql = "SELECT * FROM Requests WHERE  LeaderSignature = '1' AND (ViceDeanSignature IS NULL AND ( AccountingSignature = '0' OR AccountingSignature IS NULL))";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                requests = new List<Request>();
            }
            else
            { requests = null; }
            while (reader.Read())
            {

                Request request = CreateObject(reader);
                requests.Add(request);
            }
            reader.Close();
            DB.CloseConnection();

            return requests;
        }

        public static List<Request> GetApprovedRequests()
        {

            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            List<Request> requests;

            string sql = "SELECT * FROM Requests WHERE AccountingSignature = '1'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                requests = new List<Request>();
            }
            else
            { requests = null; }
            while (reader.Read())
            {

                Request request = CreateObject(reader);
                requests.Add(request);
            }
            reader.Close();
            DB.CloseConnection();

            return requests;
        }



        public static void AddLeadersSignature(bool LeaderSignature,int id)
        {
            string sql = $"UPDATE Requests SET LeaderSignature = '{LeaderSignature}' WHERE Id = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }
        public static void AddLeadersSignature(bool LeaderSignature, int id,string reason)
        {
            string sql = $"UPDATE Requests SET LeaderSignature = '{LeaderSignature}',LeaderRefusalReason='{reason}' WHERE Id = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }
        public static void AddAccountingSignature(bool accountingSignature, int id, string reason,int  offer)
        {
            string sql = $"UPDATE Requests SET AccountingSignature = '{accountingSignature}',AccountingRefusalReason='{reason}', SelectedOffer = '{offer}' WHERE Id = '{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }

        public static void DelteRequest(int id )
        {
            string sql = $"DELETE  FROM Requests WHERE Id='{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

        }


        private static Request CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            Employe applicant = EmployeRepository.GetEmploye(int.Parse(reader["Applicant"].ToString()));
            string description = reader["Description"].ToString();
            Offer selectedOffer = null;
            if (reader["SelectedOffer"].ToString()!="")
                 selectedOffer = OfferRepository.GetOffer(int.Parse(reader["SelectedOffer"].ToString()));
           
            FundingSource fundingSource = FundingSourceRepository.GetFundingSource(int.Parse(reader["FundingSource"].ToString()));
            string project = reader["Project"].ToString();
            Employe projectLeader = EmployeRepository.GetEmploye(int.Parse(reader["ProjectLeader"].ToString()));
            bool applicantSignature = false;
            if (reader["ApplicantSignature"].ToString() != "")
                applicantSignature = bool.Parse(reader["ApplicantSignature"].ToString());
            bool leaderSignature = false;
            if (reader["LeaderSignature"].ToString()!="")
                leaderSignature = bool.Parse(reader["LeaderSignature"].ToString());
            bool accountingSignature = false;
            if (reader["AccountingSignature"].ToString() != "")
                accountingSignature = bool.Parse(reader["AccountingSignature"].ToString());
            bool viceDeanSignature = false;
            if (reader["ViceDeanSignature"].ToString() != "")
                viceDeanSignature = bool.Parse(reader["ViceDeanSignature"].ToString());
            string leaderRefusalReason = reader["LeaderRefusalReason"].ToString();
            string accountingRefusalReason = reader["AccountingRefusalReason"].ToString(); 
            Request request = new Request
            {
                Id = id,
                Applicant = applicant,
                Description = description,
                SelectedOffer = selectedOffer,
                FundingSource = fundingSource,
                Project = project,
                ProjectLeader = projectLeader,
                ApplicantSignature = applicantSignature,
                LeaderSignature = leaderSignature,
                AccountingSignature = accountingSignature,
                ViceDeanSignature= viceDeanSignature,
                LeaderRefusalReason=leaderRefusalReason,
                AccountingRefusalReason = accountingRefusalReason
                

            };
            return request;



        }
    }
}
