using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIA_BackEnd_1902187.Entidades;

namespace PIA_BackEnd_1902187.Controllers
{
     [ApiController]
     [Route("api/rifas")]
     public class RifasController : ControllerBase
     {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<RifasController> logger ;
        private readonly IMapper mapper;


        public RifasController(ApplicationDbContext context, ILogger<RifasController> logger, IMapper mapper)
        {
            this.dbContext = context;
            this.logger = logger;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Rifa>>> GetAll()
        {
            logger.LogInformation("Se obtiene el listado de rifas");
            return await dbContext.Rifa.ToListAsync();
        }
    }
}
