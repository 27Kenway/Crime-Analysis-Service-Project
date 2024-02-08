using Casestudy_Project.Model;
using Casestudy_Project.Repository;

namespace CaseStudy_project_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Incidents newIncident = new Incidents
            {
                IncidentID = 1,
                IncidentType = "Robbery",
                IncidentDate = DateTime.Now,
                Location = "1231-1231",
                Description = "Armed robbery at a convenience store.",
                Status = "Open",
                VictimID = 101,
                SuspectID = 201
            };


            // Create a new incident
            ICrimeAnalysisService crimeAnalysisService = new CrimeAnalysisService();
            crimeAnalysisService.CreateIncident(newIncident);
            // Update the status of an incident
            crimeAnalysisService.UpdateIncidentStatus(1, "Closed");
            List<Incidents> allIncidents = crimeAnalysisService.GetAllIncidents();
            Console.WriteLine("\nAll Incidents in the List:");
            Console.ReadLine();
            foreach (var incident in allIncidents)
            {
                Console.WriteLine($"IncidentID: {incident.IncidentID}, Type: {incident.IncidentType}, Status: {incident.Status}");
                Console.ReadLine();
            }

        }
    }
}
