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
    public partial class CreateCarModel
    {
        public int Id { get; set; }   
        [Required]
        public string Placa { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [Display(Name = "Año")]
        public string Ano { get; set; }
        [Required]
        public string Combustible { get; set; }
        public string Transmision { get; set; }

        public virtual ICollection<CreateUserModel> ApprovedClients { get; set; }
    }
}