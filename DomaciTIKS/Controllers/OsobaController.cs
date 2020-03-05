using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomaciTIKS.models;
using DomaciTIKS.Repository;
using DomaciTIKS.Service;
using Microsoft.AspNetCore.Mvc;


namespace DomaciTIKS.Controllers
{
    [Route("osoba")]
    public class OsobaController: Controller
    {

        private readonly OsobaService _osobaService;

        public OsobaController(OsobaService osobaService)
        {
            this._osobaService = osobaService;
        }

        [HttpPost("dodajOsobu")]
        public void sacuvajOsobu([FromBody]Osoba osoba)
        {
            _osobaService.sacuvajOsobu(osoba);
        }

        [HttpPost("izmeniOsobu")]
        public void izmeniOsobu([FromBody]Osoba osoba)
        {
            _osobaService.izmeniOsobu(osoba);
        }

        [HttpDelete("obrisiOsobu/{id}")]
        public void obrisiOsobu(int id)
        {
            _osobaService.obrisiOsobu(id);
        }

        [HttpGet("vratiOsobe")]
        public List<Osoba> vratiOsobe()
        {
            return _osobaService.vratiOsobe();
        }

        [HttpGet("vratiOsobu/{id}")]
        public Osoba vratiOsobu(int id)
        {
            return _osobaService.vratiOsobu(id);
        }

        [HttpGet("test")]
        public void test()
        {
            Console.WriteLine("maticni broj: " + OsobaValidator.IsMaticniBrojValid("2502996123456", new DateTime(1996,2,25)));
            Console.WriteLine("ime: " + OsobaValidator.IsImeValid("pera"));
            Console.WriteLine("prezime: " + OsobaValidator.IsPrezimeValid("Pera"));
            Console.WriteLine("visina: " + OsobaValidator.IsVisinaValid(179));
            Console.WriteLine("tezina: " + OsobaValidator.IsTezinaValid(800));
            Console.WriteLine("oci true: " + OsobaValidator.IsBojaOcijuValid("zelene"));
            Console.WriteLine("oci false: " + OsobaValidator.IsBojaOcijuValid("smedje"));
            Console.WriteLine("telefon: " + OsobaValidator.IsTelefonValid("063.123.567"));
            Console.WriteLine("telefon: " + OsobaValidator.IsTelefonValid("+38165.123.567"));
            Console.WriteLine("telefon: " + OsobaValidator.IsTelefonValid("063.123.567412"));
            Console.WriteLine("telefon: " + OsobaValidator.IsTelefonValid("+38165123.567"));
            Console.WriteLine("email: " + OsobaValidator.IsEmailValid("asd@asd.rs"));
            Console.WriteLine("prebivaliste: " + OsobaValidator.IsPrebivalisteValid("Beograd"));

        }

    }
}
