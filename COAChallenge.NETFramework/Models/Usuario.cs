using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COAChallenge.NETFramework.Models
{
    public class Usuario
    {
       
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo Username es obligatorio.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; } 

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email no valido. Reintente.")]
        public string Email { get; set; }

        public string Telefono { get; set; }
  
    }
}