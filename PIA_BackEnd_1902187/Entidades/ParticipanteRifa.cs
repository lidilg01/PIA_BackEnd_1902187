using System.ComponentModel.DataAnnotations;

namespace PIA_BackEnd_1902187.Entidades
{
    public class ParticipanteRifa
    {
        [Required]
        public int ParticipanteId { get; set; }
        public int RifaId { get; set; }
        public Participante Participante { get; set; }
        public Rifa Rifa { get; set; }

    }
}
