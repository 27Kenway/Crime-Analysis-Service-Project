using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Model
{
    internal class Cases
    {
        int caseID;
        string description;
        int incidentID;  // Foreign Key

        public Cases()
        {

        }
        
        public Cases(int caseID, string description, int incidentID )
        {
            this.caseID = caseID;
            this.description = description;
            this.incidentID = incidentID;
        }
        public int CaseID
        {
            get { return caseID; }
            set { caseID = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int IncidentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }
        public override string ToString()
        {
            return $" CaseId: {CaseID} \t Description: {Description}\t incidentID: {IncidentID}\t ";
        }
    }
}
