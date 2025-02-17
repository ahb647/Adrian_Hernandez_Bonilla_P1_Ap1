using System.ComponentModel.DataAnnotations;

namespace Adrian_Hernandez_Bonilla_P1_Ap1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "El Nombre de la persona es obligatorio")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El nombre  de la persona solo puede contener letras y espacios.")]

        public string Persona { get; set; }

        [Required(ErrorMessage = "La observacion es obligatoria obligatorio")]

        public string Observacion { get; set; }

        [Required(ErrorMessage = " El monto es obligatorio")]
        public decimal Monto {  get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "El Monto debe ser mayor a 0.")]


        public DateTime DateTime { get; set; }  = DateTime.Now; 



    }

}