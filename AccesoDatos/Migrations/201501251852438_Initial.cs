namespace AccesoDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        EstadoCivil = c.Int(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Edad = c.Int(nullable: false),
                        Nacionalidad = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Cedula = c.String(),
                        NivelEscolar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
