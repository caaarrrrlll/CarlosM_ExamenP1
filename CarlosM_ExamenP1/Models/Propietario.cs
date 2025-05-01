using System.ComponentModel.DataAnnotations;

namespace CarlosM_ExamenP1.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El Nombre es obligatorio")]
        [StringLength(50, ErrorMessage ="El nombre no puede exceder los 50 caracters")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe ingresar un correo electronico")]
        [EmailAddress(ErrorMessage = "El correo electronico no es valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Debe indicar si poseé una mascota registrada")]
        public bool MascotaRegistrada { get; set; }
        [Required(ErrorMessage = "La fecha de ingreso es obligatoria")]
        [DataType(DataType.Date, ErrorMessage ="Fecha ingresada no valida")]
        public DateOnly DateOnly { get; set; }


        [Required(ErrorMessage ="Indique la cantidad de dinero dejado para la mascota")]
        [Range(0, 1000000, ErrorMessage = "El monto no puede ser menor a 0 ni mayor a 1.000.000")]
        public decimal  GastoMascota { get; set; }



    }
}
