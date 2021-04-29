using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace COAChallenge.NETFramework.Models
{
    public class UsuariosInitializer : DropCreateDatabaseAlways<UsuarioContext>
    {
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }
        protected override void Seed(UsuarioContext context)
        {
            var usuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    Username="micascapino",
                    Nombre="Micaela Scapino",
                    Email="micascapinomdq@gmail.com",
                    Telefono="1122334455",
                }
            };
            usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();
        }
    }
}