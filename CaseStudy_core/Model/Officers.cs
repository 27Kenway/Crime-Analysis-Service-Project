using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Model
{
    internal class Officers
    {
        int officerID;
        string firstName;
        string lastName;
        string badgeNumber;
        string rank;
        string contactInformation;
        int agencyID;

        // Default Constructor
        public Officers()
        {

        }

        // Parameterized Constructor
        public Officers(int officerID, string firstName, string lastName,
                        string badgeNumber, string rank, string contactInformation, int agencyID)
        {
            this.officerID = officerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.badgeNumber = badgeNumber;
            this.rank = rank;
            this.contactInformation = contactInformation;
            this.agencyID = agencyID;
        }

        // Getters and Setters
        public int OfficerID
        {
            get { return officerID; }
            set { officerID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string BadgeNumber
        {
            get { return badgeNumber; }
            set { badgeNumber = value; }
        }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string ContactInformation
        {
            get { return contactInformation; }
            set { contactInformation = value; }
        }

        public int AgencyID
        {
            get { return agencyID; }
            set { agencyID = value; }
        }
    }
}
