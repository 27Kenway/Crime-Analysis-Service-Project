using CaseStudy_project_Core.Model;
using Casestudy_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy_Project.Repository
{
    internal interface ICrimeAnalysisService
    {
        // Create a new incident
        bool CreateIncident(Incidents incident);
        //List<Incidents> GetAllIncidents();

        // Update the status of an incident
        bool UpdateIncidentStatus(int incidentId, string newStatus);

        //Get a list of incidents within a data range
        //List<Incidents> GetIncidentsInRange(DateTime startDate,DateTime endDate);
        
    }
}
;