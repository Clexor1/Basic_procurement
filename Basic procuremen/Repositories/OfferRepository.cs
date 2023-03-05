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
    public class OfferRepository
    {
        public static List<Offer> GetOffers()
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            string sql = "SELECT * FROM Offers";
            List<Offer> offers = new List<Offer>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {

                Offer offer = CreateObject(reader);
                offers.Add(offer);

            }
            reader.Close();
            DB.CloseConnection();

            return offers;
        }

        public static Offer GetOffer(int id)
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            string sql = $"SELECT * FROM Offers WHERE id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Offer offer = null;
            if (reader.HasRows)
            {
                reader.Read();
                offer = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return offer;
        }

        private static Offer CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string bidder = reader["Bidder"].ToString();
            float priceWithoutTax = float.Parse(reader["PriceWithoutTax"].ToString());
            float priceWithTax = float.Parse(reader["PriceWithTax"].ToString());
            

            Offer offer = new Offer
            {
                Id = id,
                Bidder = bidder,
                PriceWithoutTax = priceWithoutTax,
                PriceWithTax = priceWithTax,

            };
            return offer;
        }
    }
}
