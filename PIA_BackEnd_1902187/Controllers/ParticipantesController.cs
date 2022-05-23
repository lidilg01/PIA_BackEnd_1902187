using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIA_BackEnd_1902187.Entidades;
using AutoMapper;

namespace PIA_BackEnd_1902187.Controllers
{
    [ApiController]
    [Route("api/participantes")]
    public class ParticipantesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<ParticipantesController> logger;
        private readonly IMapper mapper;

        public ParticipantesController(ApplicationDbContext dbContext, ILogger<ParticipantesController> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<Participante>>> GetAll()
        {
            logger.LogInformation("Se obtiene el listado de Participantes");
            return await dbContext.Participante.ToListAsync();
        }
    }
}
