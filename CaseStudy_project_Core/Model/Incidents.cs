using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Model
{
    internal class Incidents
    {
         int incidentID;
         string incidentType;
         DateTime incidentDate;
         string location;
         string description;
         string status;
         int victimID;
         int suspectID;

        // Default Constructor
        public Incidents()
        {
           
        }

        // Parameterized Constructor
        public Incidents(int incidentID, string incidentType, DateTime incidentDate,
                         String location, string description,
                         string status, int victimID, int suspectID)
        {
            this.incidentID = incidentID;
            this.incidentType = incidentType;
            this.incidentDate = incidentDate;
            this.location = location;
            this.description = description;
            this.status = status;
            this.victimID = victimID;
            this.suspectID = suspectID;
        }

        // Getters and Setters
        public int IncidentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

        public string IncidentType
        {
            get { return incidentType; }
            set { incidentType = value; }
        }

        public DateTime IncidentDate
        {
            get { return incidentDate; }
            set { incidentDate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int VictimID
        {
            get { return victimID; }
            set { victimID = value; }
        }

        public int SuspectID
        {
            get { return suspectID; }
            set { suspectID = value; }
        }
    }
}
