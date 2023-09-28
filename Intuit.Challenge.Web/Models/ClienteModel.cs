using System.ComponentModel.DataAnnotations;

namespace Intuit.Challenge.Web.Models
{
    /// <summary>
    /// Reutilizado del proyecto webapi, en teoria son dos aplicaciones diferentes
    /// /// </summary>
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "El campo {0} debe tener {1} dígitos")]
        public string CUIT { get; set; }
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Phone]
        public string TelefonoCelular { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
