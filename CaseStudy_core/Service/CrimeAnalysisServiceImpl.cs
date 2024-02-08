using CaseStudy_core.Exceptions;
using CaseStudy_core.Model;
using CaseStudy_core.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Service
{
    internal class CrimeAnalysisServiceImpl:ICrimeAnalysisServiceImpl
    {
        readonly ICrimeIncidentRepo _crimeAnalysisService;
        public CrimeAnalysisServiceImpl()
        {
            _crimeAnalysisService = new CrimeIncidentRepo();
        }
        public void CreateIncident()
        {
            
            Incidents incidents = new Incidents();
            Console.WriteLine("Enter IncidentType::");
            incidents.IncidentType = Console.ReadLine();
            Console.WriteLine("Enter IncidentDate::");
            incidents.IncidentDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Location::");
            incidents.Location = Console.ReadLine();
            Console.WriteLine("Enter Description::");
            incidents.Description = Console.ReadLine();
            Console.WriteLine("Enter Status::");
            incidents.Status = Console.ReadLine();
            Console.WriteLine("Enter VictimID::");
            incidents.VictimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuspectID::");
            incidents.SuspectID = int.Parse(Console.ReadLine());
            
                bool addUserStatus = _crimeAnalysisService.CreateIncident(incidents);
                if (addUserStatus)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Create Incident successful");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Create Incident Unsuccessful");
                }
           
        }
        public void UpdateIncidentStatus()
        {
            Console.WriteLine("Enter IncidentID::");
            int IncidentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated status(Open,Closed)");
            string Status = Console.ReadLine();
            
                bool updateUserStatus = _crimeAnalysisService.UpdateIncidentStatus(Status , IncidentID);
                if (updateUserStatus)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Update Incident successful");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Update Incident Unsuccessful");
                }
            



        }
        public void GetIncidentsInDateRange()
        {
            Console.WriteLine("Enter StartDate to Get the List of Incident::");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter EndDate to Get the List of Incident");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            
                Collection<Incidents> getIncidentsInDateRange = _crimeAnalysisService.GetIncidentsInDateRange(startDate,endDate);
                if (getIncidentsInDateRange.Any())
                {
                    foreach (Incidents obj in getIncidentsInDateRange)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(obj.ToString());
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No record found");
                }

        }
        public void SearchIncident()
        {
            Console.WriteLine("Enter IncidentType to Search from Incident::");
            string searchincidentType = Console.ReadLine();
            
            
                Collection<Incidents> SearchIncident = _crimeAnalysisService.SearchIncident(searchincidentType);
                if (SearchIncident.Any())
                {
                    foreach(Incidents obj in SearchIncident)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(obj.ToString());
                    }
                }
                else
                {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No record found");
                }

        }

        public void GenerateIncidentReport()
        {
            Console.WriteLine("Enter IncidentID::");
            int incidentID = int.Parse(Console.ReadLine());
            Incidents incidents = new Incidents(incidentID);
            
                Reports generateIncidentReport = _crimeAnalysisService.GenerateIncidentReport(incidents);
                if (generateIncidentReport.Equals(null))
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No record found");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine(generateIncidentReport.ToString());
                }
            
        }
    }
}
