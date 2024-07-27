using EXAMENP1_VIÑANSACA.Comunes;
using EXAMENP1_VIÑANSACA.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EXAMENP1_VIÑANSACA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolistaController : ControllerBase
    {
        // GET: api/<FutbolistaController>
        [HttpGet]
        public List<Futbolista> Getfutbolistas()
        {
            return ConexionBD.Futbolistas();
        }

        // GET api/<FutbolistaController>/5
        [HttpGet("{id}")]
        public Futbolista Get(int id)
        {
           return ConexionBD.Jugador(id);
        }

        // POST api/<FutbolistaController>
        [HttpPost]
        public void Post([FromBody] Futbolista obJFutbolista)
        {
            ConexionBD.PostFutbolista(obJFutbolista);
        }

        // PUT api/<FutbolistaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Futbolista obJFutbolista)
        {
            ConexionBD.PutFutbolista(id, obJFutbolista);
        }

        // DELETE api/<FutbolistaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ConexionBD.DeleteFutbolista(id);
        }
    }
}
