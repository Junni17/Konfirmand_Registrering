using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonfirmandAdministrering.Models;
using Microsoft.EntityFrameworkCore;

namespace KonfirmandAdministrering.Data
{
    public class KonfirmandholdContext : DbContext
    {
        public KonfirmandholdContext(DbContextOptions<KonfirmandholdContext> options ) : base(options)
        { }

        public DbSet<Konfirmandhold> hold { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Konfirmandhold>().ToTable("Konfirmandhold");
        }
    }
}
