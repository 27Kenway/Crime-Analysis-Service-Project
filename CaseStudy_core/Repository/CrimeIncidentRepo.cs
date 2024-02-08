using CaseStudy_core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CaseStudy_core.Utility;
using System.Collections.ObjectModel;

namespace CaseStudy_core.Repository
{
    
        public class CrimeIncidentRepo : ICrimeIncidentRepo
        {
            #region code with list
            //private List<Incidents> incidents = new List<Incidents>();

            //public bool CreateIncident(Incidents incident)
            //{

            //    incidents.Add(incident);


            //    Console.WriteLine($"Incident created successfully. IncidentID: {incident.IncidentID}\nIncidentType: {incident.IncidentType}\nSuspectId:{incident.SuspectID}\nVictionId:{incident.VictimID}\nIncidentDate: {incident.IncidentDate}\nLocation:{incident.Location}\nDescription:{incident.Description}\nStatus: {incident.Status}");
            //    Console.ReadLine();

            //    return true;

            //}
            //public bool UpdateIncidentStatus(int incidentID, string newStatus)
            //{
            //    Incidents incidentToUpdate = incidents.Find(i => i.IncidentID == incidentID);
            //    if (incidentToUpdate != null)
            //    {
            //        incidentToUpdate.Status = newStatus;
            //        Console.WriteLine($"Incident status updated successfully. new status: {newStatus}");
            //        Console.ReadLine();
            //        return true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("IncidentID does not found");
            //        Console.ReadLine();
            //        return false;
            //    }

            //}
            //public List<Incidents> GetIncidentsInRange(DateTime startDate, DateTime endDate)
            //{
            //    List<Incidents> RangeIncidents = incidents.Where(i => i.IncidentDate >= startDate && i.IncidentDate <= endDate).ToList();
            //    return RangeIncidents;
            //}

            //public List<Incidents> GetAllIncidents()
            //{
            //    return incidents;
            //}
            #endregion
            public string connectionString;
            SqlConnection sqlconnection = null;
            SqlCommand cmd = null;
            public CrimeIncidentRepo()
            {
                connectionString = DBConnection.GetConnectionString();
                cmd  = new SqlCommand();
            }
        public bool CreateIncident(Incidents incident)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {

                cmd.CommandText = "insert into Incidents values(@incidentType,@incidentDate,@location,@description,@status,@victimID,@suspectID)";
                cmd.Parameters.AddWithValue("@incidentType", incident.IncidentType);
                cmd.Parameters.AddWithValue("@incidentDate", incident.IncidentDate);
                cmd.Parameters.AddWithValue("@location", incident.Location);
                cmd.Parameters.AddWithValue("@description", incident.Description);
                cmd.Parameters.AddWithValue("@status", incident.Status);
                cmd.Parameters.AddWithValue("@victimID", incident.VictimID);
                cmd.Parameters.AddWithValue("@suspectID", incident.SuspectID);

                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                
                int addIncident = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                return addIncident==0 ? false : true;
                
            }
        }

        public bool UpdateIncidentStatus(string newStatus, int incidentId)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {

                cmd.CommandText = "Update Incidents set Status = @status where incidentId = @incidentID";
                cmd.Parameters.AddWithValue("@incidentID", incidentId);
                cmd.Parameters.AddWithValue("@status", newStatus);
                

                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                
                int updateIncidentStatus = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return updateIncidentStatus == 0 ? false : true;

            }

        }
        
        public Collection<Incidents> GetIncidentsInDateRange(DateTime startDate, DateTime endDate)
        {
            Collection<Incidents> incidents = new Collection<Incidents>();
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {

                cmd.CommandText = "Select * from Incidents Where incidentDate between @startDate and @endDate" ;
                
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);



                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        

                        int incidentID = reader.GetInt32(reader.GetOrdinal("incidentID"));
                        string incidentType = reader.GetString(reader.GetOrdinal("incidentType"));
                        DateTime incidentDate = reader.GetDateTime(reader.GetOrdinal("incidentDate"));
                        string location = reader.GetString(reader.GetOrdinal("location"));
                        string description = reader.GetString(reader.GetOrdinal("description"));
                        string status = reader.GetString(reader.GetOrdinal("status"));
                        int victimID = reader.GetInt32(reader.GetOrdinal("victimID"));
                        int suspectID = reader.GetInt32(reader.GetOrdinal("suspectID"));

                        incidents.Add(new Incidents(incidentID,incidentType,incidentDate,location,description,status,victimID,suspectID));
                        //Console.WriteLine($"incidentID: {incidentID}\n incidentType: {incidentType}\n incidentDate: {incidentDate}\n Location: {location}\n Description: {description}\n status: {status}\n VictimID: {victimID}\n SuspectID: {suspectID} ");
                    }
                }
                cmd.Parameters.Clear();
                return incidents;

            }

        }
        public Collection<Incidents> SearchIncident(string searchincidentType)
        {
            Collection<Incidents> incidents = new Collection<Incidents>();
            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "Select * from Incidents Where incidentType = @incidentType";
                cmd.Parameters.AddWithValue("@incidentType", searchincidentType);
                

                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        int incidentID = reader.GetInt32(reader.GetOrdinal("incidentID"));
                        string incidentType = reader.GetString(reader.GetOrdinal("incidentType"));
                        DateTime incidentDate = reader.GetDateTime(reader.GetOrdinal("incidentDate"));
                        string location = reader.GetString(reader.GetOrdinal("location"));
                        string description = reader.GetString(reader.GetOrdinal("description"));
                        string status = reader.GetString(reader.GetOrdinal("status"));
                        int victimID = reader.GetInt32(reader.GetOrdinal("victimID"));
                        int suspectID = reader.GetInt32(reader.GetOrdinal("suspectID"));

                        incidents.Add(new Incidents(incidentID, incidentType, incidentDate, location, description, status, victimID, suspectID));
                        //Console.WriteLine($"incidentID: {incidentID}\n incidentType: {incidentType}\n incidentDate: {incidentDate}\n Location: {location}\n Description: {description}\n status: {status}\n VictimID: {victimID}\n SuspectID: {suspectID} ");
                    }
                }
                cmd.Parameters.Clear();
                return incidents;

            }

        }

        public Reports GenerateIncidentReport(Incidents incidents)
        {

            using (SqlConnection sqlconnection = new SqlConnection(connectionString))
            {


                cmd.CommandText = "Select * from Reports Where incidentID = @incidentID";
                cmd.Parameters.AddWithValue("@incidentID", incidents.IncidentID);


                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    int reportID = reader.GetInt32(reader.GetOrdinal("ReportID"));
                    int incidentID = reader.GetInt32(reader.GetOrdinal("IncidentID"));
                    int reportingOfficer = reader.GetInt32(reader.GetOrdinal("ReportingOfficer"));
                    DateTime reportDate = reader.GetDateTime(reader.GetOrdinal("ReportDate"));
                    string reportDetail = reader.GetString(reader.GetOrdinal("ReportDetails"));
                    string status = reader.GetString(reader.GetOrdinal("Status"));
                    return new Reports(reportID, incidentID, reportingOfficer, reportDate, reportDetail, status);
                }
                cmd.Parameters.Clear();
            }
        }
    }
}
