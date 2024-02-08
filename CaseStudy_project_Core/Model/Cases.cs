using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Model
{
    internal class Cases
    {
        int caseID;
        string description;
        int incidentID;  // Foreign Key

        public Cases()
        {

        }
        public Cases(int caseID, string description, int incidentID)
        {
            this.CaseID = CaseID;
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
        public int Incidentid
        {
            get { return incidentID; }
            set { incidentID = value; }
        }
    }
}