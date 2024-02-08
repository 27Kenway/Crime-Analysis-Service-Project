using CaseStudy_core.Model;
using CaseStudy_core.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Repository
{
    internal class CrimeCaseRepo:ICrimeCaseRepo
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CrimeCaseRepo()
        {
            connectionString = DBConnection.GetConnectionString();
            cmd = new SqlCommand();
        }
        public Cases CreateCase(string description, int incidentID)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "insert into Cases values(@Description,@IncidentID)";
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@incidentID", incidentID);
                

                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                cmd.Parameters.Clear();


                return new Cases();
                

            }
        }
        public Cases GetCaseDetails(int caseId)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "Select * from Cases Where CaseID = @CaseID";
                cmd.Parameters.AddWithValue("@CaseID", caseId);


                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                cmd.Parameters.Clear();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    int CaseID = reader.GetInt32(reader.GetOrdinal("CaseID"));
                    string Description = reader.GetString(reader.GetOrdinal("Description"));
                    int IncidentID = reader.GetInt32(reader.GetOrdinal("IncidentID"));


                    return new Cases( CaseID,Description ,IncidentID);
                }

            }
        }

        public bool UpdateCaseDetails(Cases updatedCase)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "Update Cases set Description = @Description where CaseID = @CaseID";
                cmd.Parameters.AddWithValue("@Description", updatedCase.Description);
                cmd.Parameters.AddWithValue("@CaseID", updatedCase.CaseID);


                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                cmd.Parameters.Clear();
                int updateCaseDetail = cmd.ExecuteNonQuery();

                return updateCaseDetail == 0 ? false : true;

            }

        }
        public List<Cases> GetAllCases()
        {
            List<Cases> cases = new List<Cases>();
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "Select * from Cases ";

                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                cmd.Parameters.Clear();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int CaseID = reader.GetInt32(reader.GetOrdinal("CaseID"));
                        int IncidentID = reader.GetInt32(reader.GetOrdinal("IncidentID"));
                        string Description = reader.GetString(reader.GetOrdinal("Description"));
                        

                        cases.Add(new Cases(CaseID,  Description, IncidentID));
                        //Console.WriteLine($"incidentID: {incidentID}\n incidentType: {incidentType}\n incidentDate: {incidentDate}\n Location: {location}\n Description: {description}\n status: {status}\n VictimID: {victimID}\n SuspectID: {suspectID} ");
                    }
                }
                return cases;

            }
        }

        
    }
}
