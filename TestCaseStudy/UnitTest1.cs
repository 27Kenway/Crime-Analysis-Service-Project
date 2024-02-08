using CaseStudy_core.Model;
using CaseStudy_core.Service;
using CaseStudy_core.Repository;
namespace TestCaseStudy
{
    [TestFixture]
    public class Tests
    {

        [Test]
        
        public void Test_Incident_Creation()
        {
            //Assign
            CrimeIncidentRepo incidentRepo = new CrimeIncidentRepo();
            Incidents expectedIncident = new Incidents();
            {
                expectedIncident.IncidentType = "Abhi";
                expectedIncident.IncidentDate = DateTime.Parse("2023/02/05");
                expectedIncident.Location = "13.1233-32.2332";
                expectedIncident.Description = "Necklace";
                expectedIncident.Status = "Open";
                expectedIncident.VictimID = 104;
                expectedIncident.SuspectID = 303;

            }
            //Act
            bool result = incidentRepo.CreateIncident(expectedIncident);

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void Test_Update_Incident_Status()
        {
            CrimeIncidentRepo incidentRepo = new CrimeIncidentRepo();
            Incidents incidentStatus = new Incidents
            {
                IncidentID = 512,
                Status = "Closed"
            };


            //Act
            bool result = incidentRepo.UpdateIncidentStatus(incidentStatus.Status, incidentStatus.IncidentID);
            //Assert
            Assert.IsTrue(result, "InvalidStatus");
            
            
        }
        

    }
}