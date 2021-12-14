using ParametrizationApp.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ParametrizationApp.WinForms.Repositories
{
    public class ParametrizationRepository
    {
        public Parametrization ReadParametrization()
        {
            Parametrization parametrization = new Parametrization(); 

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("ReadParametrization", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    parametrization = new Parametrization(
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        reader["Email"].ToString(),
                        reader["InputPath"].ToString(),
                        reader["OutputPath"].ToString(),
                        Convert.ToInt32(reader["MinutesBeforeIntegration"])
                        );
                }
            }

            return parametrization;

        }
    }
}
