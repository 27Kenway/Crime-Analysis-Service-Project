using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Model
{
    internal class LawEnforcementAgencies
    {
         int agencyID;
         string agencyName;
         string jurisdiction;
         string address;
         string phoneNumber;

        // Default Constructor
        public LawEnforcementAgencies()
        {
            // Initialize default values or leave them as default based on your requirements
        }

        // Parameterized Constructor
        public LawEnforcementAgencies(int agencyID, string agencyName, string jurisdiction,
                                      string address, string phoneNumber)
        {
            this.agencyID = agencyID;
            this.agencyName = agencyName;
            this.jurisdiction = jurisdiction;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // Getters and Setters
        public int AgencyID
        {
            get { return agencyID; }
            set { agencyID = value; }
        }

        public string AgencyName
        {
            get { return agencyName; }
            set { agencyName = value; }
        }

        public string Jurisdiction
        {
            get { return jurisdiction; }
            set { jurisdiction = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
