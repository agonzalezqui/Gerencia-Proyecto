namespace TallerBilly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attempt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreateCarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(nullable: false),
                        VIN = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Ano = c.String(nullable: false),
                        Combustible = c.String(nullable: false),
                        Transmision = c.String(),
                        CreateUserModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CreateUserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Cedula = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Contacto = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        CreateCarModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CreateCarModels", t => t.CreateCarModel_Id)
                .Index(t => t.CreateCarModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreateUserModels", "CreateCarModel_Id", "dbo.CreateCarModels");
            DropIndex("dbo.CreateUserModels", new[] { "CreateCarModel_Id" });
            DropTable("dbo.CreateUserModels");
            DropTable("dbo.CreateCarModels");
        }
    }
}
