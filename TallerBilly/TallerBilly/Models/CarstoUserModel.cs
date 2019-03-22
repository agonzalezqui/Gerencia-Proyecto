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
    public class CarstoUserModel
    {
        public int ID { get; set; }

        public virtual CreateCarModel Car { get; set; }
        public virtual CreateUserModel User { get; set; }
    }
}