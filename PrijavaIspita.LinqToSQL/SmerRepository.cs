using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijavaIspita.Domain;
using PrijavaIspita.Domain.Repository;

namespace PrijavaIspita.LinqToSQL
{
   public class SmerRepository : ISmerRepository
    {
        private PrijavaIspitaDataContext prijavaIspitaDataContext = new PrijavaIspitaDataContext();

        public void Create(SmerBo smer)
        {
            throw new NotImplementedException();
        }

        public void Delete(SmerBo smer)
        {
            throw new NotImplementedException();
        }

        public void Edit(SmerBo smer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SmerBo> GetAll()
        {
            List<SmerBo> smerovi = new List<SmerBo>();
            foreach(Smer smer in prijavaIspitaDataContext.Smers)
            {
                smerovi.Add(Map(smer));
            }
            return smerovi;
        }

        private SmerBo Map(Smer smer)
        {
            SmerBo smerBo = new SmerBo
            {
                Id = smer.idSmer,
                Naziv = smer.naziv
            };
            return smerBo;
        }

        public SmerBo GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
