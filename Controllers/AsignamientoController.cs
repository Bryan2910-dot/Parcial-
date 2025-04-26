using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parcial_.Data;
using Parcial_.Models;
using Microsoft.EntityFrameworkCore;

namespace Parcial_.Controllers
{
    
    public class AsignamientoController : Controller
    {
        private readonly ILogger<AsignamientoController> _logger;
        private readonly ApplicationDbContext _context;

        public AsignamientoController(ILogger<AsignamientoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
                // Carga las asignaciones completas
            var asignaciones = _context.DbSetAsignamiento
                .Include(a => a.Jugador) // Incluye los datos del jugador
                .Include(a => a.Equipo)  // Incluye los datos del equipo
                .ToList();

            // Almacena las asignaciones en ViewBag
            ViewBag.Asignaciones = asignaciones;


            Debug.WriteLine($"Asignaciones: {asignaciones.Count}");
            foreach (var asignacion in asignaciones)
            {
                Debug.WriteLine($"Asignación ID: {asignacion.Id}, Jugador ID: {asignacion.JugadorId}, Equipo ID: {asignacion.EquipoId}");
            }

            return View();
        }
         

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}