using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_project_Core.Model
{
    internal class Suspects
    {
         int suspectID;
         string firstName;
         string lastName;
         DateTime dateOfBirth;
         string gender;
         string address;
         string phoneNumber;

        // Default Constructor
        public Suspects()
        {
            
        }

        // Parameterized Constructor
        public Suspects(int suspectID, string firstName, string lastName,
                        DateTime dateOfBirth, string gender, string address, string phoneNumber)
        {
            this.suspectID = suspectID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // Getters and Setters
        public int SuspectID
        {
            get { return suspectID; }
            set { suspectID = value; }
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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
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
