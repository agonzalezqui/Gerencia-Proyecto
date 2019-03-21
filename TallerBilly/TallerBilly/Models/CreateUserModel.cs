using TallerBilly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TallerBilly.Models
{
    public partial class CreateUserModel
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Contacto { get; set; }

        [Required]
        public string Direccion { get; set; }


    }
}