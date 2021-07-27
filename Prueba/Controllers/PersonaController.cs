using Microsoft.AspNetCore.Mvc;
using Prueba.Data;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Controllers
{
    public class PersonaController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public PersonaController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {

            List<Persona> personas = new List<Persona>();
            personas = _applicationDbContext.Socio.ToList();

            return View(personas);
        }
    }
}
