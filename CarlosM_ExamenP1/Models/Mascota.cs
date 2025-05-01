using System.ComponentModel.DataAnnotations;

namespace CarlosM_ExamenP1.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La raza de la mascota es obligatoria.")]
        [StringLength(50, ErrorMessage = "La raza no puede exceder los 50 caracteres.")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "La edad de la mascota es obligatoria.")]
        [Range(0, 30, ErrorMessage = "La edad debe estar entre 0 y 30 años.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El peso de la mascota es obligatorio.")]
        [Range(0.1, 200.0, ErrorMessage = "El peso debe estar entre 0.1 y 200.0 kg.")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "El sexo de la mascota es obligatorio.")]
        [StringLength(30, ErrorMessage = "El sexo no puede exceder los 30 caracteres.")]
        public string Sexo { get; set; }

    }
}
