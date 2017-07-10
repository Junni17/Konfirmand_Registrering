using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Konfirmand_Administration_Jonas.Models;

namespace Konfirmand_Administration_Jonas.Data
{
    public static class InitDB
    {
        public static void Initialize(KonfirmandholdContext context)
        {
            context.Database.EnsureCreated();

            if(context.hold.Any())
            {
                return;
            }

            var konfirmandhold = new Konfirmandhold[] { new Konfirmandhold { School = "Rosenvangsskolen", Year = "1993", Class = "7.a" }, new Konfirmandhold { School = "Åby skole", Year = "1997", Class = "7.c" },
                new Konfirmandhold {School = "Brabrand skole", Year = "2010", Class = "7.e" } };

            foreach(Konfirmandhold kh in konfirmandhold)
            {
                context.Add(kh);
            }

            context.SaveChanges();

        }
    }
}
