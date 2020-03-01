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
    }
}
