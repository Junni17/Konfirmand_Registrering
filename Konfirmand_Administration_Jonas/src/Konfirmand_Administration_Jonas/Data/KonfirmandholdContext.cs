using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Konfirmand_Administration_Jonas.Models;


namespace Konfirmand_Administration_Jonas.Data
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
