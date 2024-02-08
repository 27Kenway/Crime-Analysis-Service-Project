using CaseStudy_project_Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using CaseStudy_project_Core.Utility; 


namespace Casestudy_Project_core.Repository
{
    internal class CrimeAnalysisService : ICrimeAnalysisService
    {
        #region code with list
        private List<Incidents> incidents = new List<Incidents>();

        public bool CreateIncident(Incidents incident)
        {
              
                incidents.Add(incident);

                
                Console.WriteLine($"Incident created successfully. IncidentID: {incident.IncidentID}\nIncidentType: {incident.IncidentType}\nSuspectId:{incident.SuspectID}\nVictionId:{incident.VictimID}\nIncidentDate: {incident.IncidentDate}\nLocation:{incident.Location}\nDescription:{incident.Description}\nStatus: {incident.Status}");
                Console.ReadLine();

                return true;
         
        }
        public bool UpdateIncidentStatus(int incidentID,string newStatus)
        {
            Incidents incidentToUpdate = incidents.Find(i=>i.IncidentID == incidentID);
            if (incidentToUpdate != null)
            {
                incidentToUpdate.Status = newStatus;
                Console.WriteLine($"Incident status updated successfully. new status: {newStatus}");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("IncidentID does not found");
                Console.ReadLine();
                return false;
            }

        }
        public List<Incidents> GetIncidentsInRange(DateTime startDate, DateTime endDate)
        {
            List<Incidents> RangeIncidents = incidents.Where(i => i.IncidentDate>=startDate && i.IncidentDate<=endDate).ToList();
            return RangeIncidents;
        }
            
        public List<Incidents> GetAllIncidents()
        {
            return incidents;
        }
        #endregion
        public string connectionString;
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public CrimeAnalysisService()
        {
            connectionString = DbConnection.GetConnectionString();
            cmd = new SqlCommand();
        }
        public bool CreateIncident(Incidents incident)
        {
            cmd.CommandText = "insert into Incidents value(@incidentID,@incidentType,@incidentDate,@location,@description,@status,@victimID,@suspectID;)";
            cmd.Parameters.AddWithValue("@incidentID", Incidents.incidentID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int adduserStatus=cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return
                true;
        }
    }
}
