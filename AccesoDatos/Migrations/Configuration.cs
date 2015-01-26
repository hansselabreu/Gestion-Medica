namespace AccesoDatos.Migrations
{
    using CapaNegocios;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AccesoDatos.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AccesoDatos.Database context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Paciente> pacientes = new List<Paciente>
            {
                
                new Paciente { 
                    Nombres = "Anna Ramona", 
                    Apellidos = "Pérez Volquez",
                    Edad = 33,
                    Cedula = "001-2348576-7",
                    Direccion = "Calle la zurza #22, Villa Liberación, Santo Domingo Oeste",
                    EstadoCivil = ESTADOCIVIL.Soltero,
                    Nacionalidad = "Dominicana",
                    Sexo = SEXO.Femenino,
                    NivelEscolar = NIVELESCOLAR.Grado,
                    Telefono = "599-9565"
                }
                    
            };
            foreach (var paciente in pacientes)
            {

                context.Pacientes.AddOrUpdate(
                    p => p.Cedula,
                    paciente
                );
            }
        }
    }
}
