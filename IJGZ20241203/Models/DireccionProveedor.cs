using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IJGZ20241203.Models
{
    public class DireccionProveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDireccion { get; set; }
        public int ProveedorId {  get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(200,ErrorMessage ="200 caracteres maximo")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {} es requerido")]
        [MaxLength(30, ErrorMessage ="Máximo 30 caracteres")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El campo País es requerido")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Pais { get; set; }
    }
}
