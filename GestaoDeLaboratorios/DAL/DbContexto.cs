using System;
using GestaodeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaodeLaboratorios.DAL
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Computadores> Computadores { get; set; }
    }

}