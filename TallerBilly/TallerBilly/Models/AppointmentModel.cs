using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallerBilly.Models
{
    public class AppointmentModel
    {
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public string Vehiculo { get; set; } 
        public string Agente { get; set; }
        public string Comentarios { get; set; }
    
    }
}