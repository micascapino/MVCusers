using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COAChallenge.NETFramework.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("keydbUsuarios") { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}