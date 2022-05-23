using Microsoft.EntityFrameworkCore;
using PIA_BackEnd_1902187.Entidades;

namespace PIA_BackEnd_1902187
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Participante> Participante { get; set; }
        public DbSet<Rifa> Rifa { get; set; }
        public DbSet<Premio> Premio { get; set; }
        public DbSet<NumeroLot> NumeroLot { get; set; }
        public DbSet<ParticipanteRifa> ParticipanteRifa { get; set; }
        public DbSet<RifaNumLot> RifaNumLot { get; set; }
    }

    


}
