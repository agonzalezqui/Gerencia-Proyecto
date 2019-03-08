using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

public class TallerBillyDB
{
    public class TallerBillyDB : DbContext
    {
        public DbSet<CreateCarModel> CreatedCars { get; set; }
    }
}
