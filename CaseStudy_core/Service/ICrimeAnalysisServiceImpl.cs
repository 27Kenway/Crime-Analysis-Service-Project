using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Service
{
    internal  interface ICrimeAnalysisServiceImpl
    {
        //Create Incident
       public  void CreateIncident();

        //Update incident Status
        public void UpdateIncidentStatus();

        //Get a list of incidents within a date range
        public void GetIncidentsInDateRange();


        // Search for incidents based on various criteri
        public void SearchIncident();

        // Generate incident reports
        public void GenerateIncidentReport();

    }
}
