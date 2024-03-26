using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1, "Fulano", "111111111", "fulano.fulano", "yuki");
        Cliente cliente2 = new Cliente(2, "Fulano", "111111111", "fulano.fulano", "gabana");
        Cliente cliente3 = new Cliente(3, "Fulano", "111111111", "fulano.fulano", "choco");
        Cliente cliente4 = new Cliente(4, "Fulano", "111111111", "fulano.fulano", "lila");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(1, "Vegettaria", "123456", "vegettaria.vegettaria");
        Fornecedor fornecedor2 = new Fornecedor(2, "Vegettaria", "123456", "vegettaria.vegettaria");
        Fornecedor fornecedor3 = new Fornecedor(3, "Vegettaria", "123456", "vegettaria.vegettaria");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);

        ViewBag.listaFornecedores = listaFornecedores;

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
