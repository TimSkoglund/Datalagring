using Busniess.Services;

namespace Presentation.ConsoleApp;

public class MenuDialogs(CustomerSercie customerserice, ProcectService projektSerice)
{
    private readonly CustomerService _customerService;
    private readonly ProjectService _projectService;    
    

public async Task MenuOptions()
    {
        while (true)
        {
            Console.WriteLine("1. Create New Customer");
            Console.WriteLine("2. Create New Project");
            Console.WriteLine("3. List All Customers");
            Console.WriteLine("4. List All Projects");
            Console.WriteLine("5. Get Customer");
            Console.WriteLine("6. Get Projekt");

        }
    }
}