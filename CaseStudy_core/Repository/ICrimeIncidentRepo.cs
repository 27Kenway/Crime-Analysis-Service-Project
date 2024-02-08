using CaseStudy_core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Repository
{
    internal interface ICrimeIncidentRepo
    {
        // Create a new incident
        bool CreateIncident(Incidents incident);


        // Update the status of an incident
        bool UpdateIncidentStatus(string newStatus, int incidentId);

        //Get a list of incidents within a data range
        Collection<Incidents> GetIncidentsInDateRange(DateTime startDate, DateTime endDate);

        // Search for incidents based on various criteria
        Collection<Incidents> SearchIncident(string searchincidentType);

        // Generate incident reports
        Reports GenerateIncidentReport(Incidents incidents);




    }
}
