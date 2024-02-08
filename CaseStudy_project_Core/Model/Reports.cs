using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Model
{
    internal class Reports
    {
         int reportID;
         int incidentID;  // Foreign Key
         int reportingOfficer;  // Foreign Key
         DateTime reportDate;
         string reportDetails;
         string status;

        // Default Constructor
        public Reports()
        {
            
        }

        // Parameterized Constructor
        public Reports(int reportID, int incidentID, int reportingOfficer,
                       DateTime reportDate, string reportDetails, string status)
        {
            this.reportID = reportID;
            this.incidentID = incidentID;
            this.reportingOfficer = reportingOfficer;
            this.reportDate = reportDate;
            this.reportDetails = reportDetails;
            this.status = status;
        }

        // Getters and Setters
        public int ReportID
        {
            get { return reportID; }
            set { reportID = value; }
        }

        public int IncidentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

        public int ReportingOfficer
        {
            get { return reportingOfficer; }
            set { reportingOfficer = value; }
        }

        public DateTime ReportDate
        {
            get { return reportDate; }
            set { reportDate = value; }
        }

        public string ReportDetails
        {
            get { return reportDetails; }
            set { reportDetails = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
