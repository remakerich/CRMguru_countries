using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;

namespace CountryBrowser
{
    public static class DataAccess
    {
        private static IDbConnection OpenConnection()
        {
            return 
                new System.Data.SqlClient.SqlConnection
                (ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
        }

        public static List<CountryModel> ShowAllCountries()
        {
            using (IDbConnection connection = DataAccess.OpenConnection())
            {
                return connection.Query<CountryModel>("dbo.get_all_countries").ToList();
            }
        }

        public static void UpdateCountry(CountryModel country)
        {
            using (IDbConnection connection = DataAccess.OpenConnection())
            {
                connection.Execute(
                    "dbo.insert_update_country " +
                    "@NAME, @ALPHA2CODE, @CAPITAL, @AREA, @POPULATION, @REGION",
                    country);
            }
        }
    }
}
