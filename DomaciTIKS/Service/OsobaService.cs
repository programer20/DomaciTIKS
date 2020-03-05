using DomaciTIKS.models;
using DomaciTIKS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomaciTIKS.Service
{
    public class OsobaService
    {
        private readonly OsobaRepository _osobaRepository;

        public OsobaService(OsobaRepository osobaRepository)
        {
            this._osobaRepository = osobaRepository;
        }

        public void obrisiOsobu(int id)
        {
            _osobaRepository.obrisiOsobu(id);
        }

        public List<Osoba> vratiOsobe()
        {
            return _osobaRepository.vratiOsobe();
        }

        public Osoba vratiOsobu(int id)
        {
            return _osobaRepository.vratiOsobu(id);
        }

        public void sacuvajOsobu(Osoba osoba)
        {
            if (OsobaValidator.IsOsobaValid(osoba))
                _osobaRepository.sacuvajOsobu(osoba);
            else
                throw new ArgumentException("Format podataka nije ispravan");
        }

        public void izmeniOsobu(Osoba osoba)
        {
            if (OsobaValidator.IsOsobaValid(osoba))
                _osobaRepository.izmeniOsobu(osoba);
            else
                throw new ArgumentException("Format podataka nije ispravan");
        }
    }
}
