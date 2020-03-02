using Dapper;
using DomaciTIKS.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DomaciTIKS.Repository
{
    public class OsobaRepository
    {
        private readonly string _connectionString;
        public OsobaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Osoba vratiOsobu(int id)
        {

            var param = new DynamicParameters(new
            {
                Id = id
            });

            using (var connection = new SqlConnection(_connectionString))
            {
                Osoba result = connection.Query<Osoba>("[dbo].[VratiOsobu]", param, commandType: CommandType.StoredProcedure).Single();

                Console.WriteLine(result.Id);
                return result;
            }
        }

        public List<Osoba> vratiOsobe()
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                List<Osoba> result = connection.Query<Osoba>("[dbo].[VratiOsobe]", null, commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

            public void sacuvajOsobu(Osoba osoba)
        {
            var param = new DynamicParameters(new
            {
                maticniBroj = osoba.MaticniBroj,
                ime = osoba.Ime,
                prezime = osoba.Prezime,
                visina = osoba.Visina,
                tezina = osoba.Tezina,
                bojaOciju = osoba.BojaOciju,
                telefon = osoba.Telefon,
                email = osoba.Email,
                rodjendan = osoba.Rodjendan,
                prebivaliste = osoba.Prebivaliste,
                adresa = osoba.Adresa
            });

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var result = connection.QueryMultiple("[dbo].[DodajOsobu]", param, null, null, CommandType.StoredProcedure))
                {
                }
            }
        }

        public void izmeniOsobu(Osoba osoba)
        {
            var param = new DynamicParameters(new
            {
                id = osoba.Id,
                maticniBroj = osoba.MaticniBroj,
                ime = osoba.Ime,
                prezime = osoba.Prezime,
                visina = osoba.Visina,
                tezina = osoba.Tezina,
                bojaOciju = osoba.BojaOciju,
                telefon = osoba.Telefon,
                email = osoba.Email,
                rodjendan = osoba.Rodjendan,
                prebivaliste = osoba.Prebivaliste,
                adresa = osoba.Adresa
            });

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var result = connection.QueryMultiple("[dbo].[IzmeniOsobu]", param, null, null, CommandType.StoredProcedure))
                {
                }
            }
        }


        public void obrisiOsobu(int id)
        {

            var param = new DynamicParameters(new
            {
                Id = id
            });

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var result = connection.QueryMultiple("[dbo].[ObrisiOsobu]", param, null, null, CommandType.StoredProcedure))
                {
                }
            }
        }
    }
}