using System.ComponentModel.DataAnnotations;

namespace PIA_BackEnd_1902187.Entidades
{
    public class Participante : IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 150, ErrorMessage = "El campo solo puede tener hasta 150 caracteres")]
        public string Nombre { get; set; }
        public List<ParticipanteRifa> ParticipanteRifa { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula",
                            new string[] { nameof(Nombre) });
                }
            }

        }
    }
}
