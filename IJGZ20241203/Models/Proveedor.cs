using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IJGZ20241203.Models
{
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage ="El campo {} es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El campo { } es requerido")]
        [Phone(ErrorMessage ="Digíte un número de teléfono valido")]
        public string Telefono {  get; set; }

        [EmailAddress(ErrorMessage ="Digíte un correo electronico valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo { } es requerido")]
        [MaxLength(75, ErrorMessage ="Máximo 75 caracteres")]
        public string Producto { get; set; }


        [Required(ErrorMessage = "El campo { } es requerido")]
        [Display(Name ="Fecha de registro")]
        public DateTime FechaRegistro { get; set; }

        public virtual IList<DireccionProveedor> DireccionesProveedor { get; set; }
    }
}
