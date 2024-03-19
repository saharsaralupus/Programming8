using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; } //Primary Key

        //Esto se pone encima del campo a llenar
        [Display(Name = "Document")] //Muetra un nombre de campo en la etiqueta 
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligaptorio")]

        public string Document { get; set; }

        [Display(Name = "Nombre")] 
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dcaracteres")]
        [Required(ErrorMessage = "El campo {0} es obligaptorio")]

        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dcaracteres")]
        [Required(ErrorMessage = "El campo {0} es obligaptorio")]

        public string LastName { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dcaracteres")]
        [Required(ErrorMessage = "El campo {0} es obligaptorio")]
        [EmailAddress(ErrorMessage = "Digite un Email válido")]

        public string Email { get; set; }   


        public string FixedPhone { get; set; }  
        public string CellPhone {  get; set; }
        public string Address { get; set; }

        //Concatenation of the fields FirsName + LastName
        public string FullName => $"{FirstName}{LastName}";    


        

       
    }
}
