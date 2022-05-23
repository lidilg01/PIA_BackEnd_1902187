using System.ComponentModel.DataAnnotations;

namespace PIA_BackEnd_1902187.Entidades
{
    public class Rifa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 150, ErrorMessage = "El campo solo puede tener hasta 150 caracteres")]
        public string Nombre { get; set; }
        public int CantPremios { get; set; }
        public List<ParticipanteRifa> ParticipanteRifa { get; set; }
        public List<NumeroLot> NumeroLots { get; set; }

    }
}
 