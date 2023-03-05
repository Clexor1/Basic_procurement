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
    public class EmployeRepository
    {
        public static Employe GetEmploye(int id)
        {
            string sql = $"SELECT * FROM Employes WHERE Id= '{id}'";
            return FetchEmploye(sql);
        }

        public static Employe GetEmploye(string username)
        {
            string sql = $"SELECT * FROM Employes WHERE Username = '{username}'";
            return FetchEmploye(sql);
        }

        public static Employe FetchEmploye(string sql)
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Employe employe = null;
            if(reader.HasRows)
            {
                reader.Read();
                employe = CreateObject(reader);
                reader.Close();
            }
               DB.CloseConnection();

            return employe;
        }

        public static List<Employe> GetEmployes()
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            string sql = "SELECT * FROM Employes";
            List<Employe> employes = new List<Employe>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            
            while (reader.Read())
            {
       
                Employe employe = CreateObject(reader);
                employes.Add(employe);
                
            }
            reader.Close();
            DB.CloseConnection();

            return employes;
        }


        public static List<Employe> GetProjectLeaders()
        {
            DB.SetConfiguration("ababic20_DB", "ababic20", "'v;7$hn20'");
            string sql = "SELECT * FROM Employes WHERE Work_place = 'Voditelj'";
            List<Employe> employes = new List<Employe>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {

                Employe employe = CreateObject(reader);
                employes.Add(employe);

            }
            reader.Close();
            DB.CloseConnection();

            return employes;
        }


        private static Employe CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["First_name"].ToString();
            string lastName = reader["Last_name"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string workPlace = reader["Work_place"].ToString();

            Employe employe = new Employe
            {
                Id = id,
                First_Name = firstName,
                Last_Name = lastName,
                Username = username,
                Password = password,
                Work_place = workPlace

            };
            return employe;

        }

        

    }
}
