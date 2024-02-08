using CaseStudy_core.Model;
using CaseStudy_core.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Service
{
    internal class CrimeCaseService : ICrimeCaseService
    {
        readonly ICrimeCaseRepo _crimeCaseService;
        public CrimeCaseService()
        {
            _crimeCaseService = new CrimeCaseRepo();
        }
        public void CreateCase()
        {
            Console.WriteLine("Enter Case Description::");
            string Description = (Console.ReadLine());
            Console.WriteLine("Enter IncidentID::");
            int IncidentID = int.Parse(Console.ReadLine());
            
                Cases addCase = _crimeCaseService.CreateCase(Description,IncidentID);
                if (addCase.Equals(null))
                {
                    Console.WriteLine("Failed!! Case not Created");
                }
                else
                {
                    Console.WriteLine("Created case Successfully");
                }
           
        }
        public void GetCaseDetails()
        {
            Console.WriteLine("Enter CaseID::");
            int CaseID = int.Parse(Console.ReadLine());
            

                Cases getCaseDetails = _crimeCaseService.GetCaseDetails(CaseID);
                if (getCaseDetails.Equals(null))
                {
                    Console.WriteLine("No record found");
                }
                else
                {
                    Console.WriteLine(getCaseDetails.ToString());
                }
           
        }


        public void UpdateCaseDetails()
        {
            
            Console.WriteLine("Enter CaseID::");
            int CaseID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Description::");
            string Description = Console.ReadLine();
            Cases cases = new Cases(CaseID,Description,0);

            
                bool updateUserCaseDetail = _crimeCaseService.UpdateCaseDetails(cases);
                if (updateUserCaseDetail)
                {
                    Console.WriteLine("Updated Case Detail successful");
                }
                else
                {
                    Console.WriteLine("Failed!! Update Case Detail Unsuccessful");
                }
           
        }
        public void GetAllCases()
        {
            Console.WriteLine("Here All the Cases!!");
            
           
                List<Cases> getAllCases = _crimeCaseService.GetAllCases();
                if (getAllCases.Any())
                {
                    foreach (Cases obj in getAllCases)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No record found");
                }
           
        }

    }
}
