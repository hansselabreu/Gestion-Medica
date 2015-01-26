using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Database:DbContext
    {
        public Database():base("unithepidConn")
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }

    }
}
