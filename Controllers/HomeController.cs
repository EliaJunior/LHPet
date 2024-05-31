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
        //Instâncias do tipo cliente
        Cliente cliente1 = new Cliente(1, "Alex G. Ferreira", "123.456.789-00", "alex@gmail.com", "Batman");
        Cliente cliente2 = new Cliente(2, "Maria S. Oliveira", "123.456.789-00", "maria@gmail.com", "Isadora");
        Cliente cliente3 = new Cliente(3, "Carlos C. Campos", "123.456.789-00", "carlos@gmail.com", "Bob");
        Cliente cliente4 = new Cliente(4, "Olinda T. Ferraz", "123.456.789-00", "olinda@gmail.com", "Rex");
        Cliente cliente5 = new Cliente(5, "Carla G. Cruz", "123.456.789-00", "carla@gmail.com", "Pop");

        //Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();

        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(1, "C# Rações", "12.345.789/0001-00", "cjvelha@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Python Brinquedos", "12.345.789/0001-00", "pybq@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "ASP Pet Soluções", "12.345.789/0001-00", "aspps@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "SQL Pets Coleiras LTDA", "12.345.789/0001-00", "sqlpc@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "VBA Animais LTD", "12.345.789/0001-00", "vbaanimals@gmail.com");

        //Lista de Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

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
