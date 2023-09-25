using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets_MVC_SP5.Models;

namespace LHPets_MVC_SP5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Customer cliente1 = new Customer(01, "Arthur A. Ferreira", 857032950, "arthur.antunes@sp.senai.br", "Madruga");
        Customer cliente2 = new Customer(02, "William Henry Gates III", 039618250, "bill@microsoft.com", "Bug");
        Customer cliente3 = new Customer(03, "Ada Lovelace", 800777920, "ada@ada.language.com", "Byron");
        Customer cliente4 = new Customer(04, "Linus Torvalds", 933622400, "torvalds@osdl.org","Pinguim");
        Customer cliente5 = new Customer(05, "Grace Hopper", 911702988, "grace.hopper@cobol.com", "Loboc");

        Supplier fornecedor1 = new Supplier(01, "C#PET S/A", 1418210201, "c-sharp@pet.org");
        Supplier fornecedor2 = new Supplier(02, "CtrlAlt Dog", 1583669800, "ctrl@alt.dog.br");
        Supplier fornecedor3 = new Supplier(03,"BootsPet INC", 408102240, "boots.pet@gatomania.us");
        Supplier fornecedor4 = new Supplier(04, "TikTok Dogs", 879453500, "noisnamidia@tiktokdogs.uk");
        Supplier fornecedor5 = new Supplier(05, "Bifinho Forever", 1876061401, "contato@bff.us");

        List<Customer> customerList = new List<Customer>();
        customerList.Add(cliente1);
        customerList.Add(cliente2);
        customerList.Add(cliente3);
        customerList.Add(cliente4);
        customerList.Add(cliente5);
        
        List<Supplier> supplierList = new List<Supplier>();
        supplierList.Add(fornecedor1);
        supplierList.Add(fornecedor2);
        supplierList.Add(fornecedor3);
        supplierList.Add(fornecedor4);
        supplierList.Add(fornecedor5);        

        ViewBag.customerList = customerList;
        ViewBag.supplierList = supplierList;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
