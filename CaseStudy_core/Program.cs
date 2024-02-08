using CaseStudy_core.Service;
using CaseStudy_core.Model;
using CaseStudy_core.Repository;
using CaseStudy_core;
using CaseStudy_core.Exceptions;

try
{
    ICrimeAnalysisServiceImpl service = new CrimeAnalysisServiceImpl();
    ICrimeCaseService caseService1 = new CrimeCaseService();


    string choice;

    do
    {
        Console.Clear();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Welcome to Crime Analysis Reporting System");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Select an option:");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Create Incident");
        Console.WriteLine("2. Update Incident Status");
        Console.WriteLine("3. Get Incidents within Date Range");
        Console.WriteLine("4. Search Incident");
        Console.WriteLine("5. Generate Incident Report");
        Console.WriteLine("6. Create Case");
        Console.WriteLine("7. Get Case Details");
        Console.WriteLine("8. Update Case Details");
        Console.WriteLine("9. Get All Cases");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("10. Exit");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Enter Your Option:");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                service.CreateIncident();
                break;

            case "2":
                Console.Clear();
                service.UpdateIncidentStatus();
                break;

            case "3":
                Console.Clear();
                service.GetIncidentsInDateRange();
                break;

            case "4":
                Console.Clear();
                service.SearchIncident();
                break;

            case "5":
                Console.Clear();
                service.GenerateIncidentReport();
                break;

            case "6":
                Console.Clear();
                caseService1.CreateCase();
                break;

            case "7":
                Console.Clear();
                caseService1.GetCaseDetails();
                break;

            case "8":
                Console.Clear();
                caseService1.UpdateCaseDetails();
                break;

            case "9":
                Console.Clear();
                caseService1.GetAllCases();
                break;

            case "10":
                Console.WriteLine("Exiting the program.");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(); // Wait for user input before clearing the console and showing menu again

    } while (choice != "10");
}
catch (IncidentNumberNotFoundException Inex)
{
    Console.WriteLine(Inex.Message);
}
