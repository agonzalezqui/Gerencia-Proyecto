using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallerBilly.Models
{
    public class CreateCarModel
    {
        [Required]
        public string Placa { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Ano { get; set; }
        [Required]
        public string Combustible { get; set; }
        public string Transmision { get; set; }

    }
}