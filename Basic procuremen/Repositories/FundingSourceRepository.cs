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
    public class FundingSourceRepository
    {
        public static FundingSource GetFundingSource(int id)
        {   
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            string sql = $"SELECT * FROM FundingSources WHERE id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            FundingSource fundingSource = null;
            if (reader.HasRows)
            {
                reader.Read();
                fundingSource = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return fundingSource;
        }


        public static List<FundingSource> GetFundingSources()
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            List<FundingSource> fundingSources = new List<FundingSource>();
            string sql = "SELECT * FROM FundingSources";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            
            while (reader.Read())
            {

                FundingSource fundingSource = CreateObject(reader);
                fundingSources.Add(fundingSource);
            }
            reader.Close();
            DB.CloseConnection();

            return fundingSources;
        }


        private static FundingSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string fundingType = reader["Funding_type"].ToString();
            float fundingAmount = float.Parse(reader["Funding_amount"].ToString());


            FundingSource employe = new FundingSource
            {
                Id = id,
                FundingType = fundingType,
                FundingAmount = fundingAmount,

            };
            return employe;
        }
    }
}
