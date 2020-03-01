using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomaciTIKS.models
{
    public class Osoba
    {
        public int Id { get; set; }
        public string MaticniBroj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Visina { get; set; }
        public int Tezina { get; set; }
        public string BojaOciju { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Rodjendan { get; set; }
        public string Prebivaliste { get; set; }
        public string Adresa { get; set; }
    }
}
