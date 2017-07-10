using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Konfirmand_Administration_Jonas.Models
{//
    public class Konfirmand
    {
        public int ID { get; set; }
        public int KonfirmandholdID { get; set; }
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public bool Baptized { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        //public string[] ParentOne { get; set; }
        //public string[] ParentTwo { get; set; }

        //for associating models
        //public ICollection<Konfirmandhold> aktueltKonfirmandhold { get; set; }

    }
}
