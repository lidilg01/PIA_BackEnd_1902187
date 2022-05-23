using System.ComponentModel.DataAnnotations;

namespace PIA_BackEnd_1902187.Entidades
{
    public class NumeroLot
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 54, ErrorMessage = "El numero no esta dentro del rango permitido")]
        public string Numero { get; set; }
        [Required]
        public bool Registrado { get; set; }
        public Participante Participante { get; set; }
        public Rifa Rifa { get; set; }
    }
}
