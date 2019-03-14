using TallerBilly.Models;
using System;
using System.Data.Entity;
using System.Linq;


namespace TallerBilly.Models
{

    public class TallerBillyDB : DbContext
    {
        public DbSet<CreateCarModel> CreatedCars { get; set; }
        public DbSet<CreateUserModel> CreatedUsers { get; set; }
        // Your context has been configured to use a 'TallerBilly' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TallerBilly.TallerBilly' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TallerBilly' 
        // connection string in the application configuration file.
        public TallerBillyDB()
            : base("name=TallerBillyDB")
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}