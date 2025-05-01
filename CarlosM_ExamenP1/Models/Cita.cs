
using System.ComponentModel.DataAnnotations;

namespace CarlosM_ExamenP1.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Fecha de la cita es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Fecha cita no valida")]
        public DateOnly FechaCita { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio")]
        [StringLength(100, ErrorMessage = "El motivo no puede exceder los 100 caracteres.")]
        public string Motivo { get; set; }

        [Required(ErrorMessage = "Debe indicar si la mascota requiere medacamento")]
        public bool Estado { get; set; } = true;

        [Required(ErrorMessage = "La tarifa es obligatoria")]
        [Range(0, 1000000, ErrorMessage = "La tarifa no puede ser menor a 0 ni mayor a 1.000.000")]
        public decimal Tarifa { get; set; }


        public void CalcularTarifa()
        {
            switch (Motivo.ToLower())
            {
                case "vacunacion":
                    Tarifa = 30;
                    break;
                case "revision general":
                    Tarifa = 20;
                    break;
                case "cirugia":
                    Tarifa = 100;
                    break;
            }

        }
    }
}
