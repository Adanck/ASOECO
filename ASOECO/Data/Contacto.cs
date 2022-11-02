using System.ComponentModel.DataAnnotations;

namespace Asoeco.Data
{
    public class Contacto
    {
        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de Email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo mensaje es obligatorio")]
        public string Mensaje { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        public string PhoneNumber { get; set; }


    }
}
