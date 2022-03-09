using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVCCore.UIWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(40, ErrorMessage = "Maximo 40 caracteres")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dirrecion { get; set; }
        [Display(Name ="Fecha Nacimiento")]
        public DateTime FechaNacimiento { get => m_FechaNacimiento; set => m_FechaNacimiento = value; }

        private DateTime m_FechaNacimiento;
    }
}
