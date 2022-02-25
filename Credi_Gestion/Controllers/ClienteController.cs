﻿using System;
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

        public IActionResult NuevosCliente(Cliente cliente)
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


        public IActionResult EditarCliente(int IdCliente)
        {
            Cliente cliente=_context.Cliente.Where(C=>C.IdCliente==IdCliente).FirstOrDefault();
            return View(cliente);
           
        }

        public IActionResult EditarValorCliente(Cliente cliente)
        {
            //Recupero el valor actual en la base de datos

            Cliente ClienteActual = _context.Cliente
            .Where(a => a.IdCliente == cliente.IdCliente).FirstOrDefault();
            ClienteActual.NombreCliente=cliente.NombreCliente;
            ClienteActual.Apellidos=cliente.Apellidos;
            ClienteActual.Genero=cliente.Genero;
            ClienteActual.Cedula=cliente.Cedula;
            ClienteActual.Direccion=cliente.Direccion;
            ClienteActual.Telefono=cliente.Telefono;    
            ClienteActual.Estado=cliente.Estado;
            _context.SaveChanges();
            List<Cliente>clientes=_context.Cliente.ToList();
            return View("Clientes",clientes);

        }
        public IActionResult EliminarCliente(int IdCliente)
        {
            // con entityframewor
            List<Prestamo> prestamo = _context.Prestamo.Where(c=> c.IdPrestamo == IdCliente).ToList();
            if (prestamo!= null)
                _context.RemoveRange(prestamo);

            Cliente cliente=_context.Cliente.Where(c=>c.IdCliente==IdCliente).FirstOrDefault();
            if(cliente != null)
        _context.Remove(cliente);
            _context.SaveChanges();
            List<Cliente> clientes = _context.Cliente.ToList();
            return View("Clientes",clientes);
        }

    }
}
