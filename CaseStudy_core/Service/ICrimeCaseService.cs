using CaseStudy_core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_core.Service
{
    internal interface ICrimeCaseService
    {
        public void CreateCase();

        public void GetCaseDetails();

        public void UpdateCaseDetails();

        public void GetAllCases();
    }
}
