using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Parcial_.Data;
using Parcial_.Models;

namespace Parcial_.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;
        private readonly ApplicationDbContext _context;

        public JugadorController(ILogger<JugadorController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        
        }
        
        public IActionResult Index()
        {
            ViewBag.Equipos = _context.DbSetEquipos.ToList(); // Carga la lista de equipos
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(Jugadores jugador)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.DbSetJugadores.Add(jugador); // Guarda el jugador en la base de datos
                    _context.SaveChanges();
                    _logger.LogInformation("Se registró el jugador");
                    ViewData["Message"] = "Se registró el jugador correctamente";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al registrar el jugador");
                    ViewData["Message"] = "Error al registrar el jugador: " + ex.Message;
                }
            }
            else
            {
                ViewData["Message"] = "Datos de entrada no válidos";
            }
            ViewBag.Equipos = _context.DbSetEquipos.ToList();
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}