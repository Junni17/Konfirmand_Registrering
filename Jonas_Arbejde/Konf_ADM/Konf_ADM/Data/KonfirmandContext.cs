using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Konf_ADM.Models;
using Microsoft.EntityFrameworkCore;

namespace Konf_ADM.Data
{
    public class KonfirmandContext : DbContext
    {
        public KonfirmandContext(DbContextOptions<KonfirmandContext> options ) : base(options)
        {
        }

        public DbSet<Konfirmand> konfirmander { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Konfirmand>().ToTable("Konfirmand");
        }
    }
}
