using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pagatpat;
using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-BJNN5E1; Initial Catalog = pagatpat; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<PAGATPAT> Table_1()
        {
            var selectStatement = "SELECT * FROM Table_1";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var PAGATPATS = new List<PAGATPAT>();

            while (reader.Read())
            {
                PAGATPATS.Add(new PAGATPAT
                {
                    artistName = reader["artistName"].ToString(),
                    artistLanguage = reader["artistLanguage"].ToString(),
                    companyName = reader["companyName"].ToString(),
                 
                });
            }

            sqlConnection.Close();
            return PAGATPATS;
        }
    }
}


