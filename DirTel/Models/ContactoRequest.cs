using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirTel.Models
{
    public class ContactoRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        [Required]

        public string TelefonoCelular { get; set; }
        public string TelefonoFijo { get; set; }
        public string Genero { get; set; }
    }
}
