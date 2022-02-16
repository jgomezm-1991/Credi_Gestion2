using System;
using Credi_Gestion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Credi_Gestion.Data;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Credi_Gestion.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        private readonly ILogger<ClienteController> _logger;
        private readonly MyDbContext _context;


        public ClienteController(ILogger<ClienteController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult NuevoCliente()
        {
            return View();
        }
        public IActionResult NuevoCliente(Cliente cliente)
        {
            cliente.FechaReg = DateTime.Now;
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Clientes");
        }
        public IActionResult Clientes()
        {
            List<Cliente> clientes = _context.Cliente.ToList();
            return View(clientes);
        }
    }
}
