using CaseStudy_core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Repository
{
    internal interface ICrimeCaseRepo
    {
        // Create a new case and associate it with incidents
        Cases CreateCase(string description,int incidentID);

        // Get details of a specific case\
        Cases GetCaseDetails(int caseId);


        //update case detail
        bool UpdateCaseDetails(Cases updatedcase);

        //Get a list of all cases
        List<Cases> GetAllCases();

    }
}
