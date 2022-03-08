using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MotorDeBusqueda.Data;
using MotorDeBusqueda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorDeBusqueda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrendaController : ControllerBase
    {

        private readonly ILogger<PrendaController> _logger;

        public PrendaController(ILogger<PrendaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Prenda> GetPrendas()
        {
            IEnumerable<Prenda> resultado = PrendaData.Datos();
            List<Prenda> list = PrendaData.Datos();
            return resultado;
        }

        [HttpGet("id/{id}")]
        public Prenda GetPrendaById(int id)
        {   Prenda resultado = new Prenda();
            List<Prenda> list = PrendaData.Datos();
            foreach(Prenda prenda in list)
            {
                if(prenda.Id == id)
                {
                    resultado = prenda;
                }
            }
            return resultado;
        }
        [HttpGet("nombre/{nombre}")]
        public IEnumerable<Prenda> GetPrendaByNombre(string nombre)
        {
            List<Prenda> resultado = new List<Prenda>();
            List<Prenda> list = PrendaData.Datos();
            foreach (Prenda prenda in list)
            {
                if (prenda.Nombre.ToLower().Contains(nombre.ToLower()))
                {
                    resultado.Add(prenda);
                }
            }
            return resultado;
        }

    }
}
