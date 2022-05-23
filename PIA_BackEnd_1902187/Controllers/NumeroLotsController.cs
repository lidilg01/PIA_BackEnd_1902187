using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIA_BackEnd_1902187.Entidades;
using AutoMapper;

namespace PIA_BackEnd_1902187.Controllers
{
    [ApiController]
    [Route("api/numerolots")]
    public class NumeroLotsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<NumeroLotsController> logger;
        private readonly IMapper mapper;

        public NumeroLotsController(ApplicationDbContext dbContext, ILogger<NumeroLotsController> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<NumeroLot>>> GetAll()
        {
            logger.LogInformation("Se obtiene el listado de Participantes");
            return await dbContext.NumeroLot.ToListAsync();
        }
    }
}
