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

    }
}
