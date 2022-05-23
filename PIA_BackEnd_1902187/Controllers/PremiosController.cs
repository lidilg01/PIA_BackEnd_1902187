using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIA_BackEnd_1902187.Entidades;
using AutoMapper;

namespace PIA_BackEnd_1902187.Controllers
{
    [ApiController]
    [Route("api/premios")]
    public class PremiosController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<PremiosController> logger;
        private readonly IMapper mapper;

        public PremiosController(ApplicationDbContext dbContext, ILogger<PremiosController> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<Premio>>> GetAll()
        {
            logger.LogInformation("Se obtiene el listado de Premios");
            return await dbContext.Premio.ToListAsync();
        }
    }
}
