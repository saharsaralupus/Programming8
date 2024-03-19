using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de servicio")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dcaracteres")]
        [Required(ErrorMessage = "El campo {0} es obligaptorio")]
        public string Name { get; set; }
    }
}
