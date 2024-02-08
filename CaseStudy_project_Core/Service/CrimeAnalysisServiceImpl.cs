using Casestudy_Project.Repository;
using CaseStudy_project_Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Service
{
    internal class CrimeAnalysisServiceImpl:ICrimeAnalysisServiceImpl
    {
        readonly ICrimeAnalysisService _crimeAnalysisService;
        public CrimeAnalysisServiceImpl()
        {
            _crimeAnalysisService = new CrimeAnalysisService();
        }
        public void CreateIncident()
        {
            //User user = new User() { Id = 3, Email = "user1@gmail.com", Password = "user3" };
            Incidents incidents = new Incidents();
            Console.WriteLine("Enter IncidentID::");
            incidents.IncidentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter IncidentType::");
            incidents.IncidentType = Console.ReadLine();
            Console.WriteLine("Enter IncidentDate::");
            incidents.IncidentDate = DateTime.Parse (Console.ReadLine());
            Console.WriteLine("Enter Location::");
            incidents.Location = (Console.ReadLine());
            Console.WriteLine("Enter Description::");
            incidents.Description = (Console.ReadLine());
            Console.WriteLine("Enter Status::");
            incidents.Status = (Console.ReadLine());
            Console.WriteLine("Enter VictimID::");
            incidents.VictimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuspectID::");
            incidents.SuspectID = int.Parse(Console.ReadLine());
            try
            {
                bool addUserStatus = _crimeAnalysisService.CreateIncident(incidents);
                if (addUserStatus)
                {
                    Console.WriteLine("CreateIncident successful");
                }
            }
            catch (Exception uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
    }
}
