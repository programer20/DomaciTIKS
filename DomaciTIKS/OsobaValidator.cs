using DomaciTIKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DomaciTIKS
{
    public static class OsobaValidator
    {
        public static bool IsOsobaValid(Osoba osoba)
        {
            if (!IsMaticniBrojValid(osoba.MaticniBroj, osoba.Rodjendan) || !IsImeValid(osoba.Ime) || !IsPrezimeValid(osoba.Prezime)
                || !IsVisinaValid(osoba.Visina) || !IsTezinaValid(osoba.Tezina) || !IsBojaOcijuValid(osoba.BojaOciju)
                || !IsTelefonValid(osoba.Telefon) || !IsEmailValid(osoba.Email) || !IsPrebivalisteValid(osoba.Prebivaliste))
                return false;
            return true;
        }

        public static bool IsMaticniBrojValid(string maticniBroj, DateTime rodjendan)
        {
            string datum = rodjendan.ToString("yyyy-MM-dd");

            if (maticniBroj.Length != 13)
                return false;

            if (!maticniBroj.Substring(0, 2).Equals(datum.Substring(8, 2)) ||
                !maticniBroj.Substring(2, 2).Equals(datum.Substring(5, 2)) ||
                !maticniBroj.Substring(4, 3).Equals(datum.Substring(1, 3)))
                return false;
         
            return true;
        }

        public static bool IsImeValid(string ime)
        {
            if (!Char.IsUpper(ime[0]))
                return false;

            return true;
        }

        public static bool IsPrezimeValid(string prezime)
        {
            if (!Char.IsUpper(prezime[0]))
                return false;
            return true;
        }

        public static bool IsVisinaValid(int? visina)
        { 
            if (visina == null)
                return true;

            if (visina < 35)
                return false;

            return true;
        }

        public static bool IsTezinaValid(int? tezina)
        {
            if (tezina == null)
                return true;

            if (tezina > 250)
                return false;

            return true;
        }

        public static bool IsBojaOcijuValid(string bojaOciju)
        {

            if(bojaOciju == null || bojaOciju.Equals("")
                || bojaOciju.Equals("plave") || bojaOciju.Equals("zelene") || bojaOciju.Equals("kestenjaste"))
                return true;

            return false;
        }

        public static bool IsTelefonValid(string telefon)
        {
            Regex regex = new Regex(@"^(\+381|0)6[0-9]{1}\.[0-9]{3}\.[0-9]{3,4}$");
            return regex.IsMatch(telefon);
        }

        public static bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@"^.+@.+\.rs$");
            return regex.IsMatch(email);
        }

        public static bool IsPrebivalisteValid(string prebivaliste)
        {
            if(prebivaliste.Equals("Beograd") || prebivaliste.Equals("Bor") || prebivaliste.Equals("Prijepolje") ||
                prebivaliste.Equals("Pirot") || prebivaliste.Equals("Sombor") || prebivaliste.Equals("Smederevo"))
                return true;

            return false;
        }

    }
}
