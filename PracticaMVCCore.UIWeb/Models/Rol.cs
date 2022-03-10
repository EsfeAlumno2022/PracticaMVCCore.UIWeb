using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ********************************
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaMVCCore.UIWeb.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Nombre { get; set; }
        [NotMapped]
        public int Top_Aux { get; set; }      
    }
}
