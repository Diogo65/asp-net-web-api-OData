using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    public class VagaContext : DbContext
    {
        public VagaContext() : base("DbVagas")
        {
        }

        public DbSet<Vaga> Vagas { get; set; }
    }
}