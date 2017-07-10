using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Konf_ADM.Models;

namespace Konf_ADM.Data
{
    public static class InitDB
    {
        public static void Initialize(KonfirmandContext context)
        {
            context.Database.EnsureCreated();

            if(context.konfirmander.Any())
            {
                return;
            }

            var konfirmander = new Konfirmand[]
            {
                new Konfirmand{ KonfirmandholdID = 1, Name = "Peter", BirthDay = "040302", Baptized = false, Address = "Her bor han", Phone = "83828183"},
                new Konfirmand{ KonfirmandholdID = 1, Name = "Hans", BirthDay = "093302", Baptized = true, Address = "Petervej 31", Phone = "83231233"},
                new Konfirmand{ KonfirmandholdID = 1, Name = "Kaj", BirthDay = "111111", Baptized = false, Address = "HLOL", Phone = "81230912"}
            };

            foreach(Konfirmand k in konfirmander)
            {
                context.konfirmander.Add(k);
            }

            context.SaveChanges();
        }
    }
}
