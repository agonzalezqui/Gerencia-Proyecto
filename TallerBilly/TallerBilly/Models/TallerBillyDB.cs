using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerBilly.Models
{
    public class TallerBillyDB : DbContext
    {
        public DbSet<CreateCarModel> CreatedCars { get; set; }
        public DbSet<CreateUserModel> CreatedUsers { get; set; }
    }
}