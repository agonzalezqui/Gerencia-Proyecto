//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TallerBilly.Models
{
    using TallerBilly.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;

    public partial class createcarmodel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public createcarmodel()
        {
            this.carstousers = new HashSet<carstouser>();
        }
    
        public int Id { get; set; }
        public string Placa { get; set; }
        public string VIN { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        [Display(Name = "A�o")]
        public string Ano { get; set; }
        public string Combustible { get; set; }
        public string Transmision { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carstouser> carstousers { get; set; }
    }
}
