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

        //private readonly OsobaRepository _osobaRepository;

        //public OsobaController(OsobaRepository osobaRepository)
        //{
        //    this._osobaRepository = osobaRepository;
        //}

        private readonly OsobaService _osobaRepository;

        public OsobaController(OsobaService osobaRepository)
        {
            this._osobaRepository = osobaRepository;
        }

        //[HttpPost("dodajOsobu")]
        //public void dodajArtikla([FromBody]Osoba osoba)
        //{
        //    _osobaService.sacuvajOsobu(osoba);
        //}

        //[HttpPost("izmeniArtikal")]
        //public bool izmeniOsobu([FromBody]Osoba osoba)
        //{
        //    _osobaService.izmeniOsobu(osoba);
        //}

        [HttpGet("obrisiOsobu/{id}")]
        public void obrisiOsobu(int id)
        {
            _osobaRepository.obrisiOsobu(id);
        }
    }
}
