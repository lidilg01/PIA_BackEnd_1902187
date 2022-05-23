using System.ComponentModel.DataAnnotations;

namespace PIA_BackEnd_1902187.Entidades
{
    public class Premio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Contenido { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int NumPremio { get; set; }
        public Participante Participante { get; set; }
        public Rifa Rifa { get; set; }

    }
}
