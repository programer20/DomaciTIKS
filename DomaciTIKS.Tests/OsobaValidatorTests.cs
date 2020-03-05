using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DomaciTIKS.Tests
{
    public class OsobaValidatorTests
    {

        [Fact]
        public void IsMaticniBrojValid_Ispravno()
        {
            string maticniBroj = "2402996123456";
            DateTime rodjendan = new DateTime(1996, 2, 24);

            Assert.True(OsobaValidator.IsMaticniBrojValid(maticniBroj, rodjendan));
        }

        [Fact]
        public void IsMaticniBrojValid_Neispravno()
        {
            string maticniBroj = "2302996123456";
            DateTime rodjendan = new DateTime(1996, 2, 24);

            Assert.False(OsobaValidator.IsMaticniBrojValid(maticniBroj, rodjendan));
        }

        [Fact]
        public void IsMaticniBrojValid_Neispravno_Nema13Cifara()
        {
            string maticniBroj = "23029961234563423";
            DateTime rodjendan = new DateTime(1996, 2, 24);

            Assert.False(OsobaValidator.IsMaticniBrojValid(maticniBroj, rodjendan));
        }

        [Fact]
        public void IsImeValid_Ispravno()
        {
            string ime = "Pera";

            Assert.True(OsobaValidator.IsImeValid(ime));
        }

        [Fact]
        public void IsImeValid_Neispravno_MaloPocetnoSlovo()
        {
            string ime = "pera";

            Assert.False(OsobaValidator.IsImeValid(ime));
        }

        [Fact]
        public void IsPrezimeValid_Ispravno()
        {
            string prezime = "Peric";

            Assert.True(OsobaValidator.IsPrezimeValid(prezime));
        }

        [Fact]
        public void IsPrezimeValid_Neispravno_MaloPocetnoSlovo()
        {
            string prezime = "peric";

            Assert.False(OsobaValidator.IsPrezimeValid(prezime));
        }

        [Fact]
        public void IsVisinaValid_Ispravno()
        {
            int visina = 180;

            Assert.True(OsobaValidator.IsVisinaValid(visina));
        }

        [Fact]
        public void IsVisinaValid_Neispravno_ManjaOdGranice()
        {
            int visina = 20;

            Assert.False(OsobaValidator.IsVisinaValid(visina));
        }

        [Fact]
        public void IsTezinaValid_Ispravno()
        {
            int tezina = 60;

            Assert.True(OsobaValidator.IsTezinaValid(tezina));
        }

        [Fact]
        public void IsTezinaValid_Neispravno_VecaOdGranice()
        {
            int tezina = 700;

            Assert.False(OsobaValidator.IsTezinaValid(tezina));
        }

        [Fact]
        public void IsBojaOcijuValid_Ispravno()
        {
            string bojaOciju = "plave";

            Assert.True(OsobaValidator.IsBojaOcijuValid(bojaOciju));
        }

        [Fact]
        public void IsBojaOcijuValid_Neispravno()
        {
            string bojaOciju = "smedje";

            Assert.False(OsobaValidator.IsBojaOcijuValid(bojaOciju));
        }

        [Fact]
        public void IsTelefonValid_Ispravno_Format1()
        {
            string telefon = "063.123.456";

            Assert.True(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Ispravno_Format2()
        {
            string telefon = "063.123.4567";

            Assert.True(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Ispravno_Format3()
        {
            string telefon = "+38163.123.456";

            Assert.True(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Ispravno_Format4()
        {
            string telefon = "+38163.123.4567";

            Assert.True(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Neispravno_BezTacke()
        {
            string telefon = "+381631234567";

            Assert.False(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Neispravno_BrojCifara()
        {
            string telefon = "+38163123456789021";

            Assert.False(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsTelefonValid_Neispravno_PocetakBroja()
        {
            string telefon = "963.123.456";

            Assert.False(OsobaValidator.IsTelefonValid(telefon));
        }

        [Fact]
        public void IsEmailValid_Ispravno()
        {
            string email = "pera@gmail.rs";

            Assert.True(OsobaValidator.IsEmailValid(email));
        }

        [Fact]
        public void IsEmailValid_Neispravno_Domen()
        {
            string email = "pera@gmail.com";

            Assert.False(OsobaValidator.IsEmailValid(email));
        }

        [Fact]
        public void IsEmailValid_Neispravno_NemaSimbol()
        {
            string email = "peragmail.rs";

            Assert.False(OsobaValidator.IsEmailValid(email));
        }

        [Fact]
        public void IsPrebivalisteValid_Ispravno()
        {
            string prebivaliste = "Beograd";

            Assert.True(OsobaValidator.IsPrebivalisteValid(prebivaliste));
        }

        [Fact]
        public void IsPrebivalisteValid_Neispravno_MaloSlovo()
        {
            string prebivaliste = "beograd";

            Assert.True(OsobaValidator.IsPrebivalisteValid(prebivaliste));
        }

        [Fact]
        public void IsPrebivalisteValid_Neispravno()
        {
            string prebivaliste = "London";

            Assert.False(OsobaValidator.IsPrebivalisteValid(prebivaliste));
        }

    }
}
