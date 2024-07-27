using EXAMENP1_VIÑANSACA.Comunes;
using EXAMENP1_VIÑANSACA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EXAMENP1_VIÑANSACA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoEquiposController : ControllerBase
    {
      

        // GET api/<HistoricoEquiposController>/5
        [HttpGet("{id}")]
        public List<HistoricoEquipos> Get(int id)
        {
            return ConexionBD.GetHistoricoEquipos(id);
        }

        
    }
}
